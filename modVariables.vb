Module modVariables


    ' ######################
    ' ## VARIABLES 
    ' ######################

    Public inGame As Boolean = False ' variable qui sert à savoir si le jeu est lancé
    Public FirstLoopDone = False ' une loop dans le vide pour voir la position de départ
    Public GameFPS As Long

    Public generationCount As Long = 0 ' le nombre de tours du programme
    Public TAILLE_CELLULE As Byte = 16

End Module
