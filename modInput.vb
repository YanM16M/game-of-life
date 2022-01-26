Module modInput


    Public Sub HandleMouseUp(ByVal Button As Long, ByVal xClick As Long, ByVal yClick As Long)
        Dim x As Long, y As Long
        Dim MaxX As Long, MaxY As Long

        Call MoteurGraphique.Moteur.getTailleGrille(MaxX, MaxY)

        ' on récupère les coordonnées par rapport à la grille
        x = Math.Round(xClick / TAILLE_CELLULE)
        y = Math.Round(yClick / TAILLE_CELLULE)

        ' 2.6 = 3 alors qu'on veut 2
        ' donc si x ou y est > alors on enlève 1
        If x > xClick / TAILLE_CELLULE Then x = x - 1
        If y > yClick / TAILLE_CELLULE Then y = y - 1

        ' si la souris se trouve dans la grille
        If (x >= 0 And x <= MaxX) And (y >= 0 And y <= MaxY) Then

            ' on vérifie sur quel boutton on a appuyé
            If Button = MouseButtons.Left Then ' si on a appuyé sur le boutton gauche de la souris

                MoteurGraphique.Moteur.setEtatCellule(x, y, True) ' on sélectionne la cellule qu'on veut voir apparraître

            ElseIf Button = MouseButtons.Right Then ' si on a appuyé sur le boutton droit de la souris

                MoteurGraphique.Moteur.setEtatCellule(x, y, False)

            End If

        End If


    End Sub

End Module
