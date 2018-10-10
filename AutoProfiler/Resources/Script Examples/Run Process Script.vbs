' This script will show you how to open an application when a certain profile is no longer being used

'////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


' This is called when a profile is no longer activated.

Sub UnloadProfile
     
    ' Now that the profile is no longer activated we want 'uTorrent' to open back up. We've also made it so it will start minimized to be out of the way.
     Call RunEXE("C:\Program Files (x86)\uTorrent\uTorrent.exe /MINIMIZED")

End Sub

'////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

' You can use this Sub to open executable files.

Sub RunEXE(ByVal FilePath)
Dim oShell : Set oShell = CreateObject("WScript.Shell")

     oShell.Exec(FilePath)

End Sub

