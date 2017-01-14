<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Birdemic_Shock_and_Terror
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Birdemic_Shock_and_Terror))
        Me.txtBirdDesc = New System.Windows.Forms.RichTextBox()
        Me.lblBirdRate = New System.Windows.Forms.Label()
        Me.ShkBirdemic = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.txtBirdInfo = New System.Windows.Forms.RichTextBox()
        Me.lblBirdBook = New System.Windows.Forms.Label()
        Me.lstAge = New System.Windows.Forms.ListBox()
        Me.txtChildTotal = New System.Windows.Forms.TextBox()
        Me.txtAdultTotal = New System.Windows.Forms.TextBox()
        Me.txtOAPTotal = New System.Windows.Forms.TextBox()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.btnBuy = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnMvSel = New System.Windows.Forms.Button()
        CType(Me.ShkBirdemic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBirdDesc
        '
        Me.txtBirdDesc.Location = New System.Drawing.Point(3, 3)
        Me.txtBirdDesc.Name = "txtBirdDesc"
        Me.txtBirdDesc.Size = New System.Drawing.Size(289, 57)
        Me.txtBirdDesc.TabIndex = 0
        Me.txtBirdDesc.Text = "A horde of mutated birds descends upon the quiet town of Half Moon Bay, Californi" &
    "a. With the death toll rising, Two citizens manage to fight back, but will they " &
    "survive Birdemic?" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblBirdRate
        '
        Me.lblBirdRate.AutoSize = True
        Me.lblBirdRate.Location = New System.Drawing.Point(12, 63)
        Me.lblBirdRate.Name = "lblBirdRate"
        Me.lblBirdRate.Size = New System.Drawing.Size(25, 13)
        Me.lblBirdRate.TabIndex = 1
        Me.lblBirdRate.Text = "21+"
        '
        'ShkBirdemic
        '
        Me.ShkBirdemic.Enabled = True
        Me.ShkBirdemic.Location = New System.Drawing.Point(298, 3)
        Me.ShkBirdemic.Name = "ShkBirdemic"
        Me.ShkBirdemic.OcxState = CType(resources.GetObject("ShkBirdemic.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ShkBirdemic.Size = New System.Drawing.Size(457, 305)
        Me.ShkBirdemic.TabIndex = 2
        '
        'txtBirdInfo
        '
        Me.txtBirdInfo.Location = New System.Drawing.Point(3, 79)
        Me.txtBirdInfo.Name = "txtBirdInfo"
        Me.txtBirdInfo.Size = New System.Drawing.Size(289, 85)
        Me.txtBirdInfo.TabIndex = 3
        Me.txtBirdInfo.Text = "IMDb Movie Rating: 1.8/10 " & Global.Microsoft.VisualBasic.ChrW(10) & "Director: James Nguyen" & Global.Microsoft.VisualBasic.ChrW(10) & "Stars: Alan Bagh, Whitney Moore" &
    ", Tippi Hedren" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Screen: 2" & Global.Microsoft.VisualBasic.ChrW(10) & "Time: 11am "
        '
        'lblBirdBook
        '
        Me.lblBirdBook.AutoSize = True
        Me.lblBirdBook.Location = New System.Drawing.Point(12, 167)
        Me.lblBirdBook.Name = "lblBirdBook"
        Me.lblBirdBook.Size = New System.Drawing.Size(70, 13)
        Me.lblBirdBook.TabIndex = 4
        Me.lblBirdBook.Text = "Book Tickets"
        '
        'lstAge
        '
        Me.lstAge.FormattingEnabled = True
        Me.lstAge.Items.AddRange(New Object() {"Child" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "£3.50", "Adult" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "£5.95", "OAP" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "£4.95"})
        Me.lstAge.Location = New System.Drawing.Point(3, 183)
        Me.lstAge.Name = "lstAge"
        Me.lstAge.Size = New System.Drawing.Size(133, 43)
        Me.lstAge.TabIndex = 5
        '
        'txtChildTotal
        '
        Me.txtChildTotal.Location = New System.Drawing.Point(3, 232)
        Me.txtChildTotal.Name = "txtChildTotal"
        Me.txtChildTotal.ReadOnly = True
        Me.txtChildTotal.Size = New System.Drawing.Size(133, 20)
        Me.txtChildTotal.TabIndex = 7
        '
        'txtAdultTotal
        '
        Me.txtAdultTotal.Location = New System.Drawing.Point(3, 258)
        Me.txtAdultTotal.Name = "txtAdultTotal"
        Me.txtAdultTotal.ReadOnly = True
        Me.txtAdultTotal.Size = New System.Drawing.Size(133, 20)
        Me.txtAdultTotal.TabIndex = 8
        '
        'txtOAPTotal
        '
        Me.txtOAPTotal.Location = New System.Drawing.Point(3, 284)
        Me.txtOAPTotal.Name = "txtOAPTotal"
        Me.txtOAPTotal.ReadOnly = True
        Me.txtOAPTotal.Size = New System.Drawing.Size(133, 20)
        Me.txtOAPTotal.TabIndex = 9
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Location = New System.Drawing.Point(142, 232)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(150, 20)
        Me.txtTotalPrice.TabIndex = 10
        '
        'btnBuy
        '
        Me.btnBuy.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBuy.Location = New System.Drawing.Point(142, 258)
        Me.btnBuy.Name = "btnBuy"
        Me.btnBuy.Size = New System.Drawing.Size(150, 46)
        Me.btnBuy.TabIndex = 11
        Me.btnBuy.Text = "Purchase"
        Me.btnBuy.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnNew.Location = New System.Drawing.Point(142, 183)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(150, 43)
        Me.btnNew.TabIndex = 12
        Me.btnNew.Text = "Add Person"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnMvSel
        '
        Me.btnMvSel.Location = New System.Drawing.Point(3, 310)
        Me.btnMvSel.Name = "btnMvSel"
        Me.btnMvSel.Size = New System.Drawing.Size(75, 23)
        Me.btnMvSel.TabIndex = 13
        Me.btnMvSel.Text = "Back"
        Me.btnMvSel.UseVisualStyleBackColor = True
        '
        'Birdemic_Shock_and_Terror
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(757, 338)
        Me.Controls.Add(Me.btnMvSel)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnBuy)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.txtOAPTotal)
        Me.Controls.Add(Me.txtAdultTotal)
        Me.Controls.Add(Me.txtChildTotal)
        Me.Controls.Add(Me.lstAge)
        Me.Controls.Add(Me.lblBirdBook)
        Me.Controls.Add(Me.txtBirdInfo)
        Me.Controls.Add(Me.ShkBirdemic)
        Me.Controls.Add(Me.lblBirdRate)
        Me.Controls.Add(Me.txtBirdDesc)
        Me.Name = "Birdemic_Shock_and_Terror"
        Me.Text = "Birdemic_Shock_and_Terror"
        CType(Me.ShkBirdemic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBirdDesc As System.Windows.Forms.RichTextBox
    Friend WithEvents lblBirdRate As System.Windows.Forms.Label
    Friend WithEvents ShkBirdemic As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents txtBirdInfo As System.Windows.Forms.RichTextBox
    Friend WithEvents lblBirdBook As System.Windows.Forms.Label
    Friend WithEvents lstAge As System.Windows.Forms.ListBox
    Friend WithEvents txtChildTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtAdultTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtOAPTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalPrice As System.Windows.Forms.TextBox
    Friend WithEvents btnBuy As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnMvSel As Button
End Class
