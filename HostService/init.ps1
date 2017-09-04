Write-Output 'Starting Web API Host Server'
Start-Service WebAPIHostService
    
Write-Output 'Making HTTP GET call'
Invoke-WebRequest http://localhost:9000/api/welcome -UseBasicParsing | Out-Null

Write-Output 'Flushing log file'
netsh http flush logbuffer | Out-Null

Write-Output 'Tailing log file'
Get-Content -path 'C:\installation\service.log' -Tail 1 -Wait