Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncomenzar.Click
        Dim form2 As New Form2()
        form2.Show()

        Dim cliente As Tratamientos = New Tratamientos("", 23, "M", 2888888)
        cliente.calcularCosto(ComboBoxTratamientos.SelectedItem, DateTimePickerEntrada.Text, DateTimePickerSalida.Text)



    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDesarrolladores_Click(sender As Object, e As EventArgs) Handles btnDesarrolladores.Click
        Dim form3 As New Form3()
        form3.Show()
    End Sub

End Class
