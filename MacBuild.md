Compilation of GStreamer for the Mac platform is in its earlier stages. [MacPorts](http://www.macports.org/) is currently used as the mechanism to resolve dependencies, apply patches and build the binaries. This is followed by some post-build steps to remove absolute paths in the resulting _.dylib_ and _.so_ files (which MacPorts sets by default to /opt/local/lib).

## Target platform: 32 bits ##

  * Install macports for your development platform. Completely remove older install if present:
```
> sudo rm -rf \
    /opt/local \
    /Applications/DarwinPorts \
    /Applications/MacPorts \
    /Library/LaunchDaemons/org.macports.* \
    /Library/Receipts/DarwinPorts*.pkg \
    /Library/Receipts/MacPorts*.pkg \
    /Library/StartupItems/DarwinPortsStartup \
    /Library/Tcl/darwinports1.0 \
    /Library/Tcl/macports1.0 \
    ~/.macports
```
  * Edit _/opt/local/share/macports/Tcl/port1.0/portconfigure.tcl_ and replace the line:
```
default configure.ldflags   {-L${prefix}/lib}
```
> with:
```
default configure.ldflags   {"-L${prefix}/lib -Xlinker -headerpad_max_install_names"}
```
this will allow to change later the absolute dependency paths embedded in the _.dylib_ and _.so_ files by relative paths.
  * Use the portfiles included in the [svn](http://code.google.com/p/ossbuild/source/browse/trunk#trunk/Main/GStreamer/MacOSX/MacPorts/repository) to create a local repository. Add the location of the local repository to the /opt/local/macports/source.conf file, as explained [here](http://guide.macports.org/#development.local-repositories).
  * Add the line:
```
build_arch  i386
```
> to _/opt/local/etc/macports/macports.conf_.
  * Install the gstreamer, gst-plugins-base, gst-plugins-good, gst-plugins-bad and gst-plugins-ugly packages:
```
> sudo port install gstreamer
> sudo port install gst-plugins-base +no_x11 +no_gnome_vfs
> sudo port install gst-plugins-good
> sudo port install gst-plugins-bad +no_x11 +dc1394
> sudo port install gst-plugins-ugly
```
  * Installation of gst-ffmpeg:
```
> sudo port install gst-ffmpeg
```
> will fail during the build stage, at least for version 0.10.10. Inspection of the log file will show this error:
```
libavcodec/cabac.h: In function ‘get_cabac_noinline’:
libavcodec/cabac.h:527: error: PIC register ‘%ebx’ clobbered in ‘asm’
libavcodec/cabac.h: In function ‘decode_cabac_mb_intra4x4_pred_mode’:
libavcodec/cabac.h:527: error: PIC register ‘%ebx’ clobbered in ‘asm’
libavcodec/cabac.h:527: error: PIC register ‘%ebx’ clobbered in ‘asm’
libavcodec/cabac.h:527: error: PIC register ‘%ebx’ clobbered in ‘asm’
libavcodec/cabac.h:527: error: PIC register ‘%ebx’ clobbered in ‘asm’
libavcodec/cabac.h: In function ‘decode_cabac_mb_ref’:
libavcodec/cabac.h:527: error: PIC register ‘%ebx’ clobbered in ‘asm’
libavcodec/cabac.h: In function ‘decode_cabac_mb_mvd’:
libavcodec/cabac.h:527: error: PIC register ‘%ebx’ clobbered in ‘asm’
libavcodec/cabac.h:527: error: PIC register ‘%ebx’ clobbered in ‘asm’
libavcodec/cabac.h:641: error: PIC register ‘%ebx’ clobbered in ‘asm’
```
> Change into the _<local repository>/gnome/gst-ffmpeg/work/gst-ffmpeg-0.10.10_ folder.
    1. Edit _gst-libs/ext/ffmpeg/config.h_ and make sure that the macro HAVE\_EBX\_AVAILABLE is defined as zero:
```
#define HAVE_EBX_AVAILABLE 0
```
    1. Add the following macro definition:
```
#define HAVE_MMX 0
```
> > to _gst-libs/ext/ffmpeg/libswscale/rgb2rgb\_template.c_.

> These workarounds were found in [this](https://trac.macports.org/ticket/24636) bug report.
  * Still in _<local repository>/gnome/gst-ffmpeg/work/gst-ffmpeg-0.10.10_ run:
```
> sudo make
```
> followed by:
```
> sudo make install
```
> to manually complete the compilation and installation of gst-ffmpeg.

## Target platform: 64 bits ##

The steps to compile for a 64 bits platform are almost identical, with a few exceptions:
  * Specify 64 bits architecture in _/opt/local/etc/macports/macports.conf_:
```
build_arch x86_64
```
> although if you are compiling on a 64 bits platform, the target is assumed to be 64 bits by default.
  * The compilation of gst-ffmpeg completes without error, so no there is no need to apply the workaround described before.
  * One thing to note is that the osxvideosrc plugin is missing from the 64 bits builds, because it uses the older 32-bit Carbon QuickTime API, which has been deprecated in 64-bit mode. The plugin needs to be rewritten for the newer Cocoa QTKit API (which will work in 32-bit and 64-bit modes).

### Compiling on a different platform ###

The steps above assume that you are compiling GStreamer on the same platform as the target. But if you are compiling in Snow Leopard (10.6) with the intention to generate binaries for Leopard (10.5), then you need to do a few additional things right after installing MacPorts and before installing any ports:
  * In _/opt/local/share/macports/Tcl/port1.0/portconfigure.tcl_ have two more linker flags added to the defaults:
```
default configure.ldflags   {"-L${prefix}/lib -Xlinker -headerpad_max_install_names -mmacosx-version-min=10.5 -no_compact_linkedit"}
```
> (Based on [this](http://lists.apple.com/archives/xcode-users/2009/Oct/msg00514.html) discussion).
  * Add the following line:
```
macosx_deployment_target 10.5
```
> to _/opt/local/etc/macports/macports.conf_. For more details, see [here](http://lists.macosforge.org/pipermail/macports-users/2010-September/021861.html) and [here](http://lists.macosforge.org/pipermail/macports-users/2010-October/022126.html).

## Additional steps to create GStreamer binaries for bundling with 3rd-party applications ##

  * You only need _/opt/local/lib_, so copy it to some other location.
  * Remove _.la_, _.a_ files.
  * Remove all subfolders, with the exception of _/lib/gstreamer-0.10_ (containing the plugins).
  * Any other file that is not _.dylib_ in _/lib_ or _.so_ in _lib/gstreamer-0.10_ can be removed as well.
  * Replace absolute paths with relative paths using the _replacepath.py_ tool.
    1. For base libs:
```
> ./replacepath.py --old /opt/local/lib/ --new @loader_path/ --dir <lib folder>
```
    1. For plugins (note that here we use the relative path _@loader\_path/../_ instead of _@loader\_path/_):
```
> ./replacepath.py --old /opt/local/lib/ --new @loader_path/../ --dir <lib folder>/gstreamer-0.10
```
  * If also needed, eliminate symbolic links using the _removesymlinks.py_ tool:
```
> ./removesymlinks.py --dir <lib folder>
```
The _replacepath.py_ and _removesymlinks.py_ tools are located in the ossbuild source trunk [here](http://code.google.com/p/ossbuild/source/browse/trunk#trunk/Main/GStreamer/MacOSX/MacPorts).