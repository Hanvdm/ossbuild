# Introduction #

This document describes the official OSSBuild test procedures for ensuring high quality, stable releases.


# Functional Tests #
## Automatic plugins selection ##
The purpose of this test suite is to check that the plugins' rank has been configured properly and the correct plugins will be selected automatically by GStreamer.
### Source plugins ###
  * autovideosrc should select dshowvideosrc.
  * autoaudiosrc should select directsoundsrc.

### Sink plugins ###
  * autovideosink should select directdrawsink (althoug dshowvideosink is supposed to have netter performance than directdrawsink it's still missing prerolling)
  * autoaudiosink should select direcsoundsink (waveformsink has shown many issues depending on the installed driver)

### DirectShow decoders ###
  * check that these plugins have the lowest rank (GST\_RANK\_MINIMAL), and will never be selected automatically by playbin or decodebin. These plugins have shown to have many issues and ffmpeg's one should be used first.


TBD