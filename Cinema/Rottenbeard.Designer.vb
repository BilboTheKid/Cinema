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
        Me.btnMvSel = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnBuy = New System.Windows.Forms.Button()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.txtOAPTotal = New System.Windows.Forms.TextBox()
        Me.txtAdultTotal = New System.Windows.Forms.TextBox()
        Me.txtChildTotal = New System.Windows.Forms.TextBox()
        Me.lstAge = New System.Windows.Forms.ListBox()
        CType(Me.ShkRottenbeard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(356, 87)
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
        Me.ShkRottenbeard.Location = New System.Drawing.Point(374, 12)
        Me.ShkRottenbeard.Name = "ShkRottenbeard"
        Me.ShkRottenbeard.OcxState = CType(resources.GetObject("ShkRottenbeard.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ShkRottenbeard.Size = New System.Drawing.Size(621, 389)
        Me.ShkRottenbeard.TabIndex = 2
        '
        'txtRottenInfo
        '
        Me.txtRottenInfo.Location = New System.Drawing.Point(12, 118)
        Me.txtRottenInfo.Name = "txtRottenInfo"
        Me.txtRottenInfo.Size = New System.Drawing.Size(356, 88)
        Me.txtRottenInfo.TabIndex = 4
        Me.txtRottenInfo.Text = "IMDb Movie Rating: 8.0/10 " & Global.Microsoft.VisualBasic.ChrW(10) & "Director: Gore Verbinski" & Global.Microsoft.VisualBasic.ChrW(10) & "Stars: Johnny Depp, Geoffrey " &
    "Rush, Orlando Bloom" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Screen: 1" & Global.Microsoft.VisualBasic.ChrW(10) & "Time: 5pm "
        '
        'btnMvSel
        '
        Me.btnMvSel.Location = New System.Drawing.Point(12, 339)
        Me.btnMvSel.Name = "btnMvSel"
        Me.btnMvSel.Size = New System.Drawing.Size(75, 23)
        Me.btnMvSel.TabIndex = 14
        Me.btnMvSel.Text = "Back"
        Me.btnMvSel.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnNew.Location = New System.Drawing.Point(151, 212)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(150, 43)
        Me.btnNew.TabIndex = 26
        Me.btnNew.Text = "Add Person"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnBuy
        '
        Me.btnBuy.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBuy.Location = New System.Drawing.Point(151, 287)
        Me.btnBuy.Name = "btnBuy"
        Me.btnBuy.Size = New System.Drawing.Size(150, 46)
        Me.btnBuy.TabIndex = 25
        Me.btnBuy.Text = "Purchase"
        Me.btnBuy.UseVisualStyleBackColor = False
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Location = New System.Drawing.Point(151, 261)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(150, 20)
        Me.txtTotalPrice.TabIndex = 24
        '
        'txtOAPTotal
        '
        Me.txtOAPTotal.Location = New System.Drawing.Point(12, 313)
        Me.txtOAPTotal.Name = "txtOAPTotal"
        Me.txtOAPTotal.ReadOnly = True
        Me.txtOAPTotal.Size = New System.Drawing.Size(133, 20)
        Me.txtOAPTotal.TabIndex = 23
        '
        'txtAdultTotal
        '
        Me.txtAdultTotal.Location = New System.Drawing.Point(12, 287)
        Me.txtAdultTotal.Name = "txtAdultTotal"
        Me.txtAdultTotal.ReadOnly = True
        Me.txtAdultTotal.Size = New System.Drawing.Size(133, 20)
        Me.txtAdultTotal.TabIndex = 22
        '
        'txtChildTotal
        '
        Me.txtChildTotal.Location = New System.Drawing.Point(12, 261)
        Me.txtChildTotal.Name = "txtChildTotal"
        Me.txtChildTotal.ReadOnly = True
        Me.txtChildTotal.Size = New System.Drawing.Size(133, 20)
        Me.txtChildTotal.TabIndex = 21
        '
        'lstAge
        '
        Me.lstAge.FormattingEnabled = True
        Me.lstAge.Items.AddRange(New Object() {"Child" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "£3.50", "Adult" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "£5.95", "OAP" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "£4.95"})
        Me.lstAge.Location = New System.Drawing.Point(12, 212)
        Me.lstAge.Name = "lstAge"
        Me.lstAge.Size = New System.Drawing.Size(133, 43)
        Me.lstAge.TabIndex = 20
        '
        'Rottenbeard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(999, 405)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnBuy)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.txtOAPTotal)
        Me.Controls.Add(Me.txtAdultTotal)
        Me.Controls.Add(Me.txtChildTotal)
        Me.Controls.Add(Me.lstAge)
        Me.Controls.Add(Me.btnMvSel)
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
    Friend WithEvents btnMvSel As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnBuy As Button
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents txtOAPTotal As TextBox
    Friend WithEvents txtAdultTotal As TextBox
    Friend WithEvents txtChildTotal As TextBox
    Friend WithEvents lstAge As ListBox
End Class
