Public Class frmStart
    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        End ' on stop le programme
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Call Main(True)
        Me.Visible = False   ' on ferme la fenêtre de lancement
    End Sub

    Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class