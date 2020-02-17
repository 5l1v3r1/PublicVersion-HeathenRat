Imports System.Runtime.InteropServices

Public Class NativeAPI
    Public Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Integer

    Public Const SWP_HIDEWINDOW = &H80

    Const SWP_SHOWWINDOW = &H40




    Public Shared Function HideOrShowTaskBar(ByVal status As Boolean)
        Dim taskBar As Integer
        taskBar = FindWindow("Shell_traywnd", "")

        If status = True Then
            Return SetWindowPos(taskBar, 0&, 0&, 0&, 0&, 0&, SWP_SHOWWINDOW)
        Else
            Return SetWindowPos(taskBar, 0&, 0&, 0&, 0&, 0&, SWP_HIDEWINDOW)
        End If

    End Function


    Public Const SWP_NOSIZE As Int32 = &H1
    Public Const SWP_NOMOVE As Int32 = &H2

    <DllImport("user32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function SetWindowPos(
ByVal hWnd As IntPtr,
ByVal hWndInsertAfter As IntPtr,
ByVal X As Int32,
ByVal Y As Int32,
ByVal cx As Int32,
ByVal cy As Int32,
ByVal uFlags As Int32) _
As Boolean
    End Function


    Public Const HWND_BOTTOM = 1


    Public Const HWND_NOTOPMOST = -2


    Public Const HWND_TOP = 0

    Public Const HWND_TOPMOST = -1
End Class
