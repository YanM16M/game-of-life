Imports System.ComponentModel

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Main(True)
    End Sub

    Private Sub tmrGame_Tick(sender As Object, e As EventArgs) Handles tmrGame.Tick
        Call GameLoop()

        If Not FirstLoopDone And inGame Then
            FirstLoopDone = True
        End If

    End Sub



    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        ' on pose la question pour être sûr 
        If MsgBox("Voulez-vous vraiment quitter ?", vbYesNo, "Jeu de la vie") = vbYes Then
            End
        Else
            e.Cancel = True ' on annule la fermeture
        End If

    End Sub

    Private Sub frmMain_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp

        Call HandleMouseUp(e.Button, CLng(e.X), CLng(e.Y))

    End Sub

    Private Sub tmrDraw_Tick(sender As Object, e As EventArgs) Handles tmrDraw.Tick
        picGame.Invalidate()
    End Sub



    Private Sub picGame_Paint(sender As Object, e As PaintEventArgs) Handles picGame.Paint
        Call MoteurGraphique.DrawGame(e)
    End Sub
End Class
