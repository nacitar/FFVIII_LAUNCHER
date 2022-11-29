# FFVIII_LAUNCHER
Forward the execution of the launcher directly to the game binary without showing the launcher.  Just replace the existing launcher with this.  It requires the dotnet 6 runtime.


Using chocolatey to install packages on windows...

Runtime Dependencies:
`choco install dotnet-6.0-runtime`

Build Dependencies (includes runtime dependencies):
`choco install dotnet-6.0-sdk`

Building:
`dotnet publish --configuration Release`
