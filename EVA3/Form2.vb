Public Class Form2
    Private Sub BTINGRESARcliente_Click(sender As Object, e As EventArgs) Handles BTINGRESARcliente.Click

    End Sub

    Private Sub Btvolver_Click(sender As Object, e As EventArgs) Handles Btvolver.Click
        Dim form2 As New Form5()
        Form1.Show()
        Me.Hide()
    End Sub
End Class