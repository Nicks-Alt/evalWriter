<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEvalWriter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEvalWriter))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnBegin = New System.Windows.Forms.Button()
        Me.grpRank = New System.Windows.Forms.GroupBox()
        Me.radPAdmin = New System.Windows.Forms.RadioButton()
        Me.radTAdmin = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblProgramLocation = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.grpServer = New System.Windows.Forms.GroupBox()
        Me.radDarkRP = New System.Windows.Forms.RadioButton()
        Me.radSSRP = New System.Windows.Forms.RadioButton()
        Me.grpRank.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.grpServer.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'btnBegin
        '
        Me.btnBegin.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnBegin.Location = New System.Drawing.Point(180, 173)
        Me.btnBegin.Name = "btnBegin"
        Me.btnBegin.Size = New System.Drawing.Size(75, 23)
        Me.btnBegin.TabIndex = 1
        Me.btnBegin.Text = "Begin"
        Me.btnBegin.UseVisualStyleBackColor = False
        '
        'grpRank
        '
        Me.grpRank.BackColor = System.Drawing.Color.Transparent
        Me.grpRank.Controls.Add(Me.radPAdmin)
        Me.grpRank.Controls.Add(Me.radTAdmin)
        Me.grpRank.Font = New System.Drawing.Font("Yu Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRank.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.grpRank.Location = New System.Drawing.Point(31, 60)
        Me.grpRank.Name = "grpRank"
        Me.grpRank.Size = New System.Drawing.Size(106, 81)
        Me.grpRank.TabIndex = 5
        Me.grpRank.TabStop = False
        Me.grpRank.Text = "Your Rank"
        '
        'radPAdmin
        '
        Me.radPAdmin.AutoSize = True
        Me.radPAdmin.Location = New System.Drawing.Point(7, 52)
        Me.radPAdmin.Name = "radPAdmin"
        Me.radPAdmin.Size = New System.Drawing.Size(83, 20)
        Me.radPAdmin.TabIndex = 1
        Me.radPAdmin.TabStop = True
        Me.radPAdmin.Text = "P-Admin+"
        Me.radPAdmin.UseVisualStyleBackColor = True
        '
        'radTAdmin
        '
        Me.radTAdmin.AutoSize = True
        Me.radTAdmin.Checked = True
        Me.radTAdmin.Location = New System.Drawing.Point(6, 28)
        Me.radTAdmin.Name = "radTAdmin"
        Me.radTAdmin.Size = New System.Drawing.Size(73, 20)
        Me.radTAdmin.TabIndex = 0
        Me.radTAdmin.TabStop = True
        Me.radTAdmin.Text = "T-Admin"
        Me.radTAdmin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.IndianRed
        Me.Label1.Location = New System.Drawing.Point(50, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 11)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Current Program Location: "
        '
        'lblProgramLocation
        '
        Me.lblProgramLocation.AutoSize = True
        Me.lblProgramLocation.BackColor = System.Drawing.Color.Transparent
        Me.lblProgramLocation.Font = New System.Drawing.Font("MV Boli", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgramLocation.ForeColor = System.Drawing.Color.Khaki
        Me.lblProgramLocation.Location = New System.Drawing.Point(178, 204)
        Me.lblProgramLocation.Name = "lblProgramLocation"
        Me.lblProgramLocation.Size = New System.Drawing.Size(215, 11)
        Me.lblProgramLocation.TabIndex = 7
        Me.lblProgramLocation.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(435, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReadToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ReadToolStripMenuItem
        '
        Me.ReadToolStripMenuItem.Name = "ReadToolStripMenuItem"
        Me.ReadToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.ReadToolStripMenuItem.Text = "Read"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(42, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 28)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Eval Writer"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTime.Location = New System.Drawing.Point(275, 29)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(118, 21)
        Me.lblTime.TabIndex = 10
        Me.lblTime.Text = "XX:XX:XX XX"
        '
        'grpServer
        '
        Me.grpServer.Controls.Add(Me.radSSRP)
        Me.grpServer.Controls.Add(Me.radDarkRP)
        Me.grpServer.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.grpServer.Location = New System.Drawing.Point(287, 60)
        Me.grpServer.Name = "grpServer"
        Me.grpServer.Size = New System.Drawing.Size(106, 81)
        Me.grpServer.TabIndex = 11
        Me.grpServer.TabStop = False
        Me.grpServer.Text = "Your Server"
        '
        'radDarkRP
        '
        Me.radDarkRP.AutoSize = True
        Me.radDarkRP.Checked = True
        Me.radDarkRP.Location = New System.Drawing.Point(6, 28)
        Me.radDarkRP.Name = "radDarkRP"
        Me.radDarkRP.Size = New System.Drawing.Size(63, 17)
        Me.radDarkRP.TabIndex = 12
        Me.radDarkRP.Text = "DarkRP"
        Me.radDarkRP.UseVisualStyleBackColor = True
        '
        'radSSRP
        '
        Me.radSSRP.AutoSize = True
        Me.radSSRP.Location = New System.Drawing.Point(6, 52)
        Me.radSSRP.Name = "radSSRP"
        Me.radSSRP.Size = New System.Drawing.Size(54, 17)
        Me.radSSRP.TabIndex = 12
        Me.radSSRP.Text = "SSRP"
        Me.radSSRP.UseVisualStyleBackColor = True
        '
        'frmEvalWriter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(435, 226)
        Me.Controls.Add(Me.grpServer)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblProgramLocation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpRank)
        Me.Controls.Add(Me.btnBegin)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmEvalWriter"
        Me.Text = "Eval Writer"
        Me.grpRank.ResumeLayout(False)
        Me.grpRank.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpServer.ResumeLayout(False)
        Me.grpServer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnBegin As Button
    Friend WithEvents grpRank As GroupBox
    Friend WithEvents radPAdmin As RadioButton
    Friend WithEvents radTAdmin As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents lblProgramLocation As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents grpServer As GroupBox
    Friend WithEvents radSSRP As RadioButton
    Friend WithEvents radDarkRP As RadioButton
End Class
