Public Class Form1
    Private Sub RastgeleBtn_Click(sender As Object, e As EventArgs) Handles RastgeleBtn.Click
        Dim Rast As New Random
        Dim Ondalik As Double
        Dim Tam, Aralik As Integer
        Ondalik = Rast.NextDouble()
        Tam = Rast.Next()
        Aralik = Rast.Next() '1 ile 99 arasında sayılar üretir, 10 asla üretilmez
        OndalikTBox.Text = Ondalik
        TamTBox.Text = Tam
        AralikTBox.Text = Aralik
    End Sub
End Class
