Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '2024124 nekocat-Felis 
        Dim kai, n, d
        Randomize()
        kai = 0
        For n = 1 To 600 Step 1
            d = Int(Rnd() * 6 + 1)
            If d = 1 Then
                kai = kai + 1
            End If
        Next n
        TextBox1.Text = kai
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '2024124 nekocat-Felis 
        Dim kai, n, d
        Randomize()
        n = 0
        kai = 0
        Do While kai < 100
            n = n + 1
            d = Int(Rnd() * 6 + 1)
            If d = 1 Then
                kai = kai + 1
            End If
        Loop
        TextBox1.Text = n
    End Sub
End Class
