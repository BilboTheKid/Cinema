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
        Me.btnSantaNew = New System.Windows.Forms.Button()
        Me.btnSantaBuy = New System.Windows.Forms.Button()
        Me.lstSantaAge = New System.Windows.Forms.ListBox()
        Me.txtSantaTotalPrice = New System.Windows.Forms.TextBox()
        Me.txtSantaOAPTotal = New System.Windows.Forms.TextBox()
        Me.txtSantaChildTotal = New System.Windows.Forms.TextBox()
        Me.txtSantaAdultTotal = New System.Windows.Forms.TextBox()
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
        'btnSantaNew
        '
        Me.btnSantaNew.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSantaNew.Location = New System.Drawing.Point(170, 199)
        Me.btnSantaNew.Name = "btnSantaNew"
        Me.btnSantaNew.Size = New System.Drawing.Size(142, 43)
        Me.btnSantaNew.TabIndex = 6
        Me.btnSantaNew.Text = "Add Ticket"
        Me.btnSantaNew.UseVisualStyleBackColor = False
        '
        'btnSantaBuy
        '
        Me.btnSantaBuy.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSantaBuy.Location = New System.Drawing.Point(170, 272)
        Me.btnSantaBuy.Name = "btnSantaBuy"
        Me.btnSantaBuy.Size = New System.Drawing.Size(142, 46)
        Me.btnSantaBuy.TabIndex = 7
        Me.btnSantaBuy.Text = "Purchase"
        Me.btnSantaBuy.UseVisualStyleBackColor = False
        '
        'lstSantaAge
        '
        Me.lstSantaAge.FormattingEnabled = True
        Me.lstSantaAge.Items.AddRange(New Object() {"Child" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "£3.50", "Adult" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "£5.95", "OAP" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "£4.95"})
        Me.lstSantaAge.Location = New System.Drawing.Point(12, 199)
        Me.lstSantaAge.Name = "lstSantaAge"
        Me.lstSantaAge.Size = New System.Drawing.Size(152, 43)
        Me.lstSantaAge.TabIndex = 8
        '
        'txtSantaTotalPrice
        '
        Me.txtSantaTotalPrice.Location = New System.Drawing.Point(170, 248)
        Me.txtSantaTotalPrice.Name = "txtSantaTotalPrice"
        Me.txtSantaTotalPrice.ReadOnly = True
        Me.txtSantaTotalPrice.Size = New System.Drawing.Size(142, 20)
        Me.txtSantaTotalPrice.TabIndex = 9
        '
        'txtSantaOAPTotal
        '
        Me.txtSantaOAPTotal.Location = New System.Drawing.Point(12, 298)
        Me.txtSantaOAPTotal.Name = "txtSantaOAPTotal"
        Me.txtSantaOAPTotal.ReadOnly = True
        Me.txtSantaOAPTotal.Size = New System.Drawing.Size(152, 20)
        Me.txtSantaOAPTotal.TabIndex = 10
        '
        'txtSantaChildTotal
        '
        Me.txtSantaChildTotal.Location = New System.Drawing.Point(12, 248)
        Me.txtSantaChildTotal.Name = "txtSantaChildTotal"
        Me.txtSantaChildTotal.ReadOnly = True
        Me.txtSantaChildTotal.Size = New System.Drawing.Size(152, 20)
        Me.txtSantaChildTotal.TabIndex = 11
        '
        'txtSantaAdultTotal
        '
        Me.txtSantaAdultTotal.Location = New System.Drawing.Point(12, 272)
        Me.txtSantaAdultTotal.Name = "txtSantaAdultTotal"
        Me.txtSantaAdultTotal.ReadOnly = True
        Me.txtSantaAdultTotal.Size = New System.Drawing.Size(152, 20)
        Me.txtSantaAdultTotal.TabIndex = 12
        '
        'Santa_Claus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(858, 327)
        Me.Controls.Add(Me.txtSantaAdultTotal)
        Me.Controls.Add(Me.txtSantaChildTotal)
        Me.Controls.Add(Me.txtSantaOAPTotal)
        Me.Controls.Add(Me.txtSantaTotalPrice)
        Me.Controls.Add(Me.lstSantaAge)
        Me.Controls.Add(Me.btnSantaBuy)
        Me.Controls.Add(Me.btnSantaNew)
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
    Friend WithEvents btnSantaNew As System.Windows.Forms.Button
    Friend WithEvents btnSantaBuy As System.Windows.Forms.Button
    Friend WithEvents lstSantaAge As System.Windows.Forms.ListBox
    Friend WithEvents txtSantaTotalPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtSantaOAPTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtSantaChildTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtSantaAdultTotal As System.Windows.Forms.TextBox
End Class
