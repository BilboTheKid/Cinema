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
        Me.lstBirdAge = New System.Windows.Forms.ListBox()
        Me.txtBirdChildTotal = New System.Windows.Forms.TextBox()
        Me.txtBirdAdultTotal = New System.Windows.Forms.TextBox()
        Me.txtBirdOAPTotal = New System.Windows.Forms.TextBox()
        Me.txtBirdTotalPrice = New System.Windows.Forms.TextBox()
        Me.btnBirdBuy = New System.Windows.Forms.Button()
        Me.btnBirdNew = New System.Windows.Forms.Button()
        CType(Me.ShkBirdemic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBirdDesc
        '
        Me.txtBirdDesc.Location = New System.Drawing.Point(3, 3)
        Me.txtBirdDesc.Name = "txtBirdDesc"
        Me.txtBirdDesc.Size = New System.Drawing.Size(289, 57)
        Me.txtBirdDesc.TabIndex = 0
        Me.txtBirdDesc.Text = "A horde of mutated birds descends upon the quiet town of Half Moon Bay, Californi" & _
    "a. With the death toll rising, Two citizens manage to fight back, but will they " & _
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
        Me.txtBirdInfo.Text = "IMDb Movie Rating: 1.8/10 " & Global.Microsoft.VisualBasic.ChrW(10) & "Director: James Nguyen" & Global.Microsoft.VisualBasic.ChrW(10) & "Stars: Alan Bagh, Whitney Moore" & _
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
        'lstBirdAge
        '
        Me.lstBirdAge.FormattingEnabled = True
        Me.lstBirdAge.Items.AddRange(New Object() {"Child" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "£3.50", "Adult" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "£5.95", "OAP" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "£4.95"})
        Me.lstBirdAge.Location = New System.Drawing.Point(3, 183)
        Me.lstBirdAge.Name = "lstBirdAge"
        Me.lstBirdAge.Size = New System.Drawing.Size(133, 43)
        Me.lstBirdAge.TabIndex = 5
        '
        'txtBirdChildTotal
        '
        Me.txtBirdChildTotal.Location = New System.Drawing.Point(3, 232)
        Me.txtBirdChildTotal.Name = "txtBirdChildTotal"
        Me.txtBirdChildTotal.ReadOnly = True
        Me.txtBirdChildTotal.Size = New System.Drawing.Size(133, 20)
        Me.txtBirdChildTotal.TabIndex = 7
        '
        'txtBirdAdultTotal
        '
        Me.txtBirdAdultTotal.Location = New System.Drawing.Point(3, 258)
        Me.txtBirdAdultTotal.Name = "txtBirdAdultTotal"
        Me.txtBirdAdultTotal.ReadOnly = True
        Me.txtBirdAdultTotal.Size = New System.Drawing.Size(133, 20)
        Me.txtBirdAdultTotal.TabIndex = 8
        '
        'txtBirdOAPTotal
        '
        Me.txtBirdOAPTotal.Location = New System.Drawing.Point(3, 284)
        Me.txtBirdOAPTotal.Name = "txtBirdOAPTotal"
        Me.txtBirdOAPTotal.ReadOnly = True
        Me.txtBirdOAPTotal.Size = New System.Drawing.Size(133, 20)
        Me.txtBirdOAPTotal.TabIndex = 9
        '
        'txtBirdTotalPrice
        '
        Me.txtBirdTotalPrice.Location = New System.Drawing.Point(142, 232)
        Me.txtBirdTotalPrice.Name = "txtBirdTotalPrice"
        Me.txtBirdTotalPrice.ReadOnly = True
        Me.txtBirdTotalPrice.Size = New System.Drawing.Size(150, 20)
        Me.txtBirdTotalPrice.TabIndex = 10
        '
        'btnBirdBuy
        '
        Me.btnBirdBuy.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBirdBuy.Location = New System.Drawing.Point(142, 258)
        Me.btnBirdBuy.Name = "btnBirdBuy"
        Me.btnBirdBuy.Size = New System.Drawing.Size(150, 46)
        Me.btnBirdBuy.TabIndex = 11
        Me.btnBirdBuy.Text = "Purchase"
        Me.btnBirdBuy.UseVisualStyleBackColor = False
        '
        'btnBirdNew
        '
        Me.btnBirdNew.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBirdNew.Location = New System.Drawing.Point(142, 183)
        Me.btnBirdNew.Name = "btnBirdNew"
        Me.btnBirdNew.Size = New System.Drawing.Size(150, 43)
        Me.btnBirdNew.TabIndex = 12
        Me.btnBirdNew.Text = "Add Person"
        Me.btnBirdNew.UseVisualStyleBackColor = False
        '
        'Birdemic_Shock_and_Terror
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(757, 309)
        Me.Controls.Add(Me.btnBirdNew)
        Me.Controls.Add(Me.btnBirdBuy)
        Me.Controls.Add(Me.txtBirdTotalPrice)
        Me.Controls.Add(Me.txtBirdOAPTotal)
        Me.Controls.Add(Me.txtBirdAdultTotal)
        Me.Controls.Add(Me.txtBirdChildTotal)
        Me.Controls.Add(Me.lstBirdAge)
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
    Friend WithEvents lstBirdAge As System.Windows.Forms.ListBox
    Friend WithEvents txtBirdChildTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtBirdAdultTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtBirdOAPTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtBirdTotalPrice As System.Windows.Forms.TextBox
    Friend WithEvents btnBirdBuy As System.Windows.Forms.Button
    Friend WithEvents btnBirdNew As System.Windows.Forms.Button
End Class
