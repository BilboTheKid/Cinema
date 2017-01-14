<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Santa_Claus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Santa_Claus))
        Me.txtsanta = New System.Windows.Forms.RichTextBox()
        Me.shkSantaTrailer = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.lblSanta = New System.Windows.Forms.Label()
        Me.txtSantaInfo = New System.Windows.Forms.RichTextBox()
        Me.lblSantaBook = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnBuy = New System.Windows.Forms.Button()
        Me.lstAge = New System.Windows.Forms.ListBox()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.txtOAPTotal = New System.Windows.Forms.TextBox()
        Me.txtChildTotal = New System.Windows.Forms.TextBox()
        Me.txtAdultTotal = New System.Windows.Forms.TextBox()
        Me.btnMvSel = New System.Windows.Forms.Button()
        CType(Me.shkSantaTrailer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtsanta
        '
        Me.txtsanta.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtsanta.Location = New System.Drawing.Point(12, 12)
        Me.txtsanta.Name = "txtsanta"
        Me.txtsanta.Size = New System.Drawing.Size(300, 48)
        Me.txtsanta.TabIndex = 0
        Me.txtsanta.Text = "The Martians kidnap Santa Claus because there is nobody on Mars to give their chi" &
    "ldren presents." & Global.Microsoft.VisualBasic.ChrW(10) & "Guest starring joseph Stalin " & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'shkSantaTrailer
        '
        Me.shkSantaTrailer.Enabled = True
        Me.shkSantaTrailer.Location = New System.Drawing.Point(318, 12)
        Me.shkSantaTrailer.Name = "shkSantaTrailer"
        Me.shkSantaTrailer.OcxState = CType(resources.GetObject("shkSantaTrailer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.shkSantaTrailer.Size = New System.Drawing.Size(540, 343)
        Me.shkSantaTrailer.TabIndex = 1
        '
        'lblSanta
        '
        Me.lblSanta.AutoSize = True
        Me.lblSanta.Location = New System.Drawing.Point(12, 63)
        Me.lblSanta.Name = "lblSanta"
        Me.lblSanta.Size = New System.Drawing.Size(15, 13)
        Me.lblSanta.TabIndex = 2
        Me.lblSanta.Text = "U"
        '
        'txtSantaInfo
        '
        Me.txtSantaInfo.Location = New System.Drawing.Point(12, 79)
        Me.txtSantaInfo.Name = "txtSantaInfo"
        Me.txtSantaInfo.Size = New System.Drawing.Size(300, 101)
        Me.txtSantaInfo.TabIndex = 4
        Me.txtSantaInfo.Text = "IMDb Movie Rating: 2.5/10 " & Global.Microsoft.VisualBasic.ChrW(10) & "Director: Nicholas Webster" & Global.Microsoft.VisualBasic.ChrW(10) & "Stars: John Call, Leonard H" &
    "icks, Vincent Beck" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Screen: 2" & Global.Microsoft.VisualBasic.ChrW(10) & "Time: 8:30pm "
        '
        'lblSantaBook
        '
        Me.lblSantaBook.AutoSize = True
        Me.lblSantaBook.Location = New System.Drawing.Point(12, 183)
        Me.lblSantaBook.Name = "lblSantaBook"
        Me.lblSantaBook.Size = New System.Drawing.Size(63, 13)
        Me.lblSantaBook.TabIndex = 5
        Me.lblSantaBook.Text = "Buy Tickets"
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnNew.Location = New System.Drawing.Point(170, 199)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(142, 43)
        Me.btnNew.TabIndex = 6
        Me.btnNew.Text = "Add Ticket"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnBuy
        '
        Me.btnBuy.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBuy.Location = New System.Drawing.Point(170, 272)
        Me.btnBuy.Name = "btnBuy"
        Me.btnBuy.Size = New System.Drawing.Size(142, 46)
        Me.btnBuy.TabIndex = 7
        Me.btnBuy.Text = "Purchase"
        Me.btnBuy.UseVisualStyleBackColor = False
        '
        'lstAge
        '
        Me.lstAge.FormattingEnabled = True
        Me.lstAge.Items.AddRange(New Object() {"Child" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "£3.50", "Adult" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "£5.95", "OAP" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "£4.95"})
        Me.lstAge.Location = New System.Drawing.Point(12, 199)
        Me.lstAge.Name = "lstAge"
        Me.lstAge.Size = New System.Drawing.Size(152, 43)
        Me.lstAge.TabIndex = 8
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Location = New System.Drawing.Point(170, 248)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(142, 20)
        Me.txtTotalPrice.TabIndex = 9
        '
        'txtOAPTotal
        '
        Me.txtOAPTotal.Location = New System.Drawing.Point(12, 298)
        Me.txtOAPTotal.Name = "txtOAPTotal"
        Me.txtOAPTotal.ReadOnly = True
        Me.txtOAPTotal.Size = New System.Drawing.Size(152, 20)
        Me.txtOAPTotal.TabIndex = 10
        '
        'txtChildTotal
        '
        Me.txtChildTotal.Location = New System.Drawing.Point(12, 248)
        Me.txtChildTotal.Name = "txtChildTotal"
        Me.txtChildTotal.ReadOnly = True
        Me.txtChildTotal.Size = New System.Drawing.Size(152, 20)
        Me.txtChildTotal.TabIndex = 11
        '
        'txtAdultTotal
        '
        Me.txtAdultTotal.Location = New System.Drawing.Point(12, 272)
        Me.txtAdultTotal.Name = "txtAdultTotal"
        Me.txtAdultTotal.ReadOnly = True
        Me.txtAdultTotal.Size = New System.Drawing.Size(152, 20)
        Me.txtAdultTotal.TabIndex = 12
        '
        'btnMvSel
        '
        Me.btnMvSel.Location = New System.Drawing.Point(12, 324)
        Me.btnMvSel.Name = "btnMvSel"
        Me.btnMvSel.Size = New System.Drawing.Size(75, 23)
        Me.btnMvSel.TabIndex = 14
        Me.btnMvSel.Text = "Back"
        Me.btnMvSel.UseVisualStyleBackColor = True
        '
        'Santa_Claus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(858, 357)
        Me.Controls.Add(Me.btnMvSel)
        Me.Controls.Add(Me.txtAdultTotal)
        Me.Controls.Add(Me.txtChildTotal)
        Me.Controls.Add(Me.txtOAPTotal)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.lstAge)
        Me.Controls.Add(Me.btnBuy)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.lblSantaBook)
        Me.Controls.Add(Me.txtSantaInfo)
        Me.Controls.Add(Me.lblSanta)
        Me.Controls.Add(Me.shkSantaTrailer)
        Me.Controls.Add(Me.txtsanta)
        Me.Name = "Santa_Claus"
        Me.Text = "Santa_Claus"
        CType(Me.shkSantaTrailer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtsanta As System.Windows.Forms.RichTextBox
    Friend WithEvents shkSantaTrailer As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents lblSanta As System.Windows.Forms.Label
    Friend WithEvents txtSantaInfo As System.Windows.Forms.RichTextBox
    Friend WithEvents lblSantaBook As System.Windows.Forms.Label
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnBuy As System.Windows.Forms.Button
    Friend WithEvents lstAge As System.Windows.Forms.ListBox
    Friend WithEvents txtTotalPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtOAPTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtChildTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtAdultTotal As System.Windows.Forms.TextBox
    Friend WithEvents btnMvSel As Button
End Class
