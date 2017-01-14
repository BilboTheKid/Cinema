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
        Me.btnMvSel = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnBuy = New System.Windows.Forms.Button()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.txtOAPTotal = New System.Windows.Forms.TextBox()
        Me.txtAdultTotal = New System.Windows.Forms.TextBox()
        Me.txtChildTotal = New System.Windows.Forms.TextBox()
        Me.lstAge = New System.Windows.Forms.ListBox()
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
        'btnMvSel
        '
        Me.btnMvSel.Location = New System.Drawing.Point(12, 304)
        Me.btnMvSel.Name = "btnMvSel"
        Me.btnMvSel.Size = New System.Drawing.Size(75, 23)
        Me.btnMvSel.TabIndex = 14
        Me.btnMvSel.Text = "Back"
        Me.btnMvSel.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnNew.Location = New System.Drawing.Point(154, 177)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(150, 43)
        Me.btnNew.TabIndex = 26
        Me.btnNew.Text = "Add Person"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnBuy
        '
        Me.btnBuy.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBuy.Location = New System.Drawing.Point(154, 252)
        Me.btnBuy.Name = "btnBuy"
        Me.btnBuy.Size = New System.Drawing.Size(150, 46)
        Me.btnBuy.TabIndex = 25
        Me.btnBuy.Text = "Purchase"
        Me.btnBuy.UseVisualStyleBackColor = False
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Location = New System.Drawing.Point(154, 226)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(150, 20)
        Me.txtTotalPrice.TabIndex = 24
        '
        'txtOAPTotal
        '
        Me.txtOAPTotal.Location = New System.Drawing.Point(15, 278)
        Me.txtOAPTotal.Name = "txtOAPTotal"
        Me.txtOAPTotal.ReadOnly = True
        Me.txtOAPTotal.Size = New System.Drawing.Size(133, 20)
        Me.txtOAPTotal.TabIndex = 23
        '
        'txtAdultTotal
        '
        Me.txtAdultTotal.Location = New System.Drawing.Point(15, 252)
        Me.txtAdultTotal.Name = "txtAdultTotal"
        Me.txtAdultTotal.ReadOnly = True
        Me.txtAdultTotal.Size = New System.Drawing.Size(133, 20)
        Me.txtAdultTotal.TabIndex = 22
        '
        'txtChildTotal
        '
        Me.txtChildTotal.Location = New System.Drawing.Point(15, 226)
        Me.txtChildTotal.Name = "txtChildTotal"
        Me.txtChildTotal.ReadOnly = True
        Me.txtChildTotal.Size = New System.Drawing.Size(133, 20)
        Me.txtChildTotal.TabIndex = 21
        '
        'lstAge
        '
        Me.lstAge.FormattingEnabled = True
        Me.lstAge.Items.AddRange(New Object() {"Child" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "£3.50", "Adult" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "£5.95", "OAP" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "£4.95"})
        Me.lstAge.Location = New System.Drawing.Point(15, 177)
        Me.lstAge.Name = "lstAge"
        Me.lstAge.Size = New System.Drawing.Size(133, 43)
        Me.lstAge.TabIndex = 20
        '
        'Heil_Honey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(768, 335)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnBuy)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.txtOAPTotal)
        Me.Controls.Add(Me.txtAdultTotal)
        Me.Controls.Add(Me.txtChildTotal)
        Me.Controls.Add(Me.lstAge)
        Me.Controls.Add(Me.btnMvSel)
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
    Friend WithEvents btnMvSel As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnBuy As Button
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents txtOAPTotal As TextBox
    Friend WithEvents txtAdultTotal As TextBox
    Friend WithEvents txtChildTotal As TextBox
    Friend WithEvents lstAge As ListBox
End Class
