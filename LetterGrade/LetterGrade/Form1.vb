Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim score As Double
        score = TextBox1.Text
        Select Case score
            Case 90 To 100
                TextBox2.Text = "A"
            Case 80 To 90
                TextBox2.Text = "B"
            Case 70 To 80
                TextBox2.Text = "C"

        End Select



    End Sub
End Class
