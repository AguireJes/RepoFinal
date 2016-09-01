Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncomenzar.Click
        Dim form2 As New Form2()
        form2.Show()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnDesarrolladores_Click(sender As Object, e As EventArgs) Handles btnDesarrolladores.Click
        Dim form3 As New Form3()
        form3.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
