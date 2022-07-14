Public Class Form1
    Private ZarAtis As Integer = 0
    Private Sub OynaBtn_Click(sender As Object, e As EventArgs) Handles OynaBtn.Click
        Dim rast As New Random
        Dim Zar1, Zar2 As Integer
        Zar1 = Rast.Next(1, 7)
        Zar2 = Rast.Next(1, 7)

        ZarAtis += 1
        ZarAtmaLbl.Text = ZarAtis

        Zar1PBox.Image = ZarlarList.Images(Zar1 - 1)
        Zar2PBox.Image = ZarlarList.Images(Zar2 - 1)
        If Zar1 = Zar2 And ZarAtis <= 3 Then
            Dim Mesaj As String = String.Format("Tebrikler {0} - {1} attınız ve KAZANDINIZ!", Zar1, Zar2)
            MessageBox.Show(Mesaj, "Oyun")
            ZarAtis = 0
            ZarAtmaLbl.Text = ZarAtis
            Zar1PBox.Image = Nothing
            Zar2PBox.Image = Nothing
        ElseIf ZarAtis >= 10 Then
            Dim Mesaj As String = String.Format("Üzgünüm {0} atışta hiç çift atamadınız ve KAYBETTİNİZ!", ZarAtis)
            MessageBox.Show(Mesaj, "Oyun")
            ZarAtis = 0
            ZarAtmaLbl.Text = ZarAtis
            Zar1PBox.Image = Nothing
            Zar2PBox.Image = Nothing
        End If
    End Sub
End Class
