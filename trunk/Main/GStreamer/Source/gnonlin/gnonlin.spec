Name: 		gnonlin
Version: 	0.10.13
Release:	1
Summary: 	GStreamer extension library for non-linear editing

Group: 		Applications/Multimedia
License: 	LGPL
URL:		http://gnonlin.sf.net/
Vendor:		GStreamer Backpackers Team <package@gstreamer.net>
Source:		http://download.sf.net/gnonlin/%{name}-%{version}.tar.gz
BuildRoot:	%{_tmppath}/%{name}-%{version}-%{release}-root-%(%{__id_u} -n)

%define		gst_majorminor 0.10
%define		gst_req @GST_REQ@

Requires: 	gstreamer >= %{gst_req}
BuildRequires: 	gstreamer-devel >= %{gst_req}

%description
Gnonlin is a plugin for GStreamer (http://gstreamer.freedesktop.org) which
provides support for writing non-linear audio and video editing applications. It
introduces the concept of a timeline.

%prep
%setup -q -n gnonlin-%{version}

%build
%configure

make %{?_smp_mflags}

%install
rm -rf $RPM_BUILD_ROOT

%makeinstall
rm -f $RPM_BUILD_ROOT%{_libdir}/gstreamer-%{gst_majorminor}/*.la

%clean
rm -rf $RPM_BUILD_ROOT

%post

%postun

%files
%defattr(-, root, root, -)
%doc AUTHORS COPYING README
%{_libdir}/gstreamer-%{gst_majorminor}/libgnl*


%changelog
* Thu Jul 14 2005 Edward Hervey <edward at fluendo dot com>
- Removed gnonlin-config*

* Mon Jun 27 2005 Thomas Vander Stichele <thomas at apestaart dot org>
- cleanup of spec

* Mon Mar 21 2005 Edward Hervey <bilboed at bilboed dot com>
- First version of spec
