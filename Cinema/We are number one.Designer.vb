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
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnBuy = New System.Windows.Forms.Button()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.txtOAPTotal = New System.Windows.Forms.TextBox()
        Me.txtAdultTotal = New System.Windows.Forms.TextBox()
        Me.txtChildTotal = New System.Windows.Forms.TextBox()
        Me.lstAge = New System.Windows.Forms.ListBox()
        Me.btnMvSel = New System.Windows.Forms.Button()
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
        Me.txtOneInfo.Text = "IMDb Movie Rating: 5.6/10 " & Global.Microsoft.VisualBasic.ChrW(10) & "Director: Magnus Scheving" & Global.Microsoft.VisualBasic.ChrW(10) & "Stars: Magnus Scheving, Stef" &
    "an Karl Stefansson, Juliana Rose" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Screen: 1" & Global.Microsoft.VisualBasic.ChrW(10) & "Time: 11am "
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnNew.Location = New System.Drawing.Point(919, 25)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(150, 43)
        Me.btnNew.TabIndex = 19
        Me.btnNew.Text = "Add Person"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnBuy
        '
        Me.btnBuy.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBuy.Location = New System.Drawing.Point(919, 100)
        Me.btnBuy.Name = "btnBuy"
        Me.btnBuy.Size = New System.Drawing.Size(150, 46)
        Me.btnBuy.TabIndex = 18
        Me.btnBuy.Text = "Purchase"
        Me.btnBuy.UseVisualStyleBackColor = False
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Location = New System.Drawing.Point(919, 74)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(150, 20)
        Me.txtTotalPrice.TabIndex = 17
        '
        'txtOAPTotal
        '
        Me.txtOAPTotal.Location = New System.Drawing.Point(780, 126)
        Me.txtOAPTotal.Name = "txtOAPTotal"
        Me.txtOAPTotal.ReadOnly = True
        Me.txtOAPTotal.Size = New System.Drawing.Size(133, 20)
        Me.txtOAPTotal.TabIndex = 16
        '
        'txtAdultTotal
        '
        Me.txtAdultTotal.Location = New System.Drawing.Point(780, 100)
        Me.txtAdultTotal.Name = "txtAdultTotal"
        Me.txtAdultTotal.ReadOnly = True
        Me.txtAdultTotal.Size = New System.Drawing.Size(133, 20)
        Me.txtAdultTotal.TabIndex = 15
        '
        'txtChildTotal
        '
        Me.txtChildTotal.Location = New System.Drawing.Point(780, 74)
        Me.txtChildTotal.Name = "txtChildTotal"
        Me.txtChildTotal.ReadOnly = True
        Me.txtChildTotal.Size = New System.Drawing.Size(133, 20)
        Me.txtChildTotal.TabIndex = 14
        '
        'lstAge
        '
        Me.lstAge.FormattingEnabled = True
        Me.lstAge.Items.AddRange(New Object() {"Child" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "£3.50", "Adult" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "£5.95", "OAP" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "£4.95"})
        Me.lstAge.Location = New System.Drawing.Point(780, 25)
        Me.lstAge.Name = "lstAge"
        Me.lstAge.Size = New System.Drawing.Size(133, 43)
        Me.lstAge.TabIndex = 13
        '
        'btnMvSel
        '
        Me.btnMvSel.Location = New System.Drawing.Point(780, 152)
        Me.btnMvSel.Name = "btnMvSel"
        Me.btnMvSel.Size = New System.Drawing.Size(75, 23)
        Me.btnMvSel.TabIndex = 20
        Me.btnMvSel.Text = "Back"
        Me.btnMvSel.UseVisualStyleBackColor = True
        '
        'We_are_number_one
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1074, 469)
        Me.Controls.Add(Me.btnMvSel)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnBuy)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.txtOAPTotal)
        Me.Controls.Add(Me.txtAdultTotal)
        Me.Controls.Add(Me.txtChildTotal)
        Me.Controls.Add(Me.lstAge)
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
    Friend WithEvents btnNew As Button
    Friend WithEvents btnBuy As Button
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents txtOAPTotal As TextBox
    Friend WithEvents txtAdultTotal As TextBox
    Friend WithEvents txtChildTotal As TextBox
    Friend WithEvents lstAge As ListBox
    Friend WithEvents btnMvSel As Button
End Class
