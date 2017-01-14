Public Class Admin
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBirdRev.Text = BirdRevenue
        txtBoogRev.Text = BoogalooRevenue
        txtHonRev.Text = HoneyRevenue
        txtRotRev.Text = RottenRevenue
        txtSantaRev.Text = SantaRevenue
        txtWeRev.Text = NumberRevenue
    End Sub
End Class