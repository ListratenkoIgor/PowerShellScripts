timeout 40;
Get-Process -name "taskhost";
TASKKILL /im "taskhost.exe" /f;
Get-Process -name "taskhostw";
TASKKILL /im "taskhostw.exe" /f;
Remove-Item C:\ProgramData\RealtekHD\*.* -Force

Remove-ItemProperty -Path HKLM:SOFTWARE\Microsoft\Windows\CurrentVersion\Run -Name "realtek hd audio"



Get-Process -name "audiodg";
TASKKILL /im "audiodg.exe" /f;
Get-Process -name "microsofthost";
TASKKILL /im "microsofthost.exe" /f;
Remove-Item C:\ProgramData\WindowsTask\*.* -Force


<# clear register from miner autorun
Remove-ItemProperty -Path HKLM:SOFTWARE\Microsoft\Windows\CurrentVersion\Run -Name "MinerName" ### usually same as process name	
#>