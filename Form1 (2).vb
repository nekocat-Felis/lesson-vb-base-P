Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = "2024124 nekocat-Felis"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = "2024124 nekocat-Felis"
        Dim a, b
        Randomize()
        a = 0
        For n = 1 To 150
            b = Int(Rnd() * 6 + 1)
            If b Mod 2 = 0 Then
                a = a + 1
            End If
        Next n
        TextBox2.Text = a
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a, b, c
        Randomize()
        a = 0
        b = 2024124
        For n = 1 To b
            c = Int(Rnd() * 6 + 1)
            a = a + c
        Next n
        a = a / b
        TextBox1.Text = a
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a, b, c
        a = 2024 - Val(TextBox1.Text)
        If a >= 18 Then
            If a >= 76 Then
                b = "老人"
            Else
                b = "大人"
            End If
        Else
            b = "子供"
        End If
        TextBox2.Text = b
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub
End Class
