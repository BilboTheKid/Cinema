<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rottenbeard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rottenbeard))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.lblRottenRate = New System.Windows.Forms.Label()
        Me.ShkRottenbeard = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.txtRottenInfo = New System.Windows.Forms.RichTextBox()
        CType(Me.ShkRottenbeard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(423, 87)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'lblRottenRate
        '
        Me.lblRottenRate.AutoSize = True
        Me.lblRottenRate.Location = New System.Drawing.Point(12, 102)
        Me.lblRottenRate.Name = "lblRottenRate"
        Me.lblRottenRate.Size = New System.Drawing.Size(19, 13)
        Me.lblRottenRate.TabIndex = 1
        Me.lblRottenRate.Text = "18"
        '
        'ShkRottenbeard
        '
        Me.ShkRottenbeard.Enabled = True
        Me.ShkRottenbeard.Location = New System.Drawing.Point(441, 12)
        Me.ShkRottenbeard.Name = "ShkRottenbeard"
        Me.ShkRottenbeard.OcxState = CType(resources.GetObject("ShkRottenbeard.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ShkRottenbeard.Size = New System.Drawing.Size(621, 389)
        Me.ShkRottenbeard.TabIndex = 2
        '
        'txtRottenInfo
        '
        Me.txtRottenInfo.Location = New System.Drawing.Point(12, 118)
        Me.txtRottenInfo.Name = "txtRottenInfo"
        Me.txtRottenInfo.Size = New System.Drawing.Size(423, 88)
        Me.txtRottenInfo.TabIndex = 4
        Me.txtRottenInfo.Text = "IMDb Movie Rating: 8.0/10 " & Global.Microsoft.VisualBasic.ChrW(10) & "Director: Gore Verbinski" & Global.Microsoft.VisualBasic.ChrW(10) & "Stars: Johnny Depp, Geoffrey " &
    "Rush, Orlando Bloom" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Screen: 1" & Global.Microsoft.VisualBasic.ChrW(10) & "Time: 5pm "
        '
        'Rottenbeard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(936, 562)
        Me.Controls.Add(Me.txtRottenInfo)
        Me.Controls.Add(Me.ShkRottenbeard)
        Me.Controls.Add(Me.lblRottenRate)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "Rottenbeard"
        Me.Text = "Rottenbeard"
        CType(Me.ShkRottenbeard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents lblRottenRate As System.Windows.Forms.Label
    Friend WithEvents ShkRottenbeard As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents txtRottenInfo As System.Windows.Forms.RichTextBox
End Class
