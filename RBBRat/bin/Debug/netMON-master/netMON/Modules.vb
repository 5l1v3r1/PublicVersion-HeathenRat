Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Net.Sockets
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Windows.Forms.ListView

Module LVIs

    Public Function addToList(Name As String, MAC As String, IP As String, ByRef LV As ListView) As Boolean

        Dim tempLVI As New ListViewItem
        'Item erstellen
        If Name.Length > 0 Then
            tempLVI.Name = Name
            tempLVI.Text = Name
        Else
            Return False
        End If

        If MAC.Length > 0 AndAlso isValidMAC(MAC) Then
            tempLVI.SubItems.Add(MAC)
        Else
            tempLVI.SubItems.Add("")
            'Return False
        End If

        If IP.Length > 0 AndAlso isValidIP(IP) Then
            tempLVI.SubItems.Add(IP)
        Else
            Return False
        End If

        tempLVI.SubItems.Add("nie")

        'Item einfügen
        LV.Items.Add(tempLVI)

        Return True

    End Function

    Public Function editList(Name As String, MAC As String, IP As String, ByRef tempLVI As ListViewItem)
        'Item erstellen
        If Name.Length > 0 Then
            tempLVI.Name = Name
            tempLVI.Text = Name
        Else
            Return False
        End If

        If MAC.Length > 0 AndAlso isValidMAC(MAC.ToUpper) Then
            tempLVI.SubItems(1).Text = (MAC.ToUpper)
        Else
            tempLVI.SubItems(1).Text = ("")
            'Return False
        End If

        If IP.Length > 0 AndAlso isValidIP(IP) Then
            tempLVI.SubItems(2).Text = (IP)
        Else
            Return False
        End If

        Return True
    End Function

    Public Function isValidMAC(MAC As String) As Boolean

        Try

            Dim MAC_MAC As PhysicalAddress = PhysicalAddress.Parse(MAC)

        Catch ex As Exception

            MsgBox(ex.Message.ToString)
            Return False

        End Try

        Return True

    End Function

    Public Function isValidIP(IP As String) As Boolean

        Try

            Dim IP_IP As IPAddress = IPAddress.Parse(IP)

        Catch ex As Exception

            MsgBox(ex.Message.ToString)
            Return False

        End Try

        Return True

    End Function

    Private Function StringToByteArray(ByVal str As String) As Byte()
        Dim enc As System.Text.ASCIIEncoding = New System.Text.ASCIIEncoding()
        Return enc.GetBytes(str)
    End Function

End Module

Module BackgroundJobs

    Public Sub runMonitorOnce(Form As Form, ByVal LVItems As ListViewItemCollection)

        For Each item As ListViewItem In LVItems

            Dim worker As New BackgroundWorker

            worker.WorkerReportsProgress = False
            worker.WorkerSupportsCancellation = False

            AddHandler worker.DoWork, AddressOf pingIP

            Dim e(2) As Object
            e(0) = Form
            e(1) = item
            e(2) = item.SubItems(2).Text

            worker.RunWorkerAsync(e)

        Next







        'Dim worker As New BackgroundWorker

        'worker.WorkerReportsProgress = False
        'worker.WorkerSupportsCancellation = False

        'AddHandler worker.DoWork, AddressOf CheckDevices

        'Dim e(1) As Object
        'e(0) = Form
        'e(1) = LVItems

        'worker.RunWorkerAsync(e)

    End Sub



End Module

