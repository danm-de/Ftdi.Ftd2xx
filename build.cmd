@echo off
cls

set ROOT=%~dp0
set FAKE=%ROOT%\fake.cmd
set BUILD_FSX=%ROOT\build.fsx

%FAKE% run %BUILD_FSX% %*
