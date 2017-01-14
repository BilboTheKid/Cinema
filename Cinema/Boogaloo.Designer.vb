<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Boogaloo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Boogaloo))
        Me.txtBoogalooDesc = New System.Windows.Forms.RichTextBox()
        Me.lblBoogalooRate = New System.Windows.Forms.Label()
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.txtBoogalooInfo = New System.Windows.Forms.RichTextBox()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBoogalooDesc
        '
        Me.txtBoogalooDesc.Location = New System.Drawing.Point(12, 12)
        Me.txtBoogalooDesc.Name = "txtBoogalooDesc"
        Me.txtBoogalooDesc.Size = New System.Drawing.Size(366, 40)
        Me.txtBoogalooDesc.TabIndex = 0
        Me.txtBoogalooDesc.Text = "A developer tries to bulldoze a community recreation center. The local breakdance" & _
    "rs try to stop it." & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblBoogalooRate
        '
        Me.lblBoogalooRate.AutoSize = True
        Me.lblBoogalooRate.Location = New System.Drawing.Point(12, 55)
        Me.lblBoogalooRate.Name = "lblBoogalooRate"
        Me.lblBoogalooRate.Size = New System.Drawing.Size(26, 13)
        Me.lblBoogalooRate.TabIndex = 1
        Me.lblBoogalooRate.Text = "12A"
        '
        'AxShockwaveFlash1
        '
        Me.AxShockwaveFlash1.Enabled = True
        Me.AxShockwaveFlash1.Location = New System.Drawing.Point(384, 12)
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash1.Size = New System.Drawing.Size(475, 321)
        Me.AxShockwaveFlash1.TabIndex = 2
        '
        'txtBoogalooInfo
        '
        Me.txtBoogalooInfo.Location = New System.Drawing.Point(15, 71)
        Me.txtBoogalooInfo.Name = "txtBoogalooInfo"
        Me.txtBoogalooInfo.Size = New System.Drawing.Size(363, 86)
        Me.txtBoogalooInfo.TabIndex = 4
        Me.txtBoogalooInfo.Text = "IMDb Movie Rating: 4.9/10 " & Global.Microsoft.VisualBasic.ChrW(10) & "Director: Sam Fritsenberg" & Global.Microsoft.VisualBasic.ChrW(10) & "Stars: Magnus Lucinda Dickey" & _
    ", Adolfo Quinones, Michael Chambers" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Screen: 2" & Global.Microsoft.VisualBasic.ChrW(10) & "Time: 5pm "
        '
        'Boogaloo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(871, 434)
        Me.Controls.Add(Me.txtBoogalooInfo)
        Me.Controls.Add(Me.AxShockwaveFlash1)
        Me.Controls.Add(Me.lblBoogalooRate)
        Me.Controls.Add(Me.txtBoogalooDesc)
        Me.Name = "Boogaloo"
        Me.Text = "Boogaloo"
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBoogalooDesc As System.Windows.Forms.RichTextBox
    Friend WithEvents lblBoogalooRate As System.Windows.Forms.Label
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents txtBoogalooInfo As System.Windows.Forms.RichTextBox
End Class
