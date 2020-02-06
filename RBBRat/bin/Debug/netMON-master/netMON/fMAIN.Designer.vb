<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fMAIN
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fMAIN))
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Test-Gerät", "AA-BB-CC-DD-EE-FF", "192.168.1.1", "2019-07-04 15:34:22"}, -1)
        Me.msMAIN = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeImportienToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeExportierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonitoringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StoppenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AktualisierungszeitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ÜbernehmenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsUnten = New System.Windows.Forms.ToolStrip()
        Me.tslGeraet = New System.Windows.Forms.ToolStripLabel()
        Me.tstbGeraet = New System.Windows.Forms.ToolStripTextBox()
        Me.tslMAC = New System.Windows.Forms.ToolStripLabel()
        Me.tstbMAC = New System.Windows.Forms.ToolStripTextBox()
        Me.tslIP = New System.Windows.Forms.ToolStripLabel()
        Me.tstbIP = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbHinzufuegen = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tspbMonitoring = New System.Windows.Forms.ToolStripProgressBar()
        Me.lvNetMON = New System.Windows.Forms.ListView()
        Me.chGerät = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chMAC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chIP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chLastSeen = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsLV = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GerätEntfernenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerätWeckenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.msMAIN.SuspendLayout()
        Me.tsUnten.SuspendLayout()
        Me.cmsLV.SuspendLayout()
        Me.SuspendLayout()
        '
        'msMAIN
        '
        Me.msMAIN.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.MonitoringToolStripMenuItem})
        Me.msMAIN.Location = New System.Drawing.Point(0, 0)
        Me.msMAIN.Name = "msMAIN"
        Me.msMAIN.Size = New System.Drawing.Size(643, 24)
        Me.msMAIN.TabIndex = 1
        Me.msMAIN.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListeImportienToolStripMenuItem, Me.ListeExportierenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'ListeImportienToolStripMenuItem
        '
        Me.ListeImportienToolStripMenuItem.Name = "ListeImportienToolStripMenuItem"
        Me.ListeImportienToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ListeImportienToolStripMenuItem.Text = "Liste importien"
        '
        'ListeExportierenToolStripMenuItem
        '
        Me.ListeExportierenToolStripMenuItem.Name = "ListeExportierenToolStripMenuItem"
        Me.ListeExportierenToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ListeExportierenToolStripMenuItem.Text = "Liste exportieren"
        '
        'MonitoringToolStripMenuItem
        '
        Me.MonitoringToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartenToolStripMenuItem, Me.StoppenToolStripMenuItem, Me.ToolStripSeparator2, Me.AktualisierungszeitToolStripMenuItem, Me.ToolStripTextBox1, Me.ÜbernehmenToolStripMenuItem})
        Me.MonitoringToolStripMenuItem.Name = "MonitoringToolStripMenuItem"
        Me.MonitoringToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.MonitoringToolStripMenuItem.Text = "Monitoring"
        '
        'StartenToolStripMenuItem
        '
        Me.StartenToolStripMenuItem.Name = "StartenToolStripMenuItem"
        Me.StartenToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.StartenToolStripMenuItem.Text = "Starten"
        '
        'StoppenToolStripMenuItem
        '
        Me.StoppenToolStripMenuItem.Name = "StoppenToolStripMenuItem"
        Me.StoppenToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.StoppenToolStripMenuItem.Text = "Stoppen"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(163, 6)
        '
        'AktualisierungszeitToolStripMenuItem
        '
        Me.AktualisierungszeitToolStripMenuItem.Enabled = False
        Me.AktualisierungszeitToolStripMenuItem.Name = "AktualisierungszeitToolStripMenuItem"
        Me.AktualisierungszeitToolStripMenuItem.ShowShortcutKeys = False
        Me.AktualisierungszeitToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.AktualisierungszeitToolStripMenuItem.Text = "Aktualisierungszeit"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox1.Text = "5000"
        '
        'ÜbernehmenToolStripMenuItem
        '
        Me.ÜbernehmenToolStripMenuItem.Name = "ÜbernehmenToolStripMenuItem"
        Me.ÜbernehmenToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ÜbernehmenToolStripMenuItem.Text = "Übernehmen"
        '
        'tsUnten
        '
        Me.tsUnten.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsUnten.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslGeraet, Me.tstbGeraet, Me.tslMAC, Me.tstbMAC, Me.tslIP, Me.tstbIP, Me.tsbHinzufuegen, Me.ToolStripSeparator1, Me.tspbMonitoring})
        Me.tsUnten.Location = New System.Drawing.Point(0, 390)
        Me.tsUnten.Name = "tsUnten"
        Me.tsUnten.Size = New System.Drawing.Size(643, 25)
        Me.tsUnten.TabIndex = 4
        Me.tsUnten.Text = "ToolStrip1"
        '
        'tslGeraet
        '
        Me.tslGeraet.Name = "tslGeraet"
        Me.tslGeraet.Size = New System.Drawing.Size(38, 22)
        Me.tslGeraet.Text = "Gerät:"
        '
        'tstbGeraet
        '
        Me.tstbGeraet.Name = "tstbGeraet"
        Me.tstbGeraet.Size = New System.Drawing.Size(100, 25)
        '
        'tslMAC
        '
        Me.tslMAC.Name = "tslMAC"
        Me.tslMAC.Size = New System.Drawing.Size(37, 22)
        Me.tslMAC.Text = "MAC:"
        '
        'tstbMAC
        '
        Me.tstbMAC.Name = "tstbMAC"
        Me.tstbMAC.Size = New System.Drawing.Size(120, 25)
        '
        'tslIP
        '
        Me.tslIP.Name = "tslIP"
        Me.tslIP.Size = New System.Drawing.Size(20, 22)
        Me.tslIP.Text = "IP:"
        '
        'tstbIP
        '
        Me.tstbIP.Name = "tstbIP"
        Me.tstbIP.Size = New System.Drawing.Size(100, 25)
        '
        'tsbHinzufuegen
        '
        Me.tsbHinzufuegen.AutoSize = False
        Me.tsbHinzufuegen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbHinzufuegen.Image = CType(resources.GetObject("tsbHinzufuegen.Image"), System.Drawing.Image)
        Me.tsbHinzufuegen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbHinzufuegen.Name = "tsbHinzufuegen"
        Me.tsbHinzufuegen.Size = New System.Drawing.Size(102, 22)
        Me.tsbHinzufuegen.Text = "Gerät hinzufügen"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tspbMonitoring
        '
        Me.tspbMonitoring.Name = "tspbMonitoring"
        Me.tspbMonitoring.Size = New System.Drawing.Size(100, 22)
        Me.tspbMonitoring.Step = 1
        '
        'lvNetMON
        '
        Me.lvNetMON.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chGerät, Me.chMAC, Me.chIP, Me.chLastSeen})
        Me.lvNetMON.ContextMenuStrip = Me.cmsLV
        Me.lvNetMON.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvNetMON.FullRowSelect = True
        Me.lvNetMON.GridLines = True
        ListViewItem2.StateImageIndex = 0
        Me.lvNetMON.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem2})
        Me.lvNetMON.Location = New System.Drawing.Point(0, 24)
        Me.lvNetMON.Name = "lvNetMON"
        Me.lvNetMON.Size = New System.Drawing.Size(643, 366)
        Me.lvNetMON.TabIndex = 5
        Me.lvNetMON.UseCompatibleStateImageBehavior = False
        Me.lvNetMON.View = System.Windows.Forms.View.Details
        '
        'chGerät
        '
        Me.chGerät.Text = "Gerät"
        Me.chGerät.Width = 220
        '
        'chMAC
        '
        Me.chMAC.Text = "MAC-Adresse"
        Me.chMAC.Width = 120
        '
        'chIP
        '
        Me.chIP.Text = "IP-Adresse (IPv4)"
        Me.chIP.Width = 120
        '
        'chLastSeen
        '
        Me.chLastSeen.Text = "Zuletzt aktiv"
        Me.chLastSeen.Width = 120
        '
        'cmsLV
        '
        Me.cmsLV.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GerätEntfernenToolStripMenuItem, Me.GerätWeckenToolStripMenuItem})
        Me.cmsLV.Name = "cmsLV"
        Me.cmsLV.Size = New System.Drawing.Size(157, 48)
        '
        'GerätEntfernenToolStripMenuItem
        '
        Me.GerätEntfernenToolStripMenuItem.Name = "GerätEntfernenToolStripMenuItem"
        Me.GerätEntfernenToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.GerätEntfernenToolStripMenuItem.Text = "Gerät entfernen"
        '
        'GerätWeckenToolStripMenuItem
        '
        Me.GerätWeckenToolStripMenuItem.Name = "GerätWeckenToolStripMenuItem"
        Me.GerätWeckenToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.GerätWeckenToolStripMenuItem.Text = "Gerät wecken"
        '
        'Timer1
        '
        '
        'fMAIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 415)
        Me.Controls.Add(Me.lvNetMON)
        Me.Controls.Add(Me.tsUnten)
        Me.Controls.Add(Me.msMAIN)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.msMAIN
        Me.MaximizeBox = False
        Me.Name = "fMAIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "netMON"
        Me.msMAIN.ResumeLayout(False)
        Me.msMAIN.PerformLayout()
        Me.tsUnten.ResumeLayout(False)
        Me.tsUnten.PerformLayout()
        Me.cmsLV.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msMAIN As MenuStrip
    Friend WithEvents DateiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsUnten As ToolStrip
    Friend WithEvents tstbGeraet As ToolStripTextBox
    Friend WithEvents tslGeraet As ToolStripLabel
    Friend WithEvents lvNetMON As ListView
    Friend WithEvents chGerät As ColumnHeader
    Friend WithEvents chMAC As ColumnHeader
    Friend WithEvents chIP As ColumnHeader
    Friend WithEvents chLastSeen As ColumnHeader
    Friend WithEvents tslMAC As ToolStripLabel
    Friend WithEvents tstbMAC As ToolStripTextBox
    Friend WithEvents tslIP As ToolStripLabel
    Friend WithEvents tstbIP As ToolStripTextBox
    Friend WithEvents tsbHinzufuegen As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tspbMonitoring As ToolStripProgressBar
    Friend WithEvents MonitoringToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StoppenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents AktualisierungszeitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents cmsLV As ContextMenuStrip
    Friend WithEvents GerätEntfernenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ListeImportienToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListeExportierenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÜbernehmenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GerätWeckenToolStripMenuItem As ToolStripMenuItem
End Class
