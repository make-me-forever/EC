:: Open one cmd window as administrator
%1 start "" mshta vbscript:CreateObject("Shell.Application").ShellExecute("cmd.exe","/c ""%~s0"" ::","","runas",1)(window.close)&&exit
cd /d "%~dp0"

set desk=%USERPROFILE%

:: Get path

:: Call file
.\cmd.bat