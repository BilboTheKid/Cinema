<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Heil_Honey
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Heil_Honey))
        Me.txtHeil = New System.Windows.Forms.RichTextBox()
        Me.lblHeilRate = New System.Windows.Forms.Label()
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.txtHeilInfo = New System.Windows.Forms.RichTextBox()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtHeil
        '
        Me.txtHeil.Location = New System.Drawing.Point(12, 12)
        Me.txtHeil.Name = "txtHeil"
        Me.txtHeil.Size = New System.Drawing.Size(301, 52)
        Me.txtHeil.TabIndex = 0
        Me.txtHeil.Text = "In Berlin, 1938, Adolf Hitler and Eva Braun have a love-hate relationship with th" &
    "eir Jewish neighbours in this bizarre spoof of 'fifties American sitcoms." & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblHeilRate
        '
        Me.lblHeilRate.AutoSize = True
        Me.lblHeilRate.Location = New System.Drawing.Point(12, 67)
        Me.lblHeilRate.Name = "lblHeilRate"
        Me.lblHeilRate.Size = New System.Drawing.Size(22, 13)
        Me.lblHeilRate.TabIndex = 1
        Me.lblHeilRate.Text = "PG"
        '
        'AxShockwaveFlash1
        '
        Me.AxShockwaveFlash1.Enabled = True
        Me.AxShockwaveFlash1.Location = New System.Drawing.Point(319, 12)
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash1.Size = New System.Drawing.Size(582, 307)
        Me.AxShockwaveFlash1.TabIndex = 2
        '
        'txtHeilInfo
        '
        Me.txtHeilInfo.Location = New System.Drawing.Point(15, 83)
        Me.txtHeilInfo.Name = "txtHeilInfo"
        Me.txtHeilInfo.Size = New System.Drawing.Size(298, 88)
        Me.txtHeilInfo.TabIndex = 4
        Me.txtHeilInfo.Text = "IMDb Movie Rating: 5.7/10 " & Global.Microsoft.VisualBasic.ChrW(10) & "Director: " & Global.Microsoft.VisualBasic.ChrW(10) & "Stars: Neil McCaul, Denica Fairman, Gareth " &
    "Marks" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Screen: 1" & Global.Microsoft.VisualBasic.ChrW(10) & "Time: 8:30pm "
        '
        'Heil_Honey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(768, 436)
        Me.Controls.Add(Me.txtHeilInfo)
        Me.Controls.Add(Me.AxShockwaveFlash1)
        Me.Controls.Add(Me.lblHeilRate)
        Me.Controls.Add(Me.txtHeil)
        Me.Name = "Heil_Honey"
        Me.Text = "Heil_Honey"
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtHeil As System.Windows.Forms.RichTextBox
    Friend WithEvents lblHeilRate As System.Windows.Forms.Label
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents txtHeilInfo As System.Windows.Forms.RichTextBox
End Class
