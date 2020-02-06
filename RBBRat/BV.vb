
Public Class BV
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim k As New Random
        Dim primaryMonitorSize As Size = SystemInformation.PrimaryMonitorSize
        Dim op As Integer = k.Next(0, primaryMonitorSize.Width)
        Dim j As Integer = k.Next(0, primaryMonitorSize.Height)

        ' Dim newWindow As IntPtr = CreateWindowEx(WindowStylesEx.ToolWindow, "Button", "Button1", WindowStyles.Visible, op, j, 150, 150, IntPtr.Zero, IntPtr.Zero, Process.GetCurrentProcess().Handle, IntPtr.Zero)


        Me.WindowState = FormWindowState.Maximized

        Win32APILib.AllFunctions.LockAWindow(Me.Handle, False)

        Win32APILib.AllFunctions.PlayWithWindows.SetWindowPos(Me.Handle, Win32APILib.AllFunctions.PlayWithWindows.HWND_TOPMOST, 0, 0, 0, 0, Win32APILib.AllFunctions.PlayWithWindows.SWP_NOMOVE Or Win32APILib.AllFunctions.PlayWithWindows.SWP_NOSIZE)


        Timer1.Start()

        '  Timer2.Start()

    End Sub

    Dim k As New Random
    Dim primaryMonitorSize As Size = SystemInformation.PrimaryMonitorSize
    Dim op As Integer = k.Next(0, primaryMonitorSize.Width)
    Dim j As Integer = k.Next(0, primaryMonitorSize.Height)

    Dim listx As New List(Of Integer)
    Dim listy As New List(Of Integer)
    Dim counter As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            BackgroundWorker1.RunWorkerAsync()

        Catch ex As Exception

        End Try

    End Sub
    Public Sub Keep(ByVal x As Integer, ByVal y As Integer, ByVal bin As Integer)
        If (bin / 2) = True Then


            Dim bmp As Bitmap = My.Resources._0NB
            Dim hdc As Int32 = Win32APILib.AllFunctions.DrawDesktopWithPersistence.GetDC(0)
            Dim g As Graphics = Graphics.FromHdc(New IntPtr(hdc))
            g.DrawImage(bmp, x, y)

            Win32APILib.AllFunctions.DrawDesktopWithPersistence.ReleaseDC(0, hdc)
            g.Dispose()
            bmp.Dispose()
        Else


            Dim bmp As Bitmap = My.Resources._1NB
            Dim hdc As Int32 = Win32APILib.AllFunctions.DrawDesktopWithPersistence.GetDC(0)
            Dim g As Graphics = Graphics.FromHdc(New IntPtr(hdc))
            g.DrawImage(bmp, x, y)
            Win32APILib.AllFunctions.DrawDesktopWithPersistence.ReleaseDC(0, hdc)
            g.Dispose()
            bmp.Dispose()
        End If
    End Sub



    Private Sub BackgroundWorker1_DoWork_1(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        If (counter / 2) = 0 Then
            Dim op2 As Integer = k.Next(0, primaryMonitorSize.Width)
            Dim j2 As Integer = k.Next(0, primaryMonitorSize.Height)

            Dim kj As New Random
            Dim op = kj.Next(0, 1)

            Dim bmp As Bitmap = My.Resources._0NB
            Dim hdc As Int32 = Win32APILib.AllFunctions.DrawDesktopWithPersistence.GetDC(0)
            Dim g As Graphics = Graphics.FromHdc(New IntPtr(hdc))
            g.DrawImage(bmp, op2, j2)
            Win32APILib.AllFunctions.DrawDesktopWithPersistence.ReleaseDC(0, hdc)
            g.Dispose()
            bmp.Dispose()

            listx.Add(op2)

            listy.Add(j2)


        ElseIf Not (counter / 2) = 0 Then
            Dim op2 As Integer = k.Next(0, primaryMonitorSize.Width)
            Dim j2 As Integer = k.Next(0, primaryMonitorSize.Height)

            Dim kj As New Random
            Dim op = kj.Next(0, 1)

            Dim bmp As Bitmap = My.Resources._0NB
            Dim hdc As Int32 = Win32APILib.AllFunctions.DrawDesktopWithPersistence.GetDC(0)
            Dim g As Graphics = Graphics.FromHdc(New IntPtr(hdc))
            g.DrawImage(bmp, op2, j2)
            Win32APILib.AllFunctions.DrawDesktopWithPersistence.ReleaseDC(0, hdc)
            g.Dispose()
            bmp.Dispose()

            listx.Add(op2)

            listy.Add(j2)
        End If

        counter += 1


        ' Task.Run(Sub() Add())


        For i = 0 To counter - 1
            Task.Run(Sub() Keep(listx(i), listy(i), counter))
        Next


    End Sub
    Public Sub ToLeft(ByVal t As Control)
        If t.Left < Me.Width Then
            t.Left = t.Left + 10
        Else
            t.Left = 0
        End If
    End Sub



    Public Sub ToRight(ByVal t As Control)
        If t.Right > Me.Width Then
            t.Left = t.Right + 10
        Else
            t.Left = t.RightToLeft - t.Left
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        '   ToLeft(Label1)






        Try
            BackgroundWorker2.RunWorkerAsync()

        Catch ex As Exception

        End Try

    End Sub



    Private Sub Timer3_Tick_1(sender As Object, e As EventArgs) Handles Timer3.Tick

    End Sub



    Dim listx2 As New List(Of Integer)
    Dim listy2 As New List(Of Integer)
    Dim counter2 As Integer = 0
    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        If (counter2 / 2) = 0 Then
            Dim op2 As Integer = k.Next(0, primaryMonitorSize.Width)
            Dim j2 As Integer = k.Next(0, primaryMonitorSize.Height)

            Dim kj As New Random
            Dim op = kj.Next(0, 1)

            Dim bmp As Bitmap = My.Resources._0NB
            Dim hdc As Int32 = Win32APILib.AllFunctions.DrawDesktopWithPersistence.GetDC(0)
            Dim g As Graphics = Graphics.FromHdc(New IntPtr(hdc))
            g.DrawImage(bmp, op2, j2)
            Win32APILib.AllFunctions.DrawDesktopWithPersistence.ReleaseDC(0, hdc)
            g.Dispose()
            bmp.Dispose()

            listx2.Add(op2)

            listy2.Add(j2)


        ElseIf Not (counter2 / 2) = 0 Then
            Dim op2 As Integer = k.Next(0, primaryMonitorSize.Width)
            Dim j2 As Integer = k.Next(0, primaryMonitorSize.Height)

            Dim kj As New Random
            Dim op = kj.Next(0, 1)

            Dim bmp As Bitmap = My.Resources._0NB
            Dim hdc As Int32 = Win32APILib.AllFunctions.DrawDesktopWithPersistence.GetDC(0)
            Dim g As Graphics = Graphics.FromHdc(New IntPtr(hdc))
            g.DrawImage(bmp, op2, j2)
            Win32APILib.AllFunctions.DrawDesktopWithPersistence.ReleaseDC(0, hdc)
            g.Dispose()
            bmp.Dispose()

            listx2.Add(op2)

            listy2.Add(j2)
        End If

        counter2 += 1


        ' Task.Run(Sub() Add())


        For i = 0 To counter - 1
            Task.Run(Sub() Keep(listx2(i), listy2(i), counter2))
        Next
    End Sub
End Class
