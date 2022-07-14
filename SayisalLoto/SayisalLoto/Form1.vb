Public Class Form1
    Private Sub OynaBtn_Click(sender As Object, e As EventArgs) Handles OynaBtn.Click
        Dim Rast As New Random
        Dim Sayilar(5) As Integer
        For i = 0 To Sayilar.Count - 1
            Dim Sayi As Integer = Rast.Next(1, 100)
            If Not Sayilar.Contains(Sayi) Then
                Sayilar(i) = Sayi
            Else
                i -= 1
            End If
        Next
        Array.Sort(Sayilar)
        For Each SayiLbl As Label In Me.Controls.OfType(Of Label)
            If IsNumeric(SayiLbl.Tag) Then
                SayiLbl.Text = Sayilar(SayiLbl.Tag)
            End If
        Next
        Dim SuperSayi As Integer = 0
        If SuperStarChBox.Checked Then
            SuperSayi = Rast.Next(1, 100)
        End If
        SuperStarLbl.Text = SuperSayi
    End Sub
End Class
