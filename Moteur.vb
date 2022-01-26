Public Class Moteur
    ' Graphique du jeu
    Private MaxX As Long, MaxY As Long
    Private Cellule(,) As Boolean
    ' Règles du jeu
    Private minMort As Long, maxMort As Long, minNaissance As Long, maxNaissance As Long

    '##########################
    '##### Grille
    '##########################
    Public Sub getTailleGrille(ByRef n As Long, ByRef m As Long)
        n = MaxX
        m = MaxY
    End Sub

    Public Sub setTailleGrille(ByVal n As Long, ByVal m As Long)

        MaxX = n
        MaxY = m

        ReDim Cellule(0 To MaxX, 0 To MaxY)

    End Sub


    Public Function getMaxX() As Long
        getMaxX = MaxX
    End Function

    Public Function getMaxY() As Long
        getMaxY = MaxY
    End Function

    '##########################
    '##### Game
    '##########################

    Public Function getNumerOfNeighbour(ByVal x1 As Integer, ByVal y1 As Integer)
        Dim x2 As Integer, y2 As Integer
        Dim x3 As Integer, y3 As Integer
        ' fonction qui récupère le nombre de cellule voisine
        getNumerOfNeighbour = 0

        ' on a passé en argument la position de la cellule à qui on veut obtenir le nombre de voisin
        ' x1: position de la cellule en x
        ' y1: position de la celuule en y

        ' on regarde autour de la cellule
        For x2 = x1 - 1 To x1 + 1
            For y2 = y1 - 1 To y1 + 1

                ' effet miroir
                If x2 > MaxX Then
                    x3 = 0
                ElseIf x2 < 0 Then
                    x3 = MaxX
                Else
                    x3 = x2
                End If

                If y2 > MaxY Then
                    y3 = 0
                ElseIf y2 < 0 Then
                    y3 = MaxY
                Else
                    y3 = y2
                End If
                ' effet miroir : fin

                If (x3 >= 0 And x3 <= MaxX) And (y3 >= 0 And y3 <= MaxY) Then ' on vérifie que les positions se trouvent dans la grille
                    If (x3 <> x1) Or (y3 <> y1) Then ' on vérifie qu'on ne compte pas la cellule principale
                        If getEtatCellule(x3, y3) Then ' si la cellule est vivante
                            getNumerOfNeighbour = getNumerOfNeighbour + 1 ' on incrémente le nombre de voisin
                        End If
                    End If
                End If

            Next
        Next

    End Function

    Public Sub etatSuivant(Optional ByRef isChanged As Boolean = False)
        Dim tableauVoisin(,)

        isChanged = False
        ReDim tableauVoisin(0 To MaxX, 0 To MaxY)

        ' on récupère le nombre de voison pour chaque cellule
        For x = 0 To MaxX
            For y = 0 To MaxY

                tableauVoisin(x, y) = getNumerOfNeighbour(x, y) ' on stocke le nombre de voisin pour chaque cellule

            Next
        Next

        ' on regarde si une cellule doit rester vivante, mourir ou nâitre
        For x = 0 To MaxX
            For y = 0 To MaxY

                If Cellule(x, y) Then ' si la cellule est vivante

                    If tableauVoisin(x, y) < minMort Then ' si la cellule est entouré de moins de minMort voisins alors la cellule meurt

                        Call setEtatCellule(x, y, False) ' on fait mourir la cellule
                        isChanged = True

                    ElseIf tableauVoisin(x, y) > maxMort Then ' si la cellule est entouré par plus de MaxMort cellules alors la cellule meurt

                        Call setEtatCellule(x, y, False) ' on fait mourir la cellule
                        isChanged = True

                    End If

                Else ' si la cellule est morte

                    If tableauVoisin(x, y) >= minNaissance And tableauVoisin(x, y) <= maxNaissance Then

                        Call setEtatCellule(x, y, True) ' on fait naître la cellule
                        isChanged = True

                    End If

                End If

            Next
        Next

    End Sub

    Public Sub setRegle(ByVal minimumMort As Long, ByVal maximumMort As Long, ByVal minimumNaissance As Long, ByVal maximumNaissance As Long)

        ' on change les règles
        minMort = minimumMort
        maxMort = maximumMort
        minNaissance = minimumNaissance
        maxNaissance = maximumNaissance

    End Sub

    Public Sub setEtatCellule(ByVal x As Long, ByVal y As Long, ByVal Etat As Boolean)

        ' si les coordonnées x et y se trouve dans les limites du tableau
        If (x >= 0 And x <= MaxX) And (y >= 0 And y <= MaxY) Then
            Cellule(x, y) = Etat
        End If

    End Sub

    Public Function getEtatCellule(ByVal x As Long, ByVal y As Long) As Boolean

        ' si les coordonnées x et y se trouve dans les limites du tableau
        If (x >= 0 And x <= MaxX) And (y >= 0 And y <= MaxY) Then
            getEtatCellule = Cellule(x, y)
        End If

    End Function

    Public Function getMinMort() As Long
        getMinMort = minMort
    End Function

    Public Function getMaxMort() As Long
        getMaxMort = maxMort
    End Function

    Public Function getMinNaissance() As Long
        getMinNaissance = minNaissance
    End Function

    Public Function getMaxNaissance() As Long
        getMaxNaissance = maxNaissance
    End Function
End Class
