
@echo off
title LED
:: Open one cmd window as administrator
%1 start "" mshta vbscript:CreateObject("Shell.Application").ShellExecute("cmd.exe","/c ""%~s0"" ::","","runas",1)(window.close)&&exit

:: Get path
cd /d "%~dp0" >> .\..\log\LED.log

:: Call file
set YYYY=%date:~6,4%
set   MM=%date:~3,2%
set   DD=%date:~0,2%
set  WEK=%date:~11,3%
set YYYY-MM-DD=%YYYY%-%MM%-%DD%
set Tlog=%YYYY-MM-DD% [%WEK%] %time%00:
@echo on
echo %Tlog%>>.\..\log\LED.log

@echo on

setlocal enabledelayedexpansion 
for /f "tokens=2" %%i in ('tasklist^|findstr /i python2.exe')
do ( 
    for /f "delims=|" %%j in ('wmic process where "ProcessId=%%i" get CommandLine^|findstr /i aaa')
    do ( 
        echo "terminating:%%j" taskkill /f /pid %%i
    )
)
pause