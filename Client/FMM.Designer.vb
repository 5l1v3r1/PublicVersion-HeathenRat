﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMM
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FMM))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncryptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncryptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecryptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadThisFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UploadAFileOnComputerVictimToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.OpenFileDial1 = New System.Windows.Forms.OpenFileDialog()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.ForeColor = System.Drawing.Color.Lime
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 45)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(983, 312)
        Me.ListView1.TabIndex = 8
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 423
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoToolStripMenuItem, Me.BackToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.EncryptionToolStripMenuItem, Me.DownloadThisFileToolStripMenuItem, Me.UploadAFileOnComputerVictimToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(249, 158)
        '
        'GoToolStripMenuItem
        '
        Me.GoToolStripMenuItem.BackColor = System.Drawing.Color.DarkViolet
        Me.GoToolStripMenuItem.Image = Global.Client.My.Resources.Resources.icons8_nextazd
        Me.GoToolStripMenuItem.Name = "GoToolStripMenuItem"
        Me.GoToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.GoToolStripMenuItem.Text = "Go"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.BackColor = System.Drawing.Color.DarkViolet
        Me.BackToolStripMenuItem.Image = Global.Client.My.Resources.Resources.icons8_previousqdqs
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.BackToolStripMenuItem.Text = "Back"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.BackColor = System.Drawing.Color.DarkViolet
        Me.DeleteToolStripMenuItem.Image = Global.Client.My.Resources.Resources.icons8_delete_biqsdqsn
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'EncryptionToolStripMenuItem
        '
        Me.EncryptionToolStripMenuItem.BackColor = System.Drawing.Color.DarkViolet
        Me.EncryptionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EncryptToolStripMenuItem, Me.DecryptToolStripMenuItem})
        Me.EncryptionToolStripMenuItem.Image = Global.Client.My.Resources.Resources.iconsqsdqs8_skull1
        Me.EncryptionToolStripMenuItem.Name = "EncryptionToolStripMenuItem"
        Me.EncryptionToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.EncryptionToolStripMenuItem.Text = "Encryption XXTea"
        '
        'EncryptToolStripMenuItem
        '
        Me.EncryptToolStripMenuItem.BackColor = System.Drawing.Color.DarkViolet
        Me.EncryptToolStripMenuItem.Image = Global.Client.My.Resources.Resources.icons8_lockqsdqsd_32
        Me.EncryptToolStripMenuItem.Name = "EncryptToolStripMenuItem"
        Me.EncryptToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.EncryptToolStripMenuItem.Text = "Encrypt"
        '
        'DecryptToolStripMenuItem
        '
        Me.DecryptToolStripMenuItem.BackColor = System.Drawing.Color.DarkViolet
        Me.DecryptToolStripMenuItem.Image = Global.Client.My.Resources.Resources.icons8_adazdsqunlock_32
        Me.DecryptToolStripMenuItem.Name = "DecryptToolStripMenuItem"
        Me.DecryptToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.DecryptToolStripMenuItem.Text = "Decrypt"
        '
        'DownloadThisFileToolStripMenuItem
        '
        Me.DownloadThisFileToolStripMenuItem.BackColor = System.Drawing.Color.DarkViolet
        Me.DownloadThisFileToolStripMenuItem.Image = Global.Client.My.Resources.Resources.icons8_software_installer_32
        Me.DownloadThisFileToolStripMenuItem.Name = "DownloadThisFileToolStripMenuItem"
        Me.DownloadThisFileToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.DownloadThisFileToolStripMenuItem.Text = "Download this file"
        '
        'UploadAFileOnComputerVictimToolStripMenuItem
        '
        Me.UploadAFileOnComputerVictimToolStripMenuItem.BackColor = System.Drawing.Color.DarkViolet
        Me.UploadAFileOnComputerVictimToolStripMenuItem.Image = Global.Client.My.Resources.Resources.icons8_upload_32
        Me.UploadAFileOnComputerVictimToolStripMenuItem.Name = "UploadAFileOnComputerVictimToolStripMenuItem"
        Me.UploadAFileOnComputerVictimToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.UploadAFileOnComputerVictimToolStripMenuItem.Text = "Upload a file on computer victim"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(389, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(573, 30)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Path"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(52, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 31)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "= folders"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Client.My.Resources.Resources.icons8_codeazdazd_file
        Me.PictureBox2.Location = New System.Drawing.Point(135, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 31)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(186, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 30)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "= files"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Client.My.Resources.Resources.icons8_File_Eqsdqsdxplorer
        Me.PictureBox1.Location = New System.Drawing.Point(12, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(12, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(983, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Name"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Lime
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(240, 15)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(143, 21)
        Me.ComboBox1.TabIndex = 15
        '
        'OpenFileDial1
        '
        Me.OpenFileDial1.FileName = "Upload File"
        '
        'FMM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1007, 369)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.DarkViolet
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FMM"
        Me.Text = "FMM"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents GoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents EncryptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncryptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DecryptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DownloadThisFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UploadAFileOnComputerVictimToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDial1 As OpenFileDialog
End Class
