Imports System.ComponentModel

Public Class frmControle
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        frmMain.tmrGame.Enabled = True ' on re-lance le timer
        btnStart.Enabled = False
        btnPause.Enabled = True
    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        frmMain.tmrGame.Enabled = False ' on arrête le timer
        btnStart.Enabled = True ' on active le boutton pour re-lancer le boutton
        btnPause.Enabled = False
    End Sub

    Private Sub txtTimer_TextChanged(sender As Object, e As EventArgs) Handles txtTimer.TextChanged
        Dim lastInterval As Long

        ' on vérifie que la textbox ne soit pas vide
        If Trim$(txtTimer.Text) = vbNullString Then
            txtTimer.Text = "1000"
            Exit Sub
        End If

        lastInterval = frmMain.tmrGame.Interval ' on sauvegarde l'ancien timer pour le ré-utiliser

        ' on vérifie que le texte entrée est un nombre
        If Not IsNumeric(Trim(txtTimer.Text)) Then
            txtTimer.Text = lastInterval
        End If

        ' l'interval ne peut pas être inférieur à 1
        If Trim$(txtTimer.Text) < 1 Then
            txtTimer.Text = 1
        End If

        ' on modifie l'interval du timer
        frmMain.tmrGame.Interval = Trim$(txtTimer.Text)

    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click

        If inGame Then ' si le jeu n'est pas arrêter manuellement
            Call MsgBox("Vous devez arrêter le jeu avant de lancer une nouvelle partie", vbYes, "Jeu de la vie")
            Exit Sub
        End If

        btnRestart.Enabled = False
        Call initialiseGame()
        inGame = True
    End Sub

    Private Sub scrlCellule_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlCellule.Scroll
        lblCellule.Text = "Nbr de cellules : " & scrlCellule.Value
    End Sub

    Private Sub scrlVCellule_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlVCellule.Scroll
        lblVCellule.Text = "Nbr de voisins par cellule : " & scrlVCellule.Value
    End Sub

    Private Sub scrlVChance_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlVChance.Scroll
        lblVChance.Text = "Chance d'apparition des voisins : 1 sur " & scrlVChance.Value
    End Sub

    Private Sub frmControle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' on paramètres les scrollbars
        scrlCellule.Value = 4
        scrlVCellule.Value = 3
        scrlVCellule.Maximum = 8
        scrlVChance.Value = 1
        txtTimer.Text = "1"

        ' règles
        scrlMinMort.Value = MoteurGraphique.Moteur.getMinMort
        scrlMaxMort.Value = MoteurGraphique.Moteur.getMaxMort
        scrlMinNaissance.Value = MoteurGraphique.Moteur.getMinNaissance
        scrlMaxNaissance.Value = MoteurGraphique.Moteur.getMaxNaissance


    End Sub

    Private Sub scrlVChance_ValueChanged(sender As Object, e As EventArgs) Handles scrlVChance.ValueChanged
        lblVChance.Text = "Chance d'apparition des voisins : 1 sur " & scrlVChance.Value
    End Sub

    Private Sub scrlCellule_ValueChanged(sender As Object, e As EventArgs) Handles scrlCellule.ValueChanged
        lblCellule.Text = "Nbr de cellules : " & scrlCellule.Value
    End Sub

    Private Sub scrlVCellule_ValueChanged(sender As Object, e As EventArgs) Handles scrlVCellule.ValueChanged
        lblVCellule.Text = "Nbr de voisins par cellule : " & scrlVCellule.Value
    End Sub


    Private Sub btnResize_Click(sender As Object, e As EventArgs) Handles btnResize.Click

        ' on pose la question pour être sûr 
        If MsgBox("Etes-vous sûr de vouloir faire ça ? (la partie va recommencer)", vbYesNo, "Jeu de la vie") = vbYes Then
            Call resizeGame()
        End If

    End Sub


    Private Sub scrlMinMort_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlMinMort.Scroll
        ' on affiche la valeur
        lblMinMort.Text = "Minimum Mort : " & scrlMinMort.Value
        cmdRules.BackColor = Color.LightGray
    End Sub

    Private Sub scrlMaxMort_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlMaxMort.Scroll
        ' on affiche la valeur
        lblMaxMort.Text = "Maximum mort : " & scrlMaxMort.Value
        cmdRules.BackColor = Color.LightGray
    End Sub

    Private Sub scrlMinNaissance_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlMinNaissance.Scroll
        ' on affiche la valeur
        lblMinNaissance.Text = "Minimum Naissance : " & scrlMinNaissance.Value
        cmdRules.BackColor = Color.LightGray
    End Sub

    Private Sub scrlMaxNaissance_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlMaxNaissance.Scroll
        ' on affiche la valeur
        lblMaxNaissance.Text = "Maximum Naissance : " & scrlMaxNaissance.Value
        cmdRules.BackColor = Color.LightGray
    End Sub

    Private Sub cmdRules_Click(sender As Object, e As EventArgs) Handles cmdRules.Click

        ' on vérifie 
        If scrlMinNaissance.Value > scrlMaxNaissance.Value Then
            Call MsgBox("La valeur minimal de naissance ne peut pas être supérieur à la valeur maximum !!", vbYes, "Jeu de la vie")
            cmdRules.BackColor = Color.LightGray
            Exit Sub
        End If

        ' on vérifie 
        If scrlMinMort.Value > scrlMaxMort.Value Then
            Call MsgBox("La valeur minimal de mort ne peut pas être supérieur à la valeur maximum !!", vbYes, "Jeu de la vie")
            cmdRules.BackColor = Color.LightGray
            Exit Sub
        End If

        ' on change les règles
        Call MoteurGraphique.Moteur.setRegle(scrlMinMort.Value, scrlMaxMort.Value, scrlMinNaissance.Value, scrlMaxNaissance.Value)

        ' on change la couleur du bouton pour montrer que le changement a été fait
        cmdRules.BackColor = Color.LightGreen


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ' arrêt du jeu ?s
        If MsgBox("Ëtes-vous sûr de vouloir arrêter la génération", vbYesNo, "Jeu de la vie") = vbYes Then
            Call CancelGame()
            btnRestart.Enabled = True
        End If


    End Sub

    Private Sub scrlMinMort_ValueChanged(sender As Object, e As EventArgs) Handles scrlMinMort.ValueChanged
        ' on affiche la valeur
        lblMinMort.Text = "Minimum Mort : " & scrlMinMort.Value
        cmdRules.BackColor = Color.LightGray
    End Sub

    Private Sub scrlMaxMort_ValueChanged(sender As Object, e As EventArgs) Handles scrlMaxMort.ValueChanged
        ' on affiche la valeur
        lblMaxMort.Text = "Maximum mort : " & scrlMaxMort.Value
        cmdRules.BackColor = Color.LightGray
    End Sub

    Private Sub scrlMinNaissance_ValueChanged(sender As Object, e As EventArgs) Handles scrlMinNaissance.ValueChanged
        ' on affiche la valeur
        lblMinNaissance.Text = "Minimum Naissance : " & scrlMinNaissance.Value
        cmdRules.BackColor = Color.LightGray
    End Sub

    Private Sub scrlMaxNaissance_ValueChanged(sender As Object, e As EventArgs) Handles scrlMaxNaissance.ValueChanged
        ' on affiche la valeur
        lblMaxNaissance.Text = "Maximum Naissance : " & scrlMaxNaissance.Value
        cmdRules.BackColor = Color.LightGray
    End Sub

    Private Sub scrlTailleCellule_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlTailleCellule.Scroll
        lblTailleCellule.Text = "Taille d'une cellule : " & scrlTailleCellule.Value * 2 'multiple de 2 uniquement
    End Sub

    Private Sub lblTailleCellule_Click(sender As Object, e As EventArgs) Handles lblTailleCellule.Click

    End Sub

    Private Sub scrlTailleX_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlTailleX.Scroll
        lblTailleX.Text = "X : " & scrlTailleX.Value * 2
    End Sub

    Private Sub scrlTailleY_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlTailleY.Scroll
        lblTailleY.Text = "Y : " & scrlTailleY.Value * 2
    End Sub

    Private Sub chkRandom_CheckedChanged(sender As Object, e As EventArgs) Handles chkRandom.CheckedChanged

        If chkRandom.Checked Then
            grpParam.Enabled = True
        Else
            grpParam.Enabled = False
        End If

    End Sub
End Class