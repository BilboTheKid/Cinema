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
        'txtBoogalooDesc
        '
        Me.txtBoogalooDesc.Location = New System.Drawing.Point(12, 12)
        Me.txtBoogalooDesc.Name = "txtBoogalooDesc"
        Me.txtBoogalooDesc.Size = New System.Drawing.Size(366, 40)
        Me.txtBoogalooDesc.TabIndex = 0
        Me.txtBoogalooDesc.Text = "A developer tries to bulldoze a community recreation center. The local breakdance" &
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
        Me.txtBoogalooInfo.Text = "IMDb Movie Rating: 4.9/10 " & Global.Microsoft.VisualBasic.ChrW(10) & "Director: Sam Fritsenberg" & Global.Microsoft.VisualBasic.ChrW(10) & "Stars: Magnus Lucinda Dickey" &
    ", Adolfo Quinones, Michael Chambers" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Screen: 2" & Global.Microsoft.VisualBasic.ChrW(10) & "Time: 5pm "
        '
        'btnMvSel
        '
        Me.btnMvSel.Location = New System.Drawing.Point(12, 290)
        Me.btnMvSel.Name = "btnMvSel"
        Me.btnMvSel.Size = New System.Drawing.Size(75, 23)
        Me.btnMvSel.TabIndex = 14
        Me.btnMvSel.Text = "Back"
        Me.btnMvSel.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnNew.Location = New System.Drawing.Point(151, 163)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(150, 43)
        Me.btnNew.TabIndex = 26
        Me.btnNew.Text = "Add Person"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnBuy
        '
        Me.btnBuy.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBuy.Location = New System.Drawing.Point(151, 238)
        Me.btnBuy.Name = "btnBuy"
        Me.btnBuy.Size = New System.Drawing.Size(150, 46)
        Me.btnBuy.TabIndex = 25
        Me.btnBuy.Text = "Purchase"
        Me.btnBuy.UseVisualStyleBackColor = False
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Location = New System.Drawing.Point(151, 212)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(150, 20)
        Me.txtTotalPrice.TabIndex = 24
        '
        'txtOAPTotal
        '
        Me.txtOAPTotal.Location = New System.Drawing.Point(12, 264)
        Me.txtOAPTotal.Name = "txtOAPTotal"
        Me.txtOAPTotal.ReadOnly = True
        Me.txtOAPTotal.Size = New System.Drawing.Size(133, 20)
        Me.txtOAPTotal.TabIndex = 23
        '
        'txtAdultTotal
        '
        Me.txtAdultTotal.Location = New System.Drawing.Point(12, 238)
        Me.txtAdultTotal.Name = "txtAdultTotal"
        Me.txtAdultTotal.ReadOnly = True
        Me.txtAdultTotal.Size = New System.Drawing.Size(133, 20)
        Me.txtAdultTotal.TabIndex = 22
        '
        'txtChildTotal
        '
        Me.txtChildTotal.Location = New System.Drawing.Point(12, 212)
        Me.txtChildTotal.Name = "txtChildTotal"
        Me.txtChildTotal.ReadOnly = True
        Me.txtChildTotal.Size = New System.Drawing.Size(133, 20)
        Me.txtChildTotal.TabIndex = 21
        '
        'lstAge
        '
        Me.lstAge.FormattingEnabled = True
        Me.lstAge.Items.AddRange(New Object() {"Child" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "£3.50", "Adult" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "£5.95", "OAP" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "£4.95"})
        Me.lstAge.Location = New System.Drawing.Point(12, 163)
        Me.lstAge.Name = "lstAge"
        Me.lstAge.Size = New System.Drawing.Size(133, 43)
        Me.lstAge.TabIndex = 20
        '
        'Boogaloo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(871, 341)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnBuy)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.txtOAPTotal)
        Me.Controls.Add(Me.txtAdultTotal)
        Me.Controls.Add(Me.txtChildTotal)
        Me.Controls.Add(Me.lstAge)
        Me.Controls.Add(Me.btnMvSel)
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
    Friend WithEvents btnMvSel As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnBuy As Button
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents txtOAPTotal As TextBox
    Friend WithEvents txtAdultTotal As TextBox
    Friend WithEvents txtChildTotal As TextBox
    Friend WithEvents lstAge As ListBox
End Class
