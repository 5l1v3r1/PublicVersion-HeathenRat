Imports System.Runtime.InteropServices

Public Class KeyHook
    '''
    ''
    ' SOLUTION ADAPTED FROM : http://geekswithblogs.net/aghausman/archive/2009/04/26/disable-special-keys-in-win-app-c.aspx written in c#

    'code reallt difficult , I don't understand all , this is why I needed to search after it !
    '
    ''' 
    '
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Shared Function SetWindowsHookEx(ByVal id As Integer, ByVal callback As LowLevelKeyboardProc, ByVal hMod As IntPtr, ByVal dwThreadId As UInteger) As IntPtr

    End Function
    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Shared Function GetModuleHandle(ByVal name As String) As IntPtr

    End Function


    <StructLayout(LayoutKind.Sequential)>
    Private Structure KBDLLHOOKSTRUCT
        Public key As Keys
        Public scanCode As Integer
        Public flags As Integer
        Public time As Integer
        Public extra As IntPtr
    End Structure

    Public Delegate Function LowLevelKeyboardProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Shared Function UnhookWindowsHookEx(ByVal hook As IntPtr) As Boolean

    End Function
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function CallNextHookEx(ByVal hook As IntPtr, ByVal nCode As Integer, ByVal wp As IntPtr, ByVal lp As IntPtr) As IntPtr

    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function GetAsyncKeyState(ByVal key As Keys) As Short

    End Function
    Public Shared ptrHook As IntPtr
    Private objKeyboardProcess As LowLevelKeyboardProc
    Public Shared Function captureKey(ByVal nCode As Integer, ByVal wp As IntPtr, ByVal lp As IntPtr) As IntPtr
        If nCode >= 0 Then
            Dim objKeyInfo As KBDLLHOOKSTRUCT = CType(Marshal.PtrToStructure(lp, GetType(KBDLLHOOKSTRUCT)), KBDLLHOOKSTRUCT)

            If objKeyInfo.key = Keys.RWin OrElse objKeyInfo.key = Keys.LWin OrElse Keys.Control Then
                Return CType(1, IntPtr)
            End If
        End If

        Return CallNextHookEx(ptrHook, nCode, wp, lp)
    End Function
End Class
