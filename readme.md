touchdect 1.0
Written by jgeau in c# requires .net 3.0 or higher

touchdect.exe is just a simple command line tool that does nothing more than return the total number of touchpoints availible to windows.

Usage

Example: in powershell 

$touchpoints = .\touchdect.exe

if ($touchpoints -eq "0")
    {
    Write-Host "You do not have a touch screen"
    }

If ($touchpoints -gt "0")
    {
    Write-Host "your system has $touchpoints touchpoints availible."
    }

source code availible upon request 

Basic Design: 
this uses GetSystemMetric and SM_MAXIMUMTOUCHES to get the number of touchpoints availible to the system
https://msdn.microsoft.com/en-us/library/ms724385(VS.85).aspx



