<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Movie_select
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Movie_select))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstSelect = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select the movie you wish to watch"
        '
        'lstSelect
        '
        Me.lstSelect.FormattingEnabled = True
        Me.lstSelect.Items.AddRange(New Object() {"Birdemic: Shock and Terror", "We Are Number One but Every One is Replaced by Prince Charming Dying, Each Time W" & _
                "ith More Distortion", "Santa Claus Conquers the Martians", "Pirates of the Carribean: Rottenbeard and the Net", "Heil Honey i'm Home", "Breakin' 2: Electric Boogaloo", " "})
        Me.lstSelect.Location = New System.Drawing.Point(12, 25)
        Me.lstSelect.Name = "lstSelect"
        Me.lstSelect.Size = New System.Drawing.Size(536, 82)
        Me.lstSelect.TabIndex = 2
        '
        'Movie_select
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(564, 109)
        Me.Controls.Add(Me.lstSelect)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Movie_select"
        Me.Text = "Movie_select"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstSelect As System.Windows.Forms.ListBox
End Class
