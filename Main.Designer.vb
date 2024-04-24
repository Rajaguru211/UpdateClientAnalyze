<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Me.dtpDate = New System.Windows.Forms.DateTimePicker()
    Me.txtUrl = New System.Windows.Forms.TextBox()
    Me.txtVersion = New System.Windows.Forms.TextBox()
    Me.btnGo = New System.Windows.Forms.Button()
    Me.lsvClients = New System.Windows.Forms.ListView()
    Me.pnlTop = New System.Windows.Forms.Panel()
    Me.lblCopyUrl = New System.Windows.Forms.Label()
    Me.lblDate = New System.Windows.Forms.Label()
    Me.lblUrl = New System.Windows.Forms.Label()
    Me.lblVersion = New System.Windows.Forms.Label()
    Me.lblCompanyLength = New System.Windows.Forms.Label()
    Me.txtCompanyLength = New System.Windows.Forms.TextBox()
    Me.mnuClient = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.mnuCopyCompanyName = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCopyLicenseKey = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
    Me.pnlTop.SuspendLayout()
    Me.mnuClient.SuspendLayout()
    Me.SuspendLayout()
    '
    'dtpDate
    '
    Me.dtpDate.Checked = False
    Me.dtpDate.CustomFormat = "MM/dd/yyyy"
    Me.dtpDate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtpDate.Location = New System.Drawing.Point(770, 29)
    Me.dtpDate.Name = "dtpDate"
    Me.dtpDate.Size = New System.Drawing.Size(95, 27)
    Me.dtpDate.TabIndex = 78
    '
    'txtUrl
    '
    Me.txtUrl.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtUrl.Location = New System.Drawing.Point(14, 29)
    Me.txtUrl.Name = "txtUrl"
    Me.txtUrl.Size = New System.Drawing.Size(544, 27)
    Me.txtUrl.TabIndex = 79
    Me.txtUrl.Text = "http://outputmessenger.com/wp-content/plugins/update_oumversion/logs/"
    '
    'txtVersion
    '
    Me.txtVersion.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtVersion.Location = New System.Drawing.Point(564, 29)
    Me.txtVersion.Name = "txtVersion"
    Me.txtVersion.Size = New System.Drawing.Size(97, 27)
    Me.txtVersion.TabIndex = 80
    Me.txtVersion.Text = "2.0.41"
    '
    'btnGo
    '
    Me.btnGo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnGo.Location = New System.Drawing.Point(871, 28)
    Me.btnGo.Name = "btnGo"
    Me.btnGo.Size = New System.Drawing.Size(60, 30)
    Me.btnGo.TabIndex = 81
    Me.btnGo.Text = "GO"
    Me.btnGo.UseVisualStyleBackColor = True
    '
    'lsvClients
    '
    Me.lsvClients.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lsvClients.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lsvClients.FullRowSelect = True
    Me.lsvClients.Location = New System.Drawing.Point(0, 68)
    Me.lsvClients.MultiSelect = False
    Me.lsvClients.Name = "lsvClients"
    Me.lsvClients.Size = New System.Drawing.Size(1088, 682)
    Me.lsvClients.Sorting = System.Windows.Forms.SortOrder.Ascending
    Me.lsvClients.TabIndex = 83
    Me.lsvClients.UseCompatibleStateImageBehavior = False
    Me.lsvClients.View = System.Windows.Forms.View.Details
    '
    'pnlTop
    '
    Me.pnlTop.Controls.Add(Me.lblCopyUrl)
    Me.pnlTop.Controls.Add(Me.lblDate)
    Me.pnlTop.Controls.Add(Me.lblUrl)
    Me.pnlTop.Controls.Add(Me.lblVersion)
    Me.pnlTop.Controls.Add(Me.lblCompanyLength)
    Me.pnlTop.Controls.Add(Me.txtCompanyLength)
    Me.pnlTop.Controls.Add(Me.txtUrl)
    Me.pnlTop.Controls.Add(Me.dtpDate)
    Me.pnlTop.Controls.Add(Me.btnGo)
    Me.pnlTop.Controls.Add(Me.txtVersion)
    Me.pnlTop.Cursor = System.Windows.Forms.Cursors.Hand
    Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlTop.Location = New System.Drawing.Point(0, 0)
    Me.pnlTop.Name = "pnlTop"
    Me.pnlTop.Size = New System.Drawing.Size(1088, 68)
    Me.pnlTop.TabIndex = 84
    '
    'lblCopyUrl
    '
    Me.lblCopyUrl.Image = Global.WindowsApplication1.My.Resources.Resources.copy_18
    Me.lblCopyUrl.Location = New System.Drawing.Point(942, 34)
    Me.lblCopyUrl.Name = "lblCopyUrl"
    Me.lblCopyUrl.Size = New System.Drawing.Size(20, 20)
    Me.lblCopyUrl.TabIndex = 87
    Me.ToolTip1.SetToolTip(Me.lblCopyUrl, "Copy Url")
    '
    'lblDate
    '
    Me.lblDate.AutoSize = True
    Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblDate.Location = New System.Drawing.Point(767, 14)
    Me.lblDate.Name = "lblDate"
    Me.lblDate.Size = New System.Drawing.Size(31, 13)
    Me.lblDate.TabIndex = 86
    Me.lblDate.Text = "Date"
    '
    'lblUrl
    '
    Me.lblUrl.AutoSize = True
    Me.lblUrl.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblUrl.Location = New System.Drawing.Point(12, 14)
    Me.lblUrl.Name = "lblUrl"
    Me.lblUrl.Size = New System.Drawing.Size(22, 13)
    Me.lblUrl.TabIndex = 85
    Me.lblUrl.Text = "Url"
    '
    'lblVersion
    '
    Me.lblVersion.AutoSize = True
    Me.lblVersion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblVersion.Location = New System.Drawing.Point(561, 14)
    Me.lblVersion.Name = "lblVersion"
    Me.lblVersion.Size = New System.Drawing.Size(45, 13)
    Me.lblVersion.TabIndex = 84
    Me.lblVersion.Text = "Version"
    '
    'lblCompanyLength
    '
    Me.lblCompanyLength.AutoSize = True
    Me.lblCompanyLength.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCompanyLength.Location = New System.Drawing.Point(665, 14)
    Me.lblCompanyLength.Name = "lblCompanyLength"
    Me.lblCompanyLength.Size = New System.Drawing.Size(94, 13)
    Me.lblCompanyLength.TabIndex = 83
    Me.lblCompanyLength.Text = "Company Length"
    '
    'txtCompanyLength
    '
    Me.txtCompanyLength.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtCompanyLength.Location = New System.Drawing.Point(667, 29)
    Me.txtCompanyLength.Name = "txtCompanyLength"
    Me.txtCompanyLength.Size = New System.Drawing.Size(97, 27)
    Me.txtCompanyLength.TabIndex = 82
    Me.txtCompanyLength.Text = "x"
    '
    'mnuClient
    '
    Me.mnuClient.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCopyCompanyName, Me.mnuCopyLicenseKey})
    Me.mnuClient.Name = "mnuChatSend"
    Me.mnuClient.Size = New System.Drawing.Size(193, 48)
    '
    'mnuCopyCompanyName
    '
    Me.mnuCopyCompanyName.Name = "mnuCopyCompanyName"
    Me.mnuCopyCompanyName.Size = New System.Drawing.Size(192, 22)
    Me.mnuCopyCompanyName.Text = "Copy Company Name"
    '
    'mnuCopyLicenseKey
    '
    Me.mnuCopyLicenseKey.Name = "mnuCopyLicenseKey"
    Me.mnuCopyLicenseKey.Size = New System.Drawing.Size(192, 22)
    Me.mnuCopyLicenseKey.Text = "Copy License Key"
    '
    'Main
    '
    Me.AcceptButton = Me.btnGo
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1088, 750)
    Me.Controls.Add(Me.lsvClients)
    Me.Controls.Add(Me.pnlTop)
    Me.Name = "Main"
    Me.Text = "OUM Client Analyze"
    Me.pnlTop.ResumeLayout(False)
    Me.pnlTop.PerformLayout()
    Me.mnuClient.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents dtpDate As DateTimePicker
  Friend WithEvents txtUrl As TextBox
  Friend WithEvents txtVersion As TextBox
  Friend WithEvents btnGo As Button
  Friend WithEvents lsvClients As ListView
  Friend WithEvents pnlTop As Panel
  Friend WithEvents mnuClient As ContextMenuStrip
  Friend WithEvents mnuCopyCompanyName As ToolStripMenuItem
  Friend WithEvents mnuCopyLicenseKey As ToolStripMenuItem
  Friend WithEvents txtCompanyLength As TextBox
  Friend WithEvents lblCompanyLength As Label
  Friend WithEvents lblUrl As Label
  Friend WithEvents lblVersion As Label
  Friend WithEvents lblDate As Label
  Friend WithEvents lblCopyUrl As Label
  Friend WithEvents ToolTip1 As ToolTip
End Class
