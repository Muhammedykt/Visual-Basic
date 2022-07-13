Imports System.ComponentModel

Public Class Form1
    Dim SecilenFont As New System.Drawing.Text.PrivateFontCollection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = FormatDateTime(Today, DateFormat.LongDate)
        SaatLbl.Text = Now.ToLongTimeString

        SecilenFont.AddFontFile("Font\DigitalDream.ttf")
        SecilenFont.AddFontFile("Font\DigitaldreamFat.ttf")
        SecilenFont.AddFontFile("Font\DigitaldreamFatNarrow.ttf")
        SecilenFont.AddFontFile("Font\DigitaldreamFatSkew.ttf")
        SecilenFont.AddFontFile("Font\DigitaldreamFatSkewNarrow.ttf")
        SecilenFont.AddFontFile("Font\DigitaldreamNarrow.ttf")
        SecilenFont.AddFontFile("Font\DigitaldreamSkew.ttf")
        SecilenFont.AddFontFile("Font\DigitaldreamSkewNarrow.ttf")
        Dim Font As New System.Drawing.Font(SecilenFont.Families(1), SaatLbl.Font.Size)
        SaatLbl.Font = Font

        SureTimer.Interval = 1000 ' Daha uzun süreler için Gün*Saat*Dakika*Saniye*milisaniye 
        '5 dakika içi 5*60*1000
        SureTimer.Start() 'SureTimer.Enabled = True
    End Sub

    Private Sub SureTimer_Tick(sender As Object, e As EventArgs) Handles SureTimer.Tick
        Me.Text = FormatDateTime(Today, DateFormat.LongDate)
        SaatLbl.Text = Now.ToLongTimeString
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SureTimer.Stop() 'SureTimer.Enabled = False
    End Sub
End Class
