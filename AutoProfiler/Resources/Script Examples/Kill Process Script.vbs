' This script will show you how to close an application when a certain profile is being used.


'////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


' This is called when a profile is activated

Sub LoadProfile
 

   ' In this script we want to close 'uTorrent' when the profile is activated.
   ' We are using 'uTorrent.exe' as an example in this script. Simply replace 'uTorrent.exe' with the process you would like to use.
    Call KillProcess("uTorrent.exe")

End Sub

'////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

'  This Sub will exit any process you desire.

Sub KillProcess(ByVal ProcessName)
Dim oShell : Set oShell = CreateObject("WScript.Shell")
Dim objWMIService, WMIQuery


' Check if Process is running. If it is the then close it.
If IsProcessRunning(ProcessName) Then

    Set objWMIService = GetObject("winmgmts:{impersonationLevel=impersonate}!\\.\root\cimv2")
    
	Set colProcessList = objWMIService.ExecQuery("Select * from Win32_Process where name like '" & ProcessName & "'")

     For Each objProcess in colProcessList
       objProcess.Terminate()
     Next
     
End If

End Sub

'////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

' This function will allow you to check if a process is currently running on your system. 

Function IsProcessRunning(byval ProcessName)

	Dim objWMIService, WMIQuery

	WMIQuery = "Select * from Win32_Process where name like '" & ProcessName & "'"
	
	Set objWMIService = GetObject("winmgmts:{impersonationLevel=impersonate}!\\.\root\cimv2") 


	If objWMIService.ExecQuery(WMIQuery).Count > 0 then
		isProcessRunning = true
	Else
		isProcessRunning = false
	End If

End Function