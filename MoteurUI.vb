Public Class MoteurUI
    Public Moteur As New Moteur(64, 50)

    Public Sub DrawGame(e As PaintEventArgs)

        ' ######################
        ' ## GRAPHIQUES DU JEU 
        ' ######################

        Call DrawGrid(e)
        Call DrawCellules(e)

    End Sub

    Public Sub DrawLine(e As PaintEventArgs, ByVal x As Long, ByVal y As Long, ByVal size As Byte)
        Dim myGraphics As Graphics = e.Graphics
        Dim OurPen As Pen

        OurPen = New Pen(Brushes.Black, 20)
        myGraphics.DrawLine(OurPen, 20, 25, 40, 45)
    End Sub

    Public Sub DrawGrid(e As PaintEventArgs)
        Dim MaxX As Long, MaxY As Long
        Dim myGraphics As Graphics = e.Graphics
        Dim OurPen As Pen

        OurPen = New Pen(Brushes.DarkGray, 1)

        Call Moteur.getTailleGrille(MaxX, MaxY)

        ' on dessine les lignes de la grille verticalement
        For x = 0 To MaxX
            myGraphics.DrawLine(OurPen, x * TAILLE_CELLULE, 0, x * TAILLE_CELLULE, frmMain.Height)
        Next

        ' on dessine les lignes de la grille horizontalement
        For y = 0 To MaxY
            myGraphics.DrawLine(OurPen, 0, y * TAILLE_CELLULE, frmMain.Width, y * TAILLE_CELLULE)
        Next

    End Sub

    ' on dessine les cellules du jeu
    Public Sub DrawCellules(e As PaintEventArgs)
        Dim MaxX As Long, MaxY As Long
        Dim myGraphics As Graphics = e.Graphics

        Call Moteur.getTailleGrille(MaxX, MaxY)

        ' on dessine les cellules vivantes
        For x = 0 To MaxX
            For y = 0 To MaxY

                If Moteur.getEtatCellule(x, y) Then
                    Call DrawCellule(x, y, False) 'cellule vivante
                Else
                    Call DrawCellule(x, y, True) ' cellule morte
                End If

            Next
        Next

    End Sub

    Public Sub DrawCellule(ByVal x As Integer, ByVal y As Integer, ByVal isDead As Boolean, Optional ByVal Preview As Boolean = False)
        Dim myGraphics As Graphics = frmMain.CreateGraphics

        If Not Preview Then
            If Not isDead Then
                myGraphics.FillRectangle(Brushes.Black, x * TAILLE_CELLULE + 1, y * TAILLE_CELLULE + 1, TAILLE_CELLULE - 2, TAILLE_CELLULE - 2)
            Else
                myGraphics.FillRectangle(Brushes.White, x * TAILLE_CELLULE + 1, y * TAILLE_CELLULE + 1, TAILLE_CELLULE - 2, TAILLE_CELLULE - 2)
            End If
        Else
            myGraphics.FillRectangle(Brushes.Red, x * TAILLE_CELLULE, y * TAILLE_CELLULE, TAILLE_CELLULE, TAILLE_CELLULE)
        End If

    End Sub
End Class
