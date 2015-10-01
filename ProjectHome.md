OSSBuild ("oh-ess-ess build") provides a build system that is compatible with the autotools and MS Visual Studio build environments. It is mainly to support GStreamer and its plugins for Windows (XP/Vista/7) and Linux environments.

We provide Windows builds of common open source libraries such as libpng, libjpeg, libxml2, glib, etc. They're updated as new stable versions are released and as long as they maintain compatibility with other libraries that depend on them. If you need updated, stable Windows libraries, we encourage you to checkout (as in "svn co") the repository: http://code.google.com/p/ossbuild/source/browse/trunk#trunk/Shared/Build/Windows/Win32/.

Current work is focused on updating to the latest GStreamer releases and providing Java webstart packages. The latest release is available in the downloads section and once the Java packages are ready, a release will be made available for download. Harnessing GStreamer in your Java application in a cross-platform manner will become as easy as adding the line "Sys.initialize()" thanks to the new resource management system. We hope you'll like it once it's available.

You can join us in the #ossbuild IRC chanel at irc.freenode.org

## News ##
  * GStreamer WinBuilds v0.10.7, Beta 04 is out.
  * GStreamer WinBuilds v0.10.6 is out.
<table border='0' cellspacing='2'>
<tr></li></ul>

<td valign='top'>
<h2>GStreamer Support</h2>

We support the following GStreamer modules:<br>
<br>
<table border='0' cellspacing='2'>

<tr valign='top'><td width='20'></td><td><li /></td><td>
GStreamer Core<br>
</td><td width='20'></td><td>
v0.10.28<br>
</td><td width='20'></td><td>
"Same old, same old"<br>
</td></tr>

<tr valign='top'><td /><td><li /></td><td>
GStreamer Base Plugins<br>
</td><td /><td>
v0.10.28<br>
</td><td /><td>
"Those Norwegians"<br>
</td></tr>

<tr valign='top'><td /><td><li /></td><td>
GStreamer Good Plugins<br>
</td><td /><td>
v0.10.21<br>
</td><td /><td>
"Lemons"<br>
</td></tr>

<tr valign='top'><td /><td><li /></td><td>
GStreamer Bad Plugins<br>
</td><td /><td>
v0.10.18<br>
</td><td /><td>
"Diminishing Returns"<br>
</td></tr>

<tr valign='top'><td /><td><li /></td><td>
GStreamer Ugly Plugins<br>
</td><td /><td>
v0.10.14<br>
</td><td /><td>
"Run Rabbit"<br>
</td></tr>

<tr valign='top'><td /><td><li /></td><td>
GStreamer OpenGL Plugins<br>
</td><td /><td>
v0.10.1<br>
</td><td /><td>
"La Fromage De La Belle France"<br>
</td></tr>

<tr valign='top'><td /><td><li /></td><td>
GStreamer Non-Linear Editing Plugins (GNonLin)<br>
</td><td /><td>
v0.10.15<br>
</td><td /><td>
"I missed the snow in Barcelona"<br>
</td></tr>

<tr valign='top'><td /><td><li /></td><td>
GStreamer FFmpeg Plugins<br>
</td><td /><td>
v0.10.10<br>
</td><td /><td>
</td></tr>

<tr><td><br /></td></tr>

<tr valign='top'><td /><td><li /></td><td>
GStreamer .NET (C#) Bindings<br>
</td><td /><td>
v0.9.2<br>
</td><td /><td>
"One more step to completion"<br>
</td></tr>

<tr valign='top'><td /><td><li /></td><td>
GStreamer Python Bindings<br>
</td><td /><td>
v0.10.18<br>
</td><td /><td>
"A pigeon carrying a 500ton block"<br>
</td></tr>

<tr><td><br /></td></tr>

<tr valign='top'><td /><td><li /></td><td>
Farsight2<br>
</td><td /><td>
v0.0.16<br>
</td><td /><td>
</td></tr>

<tr valign='top'><td /><td><li /></td><td>
GStreamer Farsight Plugins<br>
</td><td /><td>
v0.12.11<br>
</td><td /><td>
</td></tr>

</table>
<br />

<h2>Projects using GStreamer WinBuilds</h2>
<ul><li><a href='http://www.ylatuya.es/'>LongoMatch (sports video analysis tool)</a>
</li><li><a href='http://users.design.ucla.edu/~acolubri/processing/gsvideo/home/'>GSVideo (video library for Processing)</a>
</li><li><a href='http://www.moldeo.org/'>Moldeo (framework for creating interactive environments)</a>
</li><li><a href='http://www.amsn-project.net/'>aMSN (MSN Messegner clone)</a>
</li><li><a href='http://liris.cnrs.fr/advene/'>Advene project (digital video annotation)</a>
</li><li><a href='http://www.jokosher.org/'>Jokosher (multi-track audio studio)</a>
</li><li><a href='http://www.icemission.com/home'>ICEMission (multiprotocol VOIP)</a></li></ul>


<h2>Acknowledgements</h2>

We owe special thanks to the following:<br>
<ul><li>The GStreamer team<br>
</li><li>Andoni Morales Alastruey<br>
</li><li>Andrés Colubri<br>
</li><li>David Hoyt<br>
</li><li>Julien Isorce<br>
</li><li>Ole André Vadla Ravnås</li></ul>

<h2>Help Wanted</h2>

We need special help moving the project forward. In particular, we need:<br>
<ul><li>JHBuild experts<br>
</li><li>MSBuild experts<br>
</li><li>Visual Studio 2010 language add-on/plugin/SDK experts</li></ul>

</td>

</tr>
</table>
