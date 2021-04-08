del   "%ALLUSERSPROFILE%\Application Data\licensecb\*.*" /q
del   "%USERPROFILE%\Local Settings\Application Data\licensecb\*.*" /q
reg delete HKEY_CURRENT_USER\Software\licensecb /f
start CrazyBump.exe