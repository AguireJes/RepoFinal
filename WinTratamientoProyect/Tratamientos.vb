Public Class Tratamientos

    Dim nombre As String
    Dim edad As Integer
    Dim tratamiento As Char
    Dim internacion As Integer
    Dim telefono As Integer
    Dim sexo As String
    Dim total As Double
    Dim itbms As Double
    Dim descuento As Double
    Dim neto As Double

    Sub New(ByVal _nombre As String, ByVal _edad As Integer, ByVal _sexo As String, ByVal _telefono As Integer)
        nombre = _nombre
        edad = _edad
        sexo = _sexo
        telefono = _telefono
    End Sub

    Sub calcularCosto(ByVal _tratamiento As Char, ByVal i_entrada As Date, ByVal i_salida As Date)
        tratamiento = _tratamiento
        internacion = i_salida.Day - i_entrada.Day

        Select Case _tratamiento
            Case "A"
                total = internacion * 280
            Case "B"
                total = internacion * 195
            Case "C"
                total = internacion * 250
        End Select

        calcularITBMS()
        calcularDescuento()
        calcularNeto()

    End Sub

    Private Sub calcularITBMS()
        itbms = total * 0.07
    End Sub

    Private Sub calcularDescuento()
        If edad >= 60 And edad <= 110 Then
            descuento = (total + itbms) * 0.25
        ElseIf edad <= 25 Then
            descuento = (total + itbms) * 0.15
        Else
            descuento = 0
        End If
    End Sub

    Private Sub calcularNeto()
        neto = total + itbms - descuento
    End Sub


End Class
