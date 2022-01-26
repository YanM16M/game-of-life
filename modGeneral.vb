Module modGeneral

    Public MoteurGraphique As New MoteurUI

    Public Sub Main(Optional ByVal ByMenuStart As Boolean = False)

        FirstLoopDone = False

        MoteurGraphique = New MoteurUI

        ' on initialise les règles de vie et de mort
        MoteurGraphique.Moteur.setRegle(2, 3, 3, 3)

        ' On initialise les paramètres de la form principale
        Call initialiseForm()

        frmMain.picGame.Location = New Point(0, 0)
        frmMain.picGame.Width = frmMain.Width
        frmMain.picGame.Height = frmMain.Height

        ' on active le timer qui dessine le jeu
        frmMain.tmrDraw.Enabled = True
        frmMain.tmrGame.Enabled = False

        ' On initialise les paramètres du jeu
        Call initialiseGame(ByMenuStart)

    End Sub

    Public Sub GameLoop()


        If inGame Then
            ' t + 1 
            If FirstLoopDone Then ' à partir de la 2eme génération
                Call checkCurrentGeneration() ' on vérifie les cellule
            End If
        End If


    End Sub

    Public Sub initialiseForm()

        ' on affiche la fenêtre
        frmControle.Show()

        ' On modifie la form
        With frmMain
            ' on change le nom
            .Text = "Jeu de la vie"

        End With


    End Sub

    Public Sub resizeGame()
        Dim Width As Long, Height As Long

        ' on clear les graphismes
        frmMain.CreateGraphics.Clear(Color.White)

        ' on change la taille de la fenêtre principale
        Call MoteurGraphique.Moteur.setTailleGrille(frmControle.scrlTailleX.Value * 2, frmControle.scrlTailleY.Value * 2)
        Call MoteurGraphique.Moteur.getTailleGrille(Width, Height)

        TAILLE_CELLULE = frmControle.scrlTailleCellule.Value * 2
        frmMain.Width = Width * TAILLE_CELLULE
        frmMain.Height = Height * TAILLE_CELLULE

        ' si on était en jeu // relance une partie
        If inGame Then
            Call initialiseGame()
        End If

    End Sub

    Public Sub generateRandomCase()
        Dim MaxX As Long, MaxY As Long
        Dim x As Integer, y As Integer

        Call MoteurGraphique.Moteur.getTailleGrille(MaxX, MaxY)

        ' on fait appraître ##frmControle.scrlCellule.Value## cellules
        For i = 1 To frmControle.scrlCellule.Value

            x = random(1, MaxX) ' coordonnées x de la cellule
            y = random(1, MaxY)  ' coordonnées y de la cellule

            Call MoteurGraphique.Moteur.setEtatCellule(x, y, True) ' la cellule est vivante

            ' on génère des voisins
            Dim nbrVoisin As Byte = frmControle.scrlVCellule.Value 'Int(Rnd() * 4 + 1)
            Dim x2 As Integer, y2 As Integer

            ' pour chaque case autour de la cellule
            For x2 = x - 1 To x + 1
                For y2 = y - 1 To y + 1
                    If nbrVoisin > 0 Then ' si on doit faire appraître des voisins
                        If (x2 >= 0 And x2 <= MaxX) And (y2 >= 0 And y2 <= MaxY) Then ' si le voisin se trouve dans les limites de la grille

                            If (x2 <> x) Or (y2 <> y) Then ' si différend de x et y

                                If random(1, frmControle.scrlVChance.Value) = 1 Then ' 1 chance sur frmControle.scrlVChance.Value
                                    Call MoteurGraphique.Moteur.setEtatCellule(x2, y2, True)
                                    nbrVoisin = nbrVoisin - 1
                                End If

                            End If

                        End If
                    End If
                Next
            Next

        Next

    End Sub

    Public Sub initialiseGame(Optional ByVal byMenuStart As Boolean = False)

        FirstLoopDone = False
        generationCount = 0
        frmMain.lblGeneration.Text = generationCount ' affiche le nombre de génération de cellules

        ' on paramètres les forms
        If byMenuStart Then Call resizeGame() ' on resize seulement à la première ouverture
        frmMain.Show()


        ' on génère les cellules
        If Not byMenuStart Then ' pas au lancement de la fenêtre
            If frmControle.chkRandom.Checked Then 'si la checkbox aléatoire est coché
                Call generateRandomCase() 'aléatoire
            End If
        End If


        ' on active le timer
        If Not byMenuStart Then frmMain.tmrGame.Enabled = True
        frmControle.btnStart.Enabled = False
        frmControle.btnPause.Enabled = True

        ' on place la fenêtre des paramètres juste à côté de la fenêtre principale
        frmControle.Location = New Point(frmMain.Location.X + frmMain.Width + 20, frmMain.Location.Y)

    End Sub

    Public Sub CancelGame()

        ' on clear la grille
        Call clearGame()
        inGame = False

        ' on arrête le timer
        frmMain.tmrGame.Enabled = False
        frmControle.btnStart.Enabled = False
        frmControle.btnPause.Enabled = True

        ' on remet à 0 les générations
        generationCount = 0
        frmMain.lblGeneration.Text = generationCount

    End Sub

    Public Sub clearGame()
        Dim MaxX As Long, MaxY As Long
        Dim x As Integer, y As Integer

        Call MoteurGraphique.Moteur.getTailleGrille(MaxX, MaxY)

        ' on clear les graphismes
        frmMain.CreateGraphics.Clear(Color.White)

        ' Pour chaque cellule du tableau
        For x = 0 To MaxX
            For y = 0 To MaxY
                Call MoteurGraphique.Moteur.setEtatCellule(x, y, False) ' on la vide
            Next
        Next


    End Sub

    Public Sub checkCurrentGeneration()
        Dim isChanged As Boolean = False

        Call MoteurGraphique.Moteur.etatSuivant(isChanged)

        ' si il y'a eu du changement
        If isChanged Then
            generationCount = generationCount + 1 ' on incrémente le nombre de génération
            frmMain.lblGeneration.Text = generationCount ' on l'affiche sur la fenêtre principale
        End If

    End Sub

    Function random(ByVal min As Long, ByVal max As Long)

        Randomize()

        random = Int(Rnd() * max + min)

    End Function



End Module