Module Networking

    Dim blocker As New Object
    Public Const MAC_ADDR_BYTES As Integer = 6
    Private Const PORT_BROADCAST = 2304

    Public Sub pingIP(sender As Object, e As DoWorkEventArgs)

        Dim Zielform = e.Argument(0)
        Dim LVI As ListViewItem = e.Argument(1)
        Dim IP = e.Argument(2)

        SyncLock blocker
            Debug.WriteLine("Pinge: " + IP)
            'Ip As String, Zielform As Form, LVI As ListViewItem
            If My.Computer.Network.Ping(IP, 200) Then
                'ZielForm.BeginInvoke(Sub() ZielForm.Text = "A33 Vergleich")
                Zielform.BeginInvoke(Sub() LVI.BackColor = Color.LightGreen)
                Zielform.BeginInvoke(Sub() LVI.SubItems(3).Text = DateTime.Now.ToString)
            Else
                Zielform.BeginInvoke(Sub() LVI.BackColor = Color.LightPink)
            End If
        End SyncLock
    End Sub


    Public Function GetMagicPacket(ByVal macAddress As String) As Byte()
        Dim Packet As Byte() = New Byte(5 + 16 * MAC_ADDR_BYTES) {} '101 => 102 Elements
        Dim strNumbers As String() = macAddress.Split(New Char() {":", ",", ";", "-"})
        Dim macBytes As Byte() = New Byte(5) {}
        If strNumbers.Length <> 6 Then
            Throw New Exception("MAC Address incorrect!!!")
        End If
        'Convert Numbers to Bytes and set the first 6 FF Values
        For i As Integer = 0 To 5
            Packet(i) = &HFF
            Dim strNumber As String = strNumbers(i)
            'Strip possible leading 0x statments
            If strNumber.StartsWith("0x") Then
                strNumber = strNumber.Substring(2, 2)
            End If
            macBytes(i) = CByte(Int32.Parse(strNumber, System.Globalization.NumberStyles.HexNumber))
        Next i
        'Write the MAC address 16 times after the 6 FF values
        For j As Integer = 0 To 15
            For i As Integer = 0 To 5
                Packet(6 + j * 6 + i) = macBytes(i)
            Next i
        Next j
        Return Packet
    End Function

    Public Sub WakeUp(ByVal macAddress As String)
        Dim s As Socket = New Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp)
        s.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 1)
        Dim Message As Byte() = GetMagicPacket(macAddress)
        Dim IPEP As New IPEndPoint(IPAddress.Broadcast, PORT_BROADCAST)
        s.SendTo(Message, IPEP)
    End Sub

End Module

Module Serialisation

    Public Sub SerializeListViewData(ByVal filename As String, LV As ListView)

        '  Create a FileStream and get the file to write to.
        Dim FS As FileStream = File.Create(filename)
        '  Create a Binary Formatter for Serialization process
        Dim BinFmtr As New BinaryFormatter
        '  Create an arraylist as temp storage for listview items data
        Dim alSavedLV As New ArrayList

        '  Iterate through the ListView's listitem collection and add
        '  each to the temporary ArrayList
        For item As Integer = 0 To LV.Items.Count - 1
            '  Add next item/subitem to the arraylist
            alSavedLV.Add(LV.Items(item))
        Next

        '  Serialize the complete arraylist to the file
        '  The arraylist contains all the listview data
        BinFmtr.Serialize(FS, alSavedLV)

        '  Close the FileStream
        FS.Close()

    End Sub
    Public Sub DeserializeToListView(ByVal filename As String, ByVal LV As ListView)

        '  Create a FileStream to access the storage file
        Dim FS As FileStream = File.Open(filename, FileMode.Open)
        '  Create a Binary Formatter for Serialization process
        Dim BinFmtr As New BinaryFormatter
        '  Create an arraylist as temp storage for listview items data
        Dim alSavedLV As New ArrayList

        '  Deserialize the data from the file and put it in the arraylist
        alSavedLV = CType(BinFmtr.Deserialize(FS), ArrayList)

        '  Read the arraylist contents into the listview
        Dim lvi As ListViewItem
        For item As Integer = 0 To alSavedLV.Count - 1
            lvi = New ListViewItem
            lvi = CType(alSavedLV(item), ListViewItem)
            LV.Items.Add(lvi)
        Next

        '  Done with the FileStream
        FS.Close()

    End Sub
End Module


