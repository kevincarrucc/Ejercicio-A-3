Public Class Form1
    Private Sub Boton_Click(sender As Object, e As EventArgs) Handles Boton.Click
        Dim Dato, centena, decena, unidad, resto As Integer
        Dato = EntradaDato.Text
        centena = Dato \ 100
        resto = Dato Mod 100
        decena = resto \ 10
        unidad = Dato Mod 10
        NumCentena.Text = "La centena es " & centena
        NumDecena.Text = "La decena es " & decena
        NumUnidad.Text = "La unidad es " & unidad
    End Sub


End Class
