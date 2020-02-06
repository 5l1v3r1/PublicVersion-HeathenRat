Public Class fMAIN
    Private Sub tsbHinzufuegen_Click(sender As Object, e As EventArgs) Handles tsbHinzufuegen.Click
        If lvNetMON.SelectedItems.Count <> 1 Then
            Try
                addToList(tstbGeraet.Text, tstbMAC.Text, tstbIP.Text, lvNetMON)

                ' Sort the items in the list in ascending order.
                lvNetMON.Sorting = SortOrder.Ascending
                lvNetMON.Sort()

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        Else
            Try
                editList(tstbGeraet.Text, tstbMAC.Text, tstbIP.Text, lvNetMON.SelectedItems(0))
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End If

    End Sub

    Private Sub GerätEntfernenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerätEntfernenToolStripMenuItem.Click
        Try
            Dim selIt = lvNetMON.SelectedItems

            For Each it In selIt
                lvNetMON.Items.Remove(it)
            Next

        Catch ex As Exception

            MsgBox(ex.Message.ToArray)

        End Try
    End Sub

    Private Sub StartenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartenToolStripMenuItem.Click

        tspbMonitoring.Style = ProgressBarStyle.Marquee
        tspbMonitoring.MarqueeAnimationSpeed = 100

        Me.Text = "netMON | Monitoring läuft"

        Timer1.Interval = My.Settings.Interval
        Timer1.Enabled = True
    End Sub

    Private Sub StoppenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StoppenToolStripMenuItem.Click
        Timer1.Enabled = False
        Me.Text = "netMON"
        For Each item As ListViewItem In lvNetMON.Items
            item.BackColor = Color.White
        Next
        tspbMonitoring.MarqueeAnimationSpeed = 0
        tspbMonitoring.Style = ProgressBarStyle.Blocks

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BackgroundJobs.runMonitorOnce(Me, lvNetMON.Items)
    End Sub

    Private Sub ListeExportierenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeExportierenToolStripMenuItem.Click
        Dim sfdExport As New SaveFileDialog

        sfdExport.Filter = "netMON-Datei (*.nmon)|*.nmon|Alle Dateien (*.*)|*.*"
        sfdExport.FilterIndex = 1
        sfdExport.RestoreDirectory = True

        If sfdExport.ShowDialog = DialogResult.OK Then
            SerializeListViewData(sfdExport.FileName, lvNetMON)
        End If
    End Sub

    Private Sub ListeImportienToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeImportienToolStripMenuItem.Click
        lvNetMON.Items.Clear()

        Dim ofdImport As New OpenFileDialog

        ofdImport.Filter = "netMON-Datei (*.nmon)|*.nmon|Alle Dateien (*.*)|*.*"
        ofdImport.FilterIndex = 1
        ofdImport.RestoreDirectory = True

        If ofdImport.ShowDialog = DialogResult.OK Then
            DeserializeToListView(ofdImport.FileName, lvNetMON)
        End If
    End Sub

    Private Sub ÜbernehmenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÜbernehmenToolStripMenuItem.Click
        Try
            My.Settings.Interval = CInt(ToolStripTextBox1.Text)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub MonitoringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonitoringToolStripMenuItem.Click
        ToolStripTextBox1.Text = My.Settings.Interval.ToString
    End Sub

    Private Sub GerätWeckenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerätWeckenToolStripMenuItem.Click
        Try
            Dim setIt = lvNetMON.SelectedItems

            For Each item As ListViewItem In setIt

                If item.SubItems(1).Text.Length > 0 Then
                    WakeUp(item.SubItems(1).Text)
                Else
                    MsgBox(item.Text + " keine MAC-Adresse angegeben!")
                End If

            Next

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub lvNetMON_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvNetMON.SelectedIndexChanged
        Try
            If lvNetMON.SelectedItems.Count = 1 Then
                tsbHinzufuegen.Text = "Gerät ändern"
                tstbGeraet.Text = lvNetMON.SelectedItems(0).Text
                tstbIP.Text = lvNetMON.SelectedItems(0).SubItems(2).Text
                tstbMAC.Text = lvNetMON.SelectedItems(0).SubItems(1).Text
            Else
                tsbHinzufuegen.Text = "Gerät hinzufügen"
                tstbGeraet.Clear()
                tstbIP.Clear()
                tstbMAC.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try


    End Sub

    Private Sub fMAIN_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Dim args() As String = Environment.GetCommandLineArgs()
        'If args IsNot Nothing AndAlso args.Count > 0 Then

        '    For Each arg In args
        '        MsgBox(arg)
        '    Next

        'End If
    End Sub
End Class
