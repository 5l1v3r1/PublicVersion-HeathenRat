Imports System.Runtime.InteropServices
Public Class InvDeskLock

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_NOCLOSE As Integer = &H200
            cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            Return cp
        End Get
    End Property
    <DllImport("user32.dll")>
    Private Shared Function GetWindowRect(ByVal hWnd As IntPtr, ByRef lpRect As Rectangle) As Boolean
    End Function
    Private Sub InvDeskLock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ShowInTaskbar = False
        Me.WindowState = FormWindowState.Maximized
        '    var hwnd = New WindowInteropHelper(this).Handle;

        '   Dim k As New Rectangle

        '   GetWindowRect(taskBars, k)


        '     MessageBox.Show(k.Y.ToString)


        '  Win32APILib.AllFunctions.PlayWithWindows.SetWindowPos(l.Handle, Win32APILib.AllFunctions.PlayWithWindows.HWND_TOPMOST, k.X, k.Y, k.Width, k.Height, Win32APILib.AllFunctions.PlayWithWindows.SWP_NOMOVE Or Win32APILib.AllFunctions.PlayWithWindows.SWP_NOSIZE)



        ' Dim l As New NEEDED 'FORM

        ' l.Size = k.Size
        ' l.Location = k.Location

        Win32APILib.AllFunctions.LockAWindow(Me.Handle, False)


        Win32APILib.AllFunctions.PlayWithWindows.SetWindowPos(Me.Handle, Win32APILib.AllFunctions.PlayWithWindows.HWND_TOPMOST, 0, 0, 0, 0, Win32APILib.AllFunctions.PlayWithWindows.SWP_NOMOVE Or Win32APILib.AllFunctions.PlayWithWindows.SWP_NOSIZE)



        Dim objCurrentModule As ProcessModule = Process.GetCurrentProcess().MainModule
        Dim objKeyboardProcess As New KeyHook.LowLevelKeyboardProc(AddressOf KeyHook.captureKey)



        ' Dim qsd = KeyHook.SetWindowsHookEx
        Dim ptrHook = KeyHook.SetWindowsHookEx(13, objKeyboardProcess, KeyHook.GetModuleHandle(objCurrentModule.ModuleName), 0)
        InitializeComponent()

    End Sub



End Class