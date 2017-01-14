<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class We_are_number_one
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(We_are_number_one))
        Me.txtbee = New System.Windows.Forms.RichTextBox()
        Me.lblNmb1Rate = New System.Windows.Forms.Label()
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.txtOneInfo = New System.Windows.Forms.RichTextBox()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtbee
        '
        Me.txtbee.Location = New System.Drawing.Point(0, 0)
        Me.txtbee.Name = "txtbee"
        Me.txtbee.Size = New System.Drawing.Size(189, 461)
        Me.txtbee.TabIndex = 0
        Me.txtbee.Text = resources.GetString("txtbee.Text")
        '
        'lblNmb1Rate
        '
        Me.lblNmb1Rate.AutoSize = True
        Me.lblNmb1Rate.Location = New System.Drawing.Point(195, 9)
        Me.lblNmb1Rate.Name = "lblNmb1Rate"
        Me.lblNmb1Rate.Size = New System.Drawing.Size(25, 13)
        Me.lblNmb1Rate.TabIndex = 1
        Me.lblNmb1Rate.Text = "70+"
        '
        'AxShockwaveFlash1
        '
        Me.AxShockwaveFlash1.Enabled = True
        Me.AxShockwaveFlash1.Location = New System.Drawing.Point(195, 25)
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash1.Size = New System.Drawing.Size(579, 342)
        Me.AxShockwaveFlash1.TabIndex = 2
        '
        'txtOneInfo
        '
        Me.txtOneInfo.Location = New System.Drawing.Point(195, 373)
        Me.txtOneInfo.Name = "txtOneInfo"
        Me.txtOneInfo.Size = New System.Drawing.Size(579, 88)
        Me.txtOneInfo.TabIndex = 3
        Me.txtOneInfo.Text = "IMDb Movie Rating: 5.6/10 " & Global.Microsoft.VisualBasic.ChrW(10) & "Director: Magnus Scheving" & Global.Microsoft.VisualBasic.ChrW(10) & "Stars: Magnus Scheving, Stef" & _
    "an Karl Stefansson, Juliana Rose" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Screen: 1" & Global.Microsoft.VisualBasic.ChrW(10) & "Time: 11am "
        '
        'We_are_number_one
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(780, 466)
        Me.Controls.Add(Me.txtOneInfo)
        Me.Controls.Add(Me.AxShockwaveFlash1)
        Me.Controls.Add(Me.lblNmb1Rate)
        Me.Controls.Add(Me.txtbee)
        Me.Name = "We_are_number_one"
        Me.Text = "We_are_number_one"
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtbee As System.Windows.Forms.RichTextBox
    Friend WithEvents lblNmb1Rate As System.Windows.Forms.Label
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents txtOneInfo As System.Windows.Forms.RichTextBox
End Class
