Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncomenzar.Click
        Dim form2 As New Form2()
        Dim edad As Integer = NumericUpDownEdad.Value

        If (edad >= 60) Then
            'Restale el 25% al precio del tratamiento escogido
        ElseIf (edad <= 25 And edad >= 18) Then
            'Restale el 15% al precio del tratamiento escogido
        End If

        form2.Show()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnDesarrolladores_Click(sender As Object, e As EventArgs) Handles btnDesarrolladores.Click
        Dim form3 As New Form3()
        form3.Show()
    End Sub

    Private Sub NumericUpDownEdad_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownEdad.ValueChanged

    End Sub
End Class
