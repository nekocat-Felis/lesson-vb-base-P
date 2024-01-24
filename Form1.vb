Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a : a = (-4.1 ^ 3.6 \ 1.2) * 2.9 + (353 Mod 6.5) : TextBox1.Text = a
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '2024124 nekocat-Felis 5-1
        TextBox1.Text = "2024124 nekocat-Felis"
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '2024124 nekocat-Felis 5-2
        Randomize()
        Dim a, b
        a = Int(Rnd() * 6 + 1)
        If a Mod 2 = 0 Then
            b = "偶"
        Else
            b = "奇"
        End If
        TextBox1.Text = b & "数"
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '2024124 nekocat-Felis 5-3
        Randomize()
        Dim a, b, c
        a = 2024124
        b = 0
        For n = 1 To a
            c = Int(Rnd() * 6 + 1)
            b = b + c
        Next n
        TextBox1.Text = b / a
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        '2024124 nekocat-Felis 5-4
        Randomize()
        Dim a, b, c, d
        a = 2024124
        b = 0
        c = 0
        Do While b < a
            c = c + 1
            d = Int(Rnd() * 6 + 1)
            b = b + d
        Loop
        TextBox1.Text = c
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        '2024124 nekocat-Felis 5-5
        Randomize()
        Dim a, b, c, d, f, g, h, i
        For n = 1 To 5
            a = Int(Rnd() * 6 + 1)

        Next n
    End Sub
End Class
