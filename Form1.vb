Public Class Form1
    Private Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click
        PictureBox1.Visible = False 'hide picture
        Label2.Text = CStr(Int(Rnd() * 10)) 'pick number
        Label3.Text = CStr(Int(Rnd() * 10))
        Label4.Text = CStr(Int(Rnd() * 10))
        ' if any number is 7 display picture and deep
        If (Label2.Text = "7") Or (Label3.Text = "7") _
            Or (Label4.Text = "7") Then
            PictureBox1.Visible = True
            Beep()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub
End Class
