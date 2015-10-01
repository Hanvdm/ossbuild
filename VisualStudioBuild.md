# Requirements #
  * Visual Studio 2008 Professional Edition (or greater)

# Instructions #
  * Open Windows explorer and move to the <OSSBuild Home> directory
  * Read all the instructions in ReadMe.txt
  * Double-click the GStreamer.sln
  * Change the solution configuration to "Release (GPL)" or "Release (LGPL)" as per your needs
  * If the build fails due to errors in dependency order, build again and they should be resolved.
  * To try out your uninstalled build, run "test.bat" in the <OSSBuild Home>/Tools/ directory.
    * From that command window, you can run gst-launch and friends.
    * We recommend you delete your existing GStreamer registry cache in your user home directory (e.g. C:\Users\< Username >\.gstreamer-0.10\registry.i686.bin) if you encounter any errors.
    * If you've built the language bindings and you get errors about missing "pythonXX.dll"s because you don't have Python 2.5, 2.6, or later versions installed on your system, that's expected. Please ignore these messages. If they bother you, go to the <OSSBuild Home>/Build/Windows/Win32/Release/bin/plugins/ directory and delete libgstpython-v2.5dll and libgstpython-v2.6.dll. To prevent these from being built in the future, from within Visual Studio, locate the gstpython plugin projects, and unload them.