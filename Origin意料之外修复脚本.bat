@echo off
echo　　　　　　╔══════════════════════════╗
echo　　　　　　║　　　　　　　　　　　　　　　　　　　　　　　　　　║
echo　　　　　　║　　　 请确认Origin已关闭,按下任意键开始修复　　　　║
echo　　　　　　║　　　　　　　　　　　　　　　　　　　　　　　　　　║
echo　　　　　　╚══════════════════════════╝
pause
ipconfig /flushdns
del /f /s /q "%appdata%\Origin\*.*" 
del /f /s /q "%userprofile%\AppData\Local\Origin\Origin\*.*" 
cls
echo　　　　　　╔══════════════════╗
echo　　　　　　║　　　　　　　　　　　　　　　　　　║
echo　　　　　　║　　　 修复完成，请运行Origin　　 　║
echo　　　　　　║　　　　　　　　　　　　　　　　　　║
echo　　　　　　╚══════════════════╝
echo. & pause