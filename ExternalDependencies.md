# Introduction #

GStreamer depends on many external libraries and since maintaining a MSVC build for all of them is overkill and goes out of OSSBuild's scope, all of them are built with the GCC toolchain using msys/mingw, in a unix-like way. The interoperability of these libraries with gstreamer's, built with MSVC, is guaranteed by using the same C runtime: msvcrt.dll (http://en.wikipedia.org/wiki/Microsoft_Windows_library_files#Msvcrt.dll).

# Build system structure #

## Source tarballs and patches ##
The source tarballs are stored in the build system instead of using a link to the original source url, to aid in working offline and to maintain all source for releases in-tree. The tarballs are stored in the $OSSBUILD/Libraries/Packages/ folder: http://code.google.com/p/ossbuild/source/browse/trunk#trunk/Libraries/Packages .

Some libraries require patches because they don't build cleanly on a platform or because they need special modifications for a speceific platform. Patches are stored in the $OSSBUILD/Libraries/Patches/ folder, in a subfolder with the same name as the library: http://code.google.com/p/ossbuild/source/browse/trunk#trunk/Libraries/Patches .

## Build scripts ##
All external dependencies are built using a platform-specific shell script. These scripts are located in the $OSSBUILD/Libraries/ folder: http://code.google.com/p/ossbuild/source/browse/trunk#trunk/Libraries .

## Configuration files and helper scripts ##
The build script uses several helper scripts, which can be found in the Shared/Scripts/: folder: http://code.google.com/p/ossbuild/source/browse/trunk#trunk/Shared/Scripts .

Each package is defined in the version.sh file: http://code.google.com/p/ossbuild/source/browse/trunk/Shared/Scripts/Version.sh . For each package, two variables are defined:
  * PKG\_VER\_NAME: The version to be build, where NAME is the name of the library.
  * PKG\_DIR\_NAME: The name of the output folder. This name must match the name of the package's extraction folder, which should resemble "name-$PKG\_VER\_NAME".

## Output ##
  * Source: Source code is extracted to the folder $OSSBUILD/Libraries/Sources/.
  * Build folder: Packages are built in the folder $OSSBUILD/Build/$OS/$ARCH/Release/obj/, where $OS is the operating system (e.g.: Windows) and $ARCH is the architecture (e.g.: Win32).
  * Build output: Libraries are built using the the prefix $OSSBUILD/Build/$OS/$ARCH/Release/.


## Dependecies property sheet ##
Each external dependency has a Visual C++ properties sheet. Each includes:
  * Other external dependencies (e.g.: Gtk depends on Cairo, Pango, and ATK and must reference their property sheet).
  * Include directories needed by to the compiler tool to find the headers.
  * Imported libraries needed by the linker tool to link against it

## Tracking files ##
Version information and the location where you can find the packages used is listed in a README.txt in the $OSSBUILD/Libraries/ folder: http://code.google.com/p/ossbuild/source/browse/trunk/Libraries/Packages/ReadMe.txt .


# Integrating external dependencies into OSSBuild #

In this section, we'll explain step-by-step how to integrate an external dependency by the use of a practical and straight-forward example.

