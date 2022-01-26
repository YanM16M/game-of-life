<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmControle
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.grpParam = New System.Windows.Forms.GroupBox()
        Me.scrlVChance = New System.Windows.Forms.HScrollBar()
        Me.lblVChance = New System.Windows.Forms.Label()
        Me.scrlVCellule = New System.Windows.Forms.HScrollBar()
        Me.lblVCellule = New System.Windows.Forms.Label()
        Me.scrlCellule = New System.Windows.Forms.HScrollBar()
        Me.lblCellule = New System.Windows.Forms.Label()
        Me.txtTimer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.grpTimer = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnResize = New System.Windows.Forms.Button()
        Me.lblTailleY = New System.Windows.Forms.Label()
        Me.lblTailleX = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdRules = New System.Windows.Forms.Button()
        Me.lblMaxNaissance = New System.Windows.Forms.Label()
        Me.scrlMaxNaissance = New System.Windows.Forms.HScrollBar()
        Me.lblMinNaissance = New System.Windows.Forms.Label()
        Me.scrlMinNaissance = New System.Windows.Forms.HScrollBar()
        Me.lblMaxMort = New System.Windows.Forms.Label()
        Me.lblMinMort = New System.Windows.Forms.Label()
        Me.scrlMaxMort = New System.Windows.Forms.HScrollBar()
        Me.scrlMinMort = New System.Windows.Forms.HScrollBar()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.scrlTailleCellule = New System.Windows.Forms.HScrollBar()
        Me.lblTailleCellule = New System.Windows.Forms.Label()
        Me.scrlTailleX = New System.Windows.Forms.HScrollBar()
        Me.scrlTailleY = New System.Windows.Forms.HScrollBar()
        Me.chkRandom = New System.Windows.Forms.CheckBox()
        Me.grpParam.SuspendLayout()
        Me.grpTimer.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRestart
        '
        Me.btnRestart.Location = New System.Drawing.Point(148, 312)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(226, 23)
        Me.btnRestart.TabIndex = 1
        Me.btnRestart.Text = "Lancez !"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'grpParam
        '
        Me.grpParam.Controls.Add(Me.scrlVChance)
        Me.grpParam.Controls.Add(Me.lblVChance)
        Me.grpParam.Controls.Add(Me.scrlVCellule)
        Me.grpParam.Controls.Add(Me.lblVCellule)
        Me.grpParam.Controls.Add(Me.scrlCellule)
        Me.grpParam.Controls.Add(Me.lblCellule)
        Me.grpParam.Enabled = False
        Me.grpParam.Location = New System.Drawing.Point(12, 105)
        Me.grpParam.Name = "grpParam"
        Me.grpParam.Size = New System.Drawing.Size(185, 201)
        Me.grpParam.TabIndex = 2
        Me.grpParam.TabStop = False
        Me.grpParam.Text = "Génération Paramètre"
        '
        'scrlVChance
        '
        Me.scrlVChance.Location = New System.Drawing.Point(6, 151)
        Me.scrlVChance.Minimum = 1
        Me.scrlVChance.Name = "scrlVChance"
        Me.scrlVChance.Size = New System.Drawing.Size(176, 17)
        Me.scrlVChance.TabIndex = 5
        Me.scrlVChance.Value = 1
        '
        'lblVChance
        '
        Me.lblVChance.Location = New System.Drawing.Point(9, 122)
        Me.lblVChance.Name = "lblVChance"
        Me.lblVChance.Size = New System.Drawing.Size(137, 29)
        Me.lblVChance.TabIndex = 4
        Me.lblVChance.Text = "Chance d'apparition des voisins : 1 sur 2"
        '
        'scrlVCellule
        '
        Me.scrlVCellule.LargeChange = 1
        Me.scrlVCellule.Location = New System.Drawing.Point(9, 91)
        Me.scrlVCellule.Maximum = 8
        Me.scrlVCellule.Name = "scrlVCellule"
        Me.scrlVCellule.Size = New System.Drawing.Size(170, 17)
        Me.scrlVCellule.TabIndex = 3
        Me.scrlVCellule.Value = 4
        '
        'lblVCellule
        '
        Me.lblVCellule.AutoSize = True
        Me.lblVCellule.Location = New System.Drawing.Point(9, 68)
        Me.lblVCellule.Name = "lblVCellule"
        Me.lblVCellule.Size = New System.Drawing.Size(140, 13)
        Me.lblVCellule.TabIndex = 2
        Me.lblVCellule.Text = "Nbr de voisins par cellule : 4"
        '
        'scrlCellule
        '
        Me.scrlCellule.Location = New System.Drawing.Point(6, 39)
        Me.scrlCellule.Minimum = 1
        Me.scrlCellule.Name = "scrlCellule"
        Me.scrlCellule.Size = New System.Drawing.Size(176, 17)
        Me.scrlCellule.TabIndex = 1
        Me.scrlCellule.Value = 4
        '
        'lblCellule
        '
        Me.lblCellule.AutoSize = True
        Me.lblCellule.Location = New System.Drawing.Point(6, 16)
        Me.lblCellule.Name = "lblCellule"
        Me.lblCellule.Size = New System.Drawing.Size(92, 13)
        Me.lblCellule.TabIndex = 0
        Me.lblCellule.Text = "Nbr de cellules : 4"
        '
        'txtTimer
        '
        Me.txtTimer.Location = New System.Drawing.Point(6, 32)
        Me.txtTimer.Name = "txtTimer"
        Me.txtTimer.Size = New System.Drawing.Size(173, 20)
        Me.txtTimer.TabIndex = 0
        Me.txtTimer.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Intervalle du Timer en ms :"
        '
        'btnStart
        '
        Me.btnStart.Enabled = False
        Me.btnStart.Location = New System.Drawing.Point(6, 58)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnPause
        '
        Me.btnPause.Location = New System.Drawing.Point(104, 58)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(75, 23)
        Me.btnPause.TabIndex = 3
        Me.btnPause.Text = "Pause"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'grpTimer
        '
        Me.grpTimer.Controls.Add(Me.btnPause)
        Me.grpTimer.Controls.Add(Me.btnStart)
        Me.grpTimer.Controls.Add(Me.Label1)
        Me.grpTimer.Controls.Add(Me.txtTimer)
        Me.grpTimer.Location = New System.Drawing.Point(12, 12)
        Me.grpTimer.Name = "grpTimer"
        Me.grpTimer.Size = New System.Drawing.Size(185, 87)
        Me.grpTimer.TabIndex = 0
        Me.grpTimer.TabStop = False
        Me.grpTimer.Text = "Timer"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.scrlTailleY)
        Me.GroupBox2.Controls.Add(Me.scrlTailleX)
        Me.GroupBox2.Controls.Add(Me.lblTailleCellule)
        Me.GroupBox2.Controls.Add(Me.scrlTailleCellule)
        Me.GroupBox2.Controls.Add(Me.btnResize)
        Me.GroupBox2.Controls.Add(Me.lblTailleY)
        Me.GroupBox2.Controls.Add(Me.lblTailleX)
        Me.GroupBox2.Location = New System.Drawing.Point(402, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(185, 213)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Taille de la grille"
        '
        'btnResize
        '
        Me.btnResize.Location = New System.Drawing.Point(6, 178)
        Me.btnResize.Name = "btnResize"
        Me.btnResize.Size = New System.Drawing.Size(171, 23)
        Me.btnResize.TabIndex = 7
        Me.btnResize.Text = "Changer la taille"
        Me.btnResize.UseVisualStyleBackColor = True
        '
        'lblTailleY
        '
        Me.lblTailleY.AutoSize = True
        Me.lblTailleY.Location = New System.Drawing.Point(6, 68)
        Me.lblTailleY.Name = "lblTailleY"
        Me.lblTailleY.Size = New System.Drawing.Size(35, 13)
        Me.lblTailleY.TabIndex = 4
        Me.lblTailleY.Text = "Y : 50"
        '
        'lblTailleX
        '
        Me.lblTailleX.AutoSize = True
        Me.lblTailleX.Location = New System.Drawing.Point(6, 16)
        Me.lblTailleX.Name = "lblTailleX"
        Me.lblTailleX.Size = New System.Drawing.Size(35, 13)
        Me.lblTailleX.TabIndex = 3
        Me.lblTailleX.Text = "X : 64"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdRules)
        Me.GroupBox1.Controls.Add(Me.lblMaxNaissance)
        Me.GroupBox1.Controls.Add(Me.scrlMaxNaissance)
        Me.GroupBox1.Controls.Add(Me.lblMinNaissance)
        Me.GroupBox1.Controls.Add(Me.scrlMinNaissance)
        Me.GroupBox1.Controls.Add(Me.lblMaxMort)
        Me.GroupBox1.Controls.Add(Me.lblMinMort)
        Me.GroupBox1.Controls.Add(Me.scrlMaxMort)
        Me.GroupBox1.Controls.Add(Me.scrlMinMort)
        Me.GroupBox1.Location = New System.Drawing.Point(203, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(193, 294)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Réglages règles du jeu"
        '
        'cmdRules
        '
        Me.cmdRules.BackColor = System.Drawing.Color.LightGray
        Me.cmdRules.Location = New System.Drawing.Point(9, 210)
        Me.cmdRules.Name = "cmdRules"
        Me.cmdRules.Size = New System.Drawing.Size(178, 78)
        Me.cmdRules.TabIndex = 8
        Me.cmdRules.Text = "Changer les règles"
        Me.cmdRules.UseVisualStyleBackColor = False
        '
        'lblMaxNaissance
        '
        Me.lblMaxNaissance.AutoSize = True
        Me.lblMaxNaissance.Location = New System.Drawing.Point(6, 161)
        Me.lblMaxNaissance.Name = "lblMaxNaissance"
        Me.lblMaxNaissance.Size = New System.Drawing.Size(95, 13)
        Me.lblMaxNaissance.TabIndex = 7
        Me.lblMaxNaissance.Text = "Max Naissance : 5"
        '
        'scrlMaxNaissance
        '
        Me.scrlMaxNaissance.LargeChange = 1
        Me.scrlMaxNaissance.Location = New System.Drawing.Point(9, 184)
        Me.scrlMaxNaissance.Maximum = 8
        Me.scrlMaxNaissance.Name = "scrlMaxNaissance"
        Me.scrlMaxNaissance.Size = New System.Drawing.Size(165, 17)
        Me.scrlMaxNaissance.TabIndex = 6
        Me.scrlMaxNaissance.Value = 5
        '
        'lblMinNaissance
        '
        Me.lblMinNaissance.AutoSize = True
        Me.lblMinNaissance.Location = New System.Drawing.Point(6, 109)
        Me.lblMinNaissance.Name = "lblMinNaissance"
        Me.lblMinNaissance.Size = New System.Drawing.Size(92, 13)
        Me.lblMinNaissance.TabIndex = 5
        Me.lblMinNaissance.Text = "Min Naissance : 3"
        '
        'scrlMinNaissance
        '
        Me.scrlMinNaissance.LargeChange = 1
        Me.scrlMinNaissance.Location = New System.Drawing.Point(9, 132)
        Me.scrlMinNaissance.Maximum = 8
        Me.scrlMinNaissance.Name = "scrlMinNaissance"
        Me.scrlMinNaissance.Size = New System.Drawing.Size(165, 17)
        Me.scrlMinNaissance.TabIndex = 4
        Me.scrlMinNaissance.Value = 3
        '
        'lblMaxMort
        '
        Me.lblMaxMort.AutoSize = True
        Me.lblMaxMort.Location = New System.Drawing.Point(6, 61)
        Me.lblMaxMort.Name = "lblMaxMort"
        Me.lblMaxMort.Size = New System.Drawing.Size(90, 13)
        Me.lblMaxMort.TabIndex = 3
        Me.lblMaxMort.Text = "Maximum Mort : 6"
        '
        'lblMinMort
        '
        Me.lblMinMort.AutoSize = True
        Me.lblMinMort.Location = New System.Drawing.Point(6, 16)
        Me.lblMinMort.Name = "lblMinMort"
        Me.lblMinMort.Size = New System.Drawing.Size(87, 13)
        Me.lblMinMort.TabIndex = 2
        Me.lblMinMort.Text = "Minimum Mort : 3"
        '
        'scrlMaxMort
        '
        Me.scrlMaxMort.LargeChange = 1
        Me.scrlMaxMort.Location = New System.Drawing.Point(9, 85)
        Me.scrlMaxMort.Maximum = 8
        Me.scrlMaxMort.Name = "scrlMaxMort"
        Me.scrlMaxMort.Size = New System.Drawing.Size(168, 17)
        Me.scrlMaxMort.TabIndex = 1
        Me.scrlMaxMort.Value = 6
        '
        'scrlMinMort
        '
        Me.scrlMinMort.LargeChange = 1
        Me.scrlMinMort.Location = New System.Drawing.Point(6, 34)
        Me.scrlMinMort.Maximum = 8
        Me.scrlMinMort.Name = "scrlMinMort"
        Me.scrlMinMort.Size = New System.Drawing.Size(165, 17)
        Me.scrlMinMort.TabIndex = 0
        Me.scrlMinMort.Value = 3
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(380, 312)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(207, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Arrêter"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'scrlTailleCellule
        '
        Me.scrlTailleCellule.Location = New System.Drawing.Point(6, 145)
        Me.scrlTailleCellule.Maximum = 32
        Me.scrlTailleCellule.Minimum = 1
        Me.scrlTailleCellule.Name = "scrlTailleCellule"
        Me.scrlTailleCellule.Size = New System.Drawing.Size(171, 17)
        Me.scrlTailleCellule.TabIndex = 8
        Me.scrlTailleCellule.Value = 8
        '
        'lblTailleCellule
        '
        Me.lblTailleCellule.AutoSize = True
        Me.lblTailleCellule.Location = New System.Drawing.Point(3, 121)
        Me.lblTailleCellule.Name = "lblTailleCellule"
        Me.lblTailleCellule.Size = New System.Drawing.Size(115, 13)
        Me.lblTailleCellule.TabIndex = 9
        Me.lblTailleCellule.Text = "Taille d'une cellule : 16"
        '
        'scrlTailleX
        '
        Me.scrlTailleX.Location = New System.Drawing.Point(6, 35)
        Me.scrlTailleX.Maximum = 64
        Me.scrlTailleX.Minimum = 1
        Me.scrlTailleX.Name = "scrlTailleX"
        Me.scrlTailleX.Size = New System.Drawing.Size(171, 17)
        Me.scrlTailleX.TabIndex = 10
        Me.scrlTailleX.Value = 32
        '
        'scrlTailleY
        '
        Me.scrlTailleY.Location = New System.Drawing.Point(6, 93)
        Me.scrlTailleY.Maximum = 64
        Me.scrlTailleY.Minimum = 1
        Me.scrlTailleY.Name = "scrlTailleY"
        Me.scrlTailleY.Size = New System.Drawing.Size(171, 17)
        Me.scrlTailleY.TabIndex = 11
        Me.scrlTailleY.Value = 25
        '
        'chkRandom
        '
        Me.chkRandom.AutoSize = True
        Me.chkRandom.Location = New System.Drawing.Point(12, 312)
        Me.chkRandom.Name = "chkRandom"
        Me.chkRandom.Size = New System.Drawing.Size(130, 17)
        Me.chkRandom.TabIndex = 7
        Me.chkRandom.Text = "Génération aléatoire ?"
        Me.chkRandom.UseVisualStyleBackColor = True
        '
        'frmControle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 341)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkRandom)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpParam)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.grpTimer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmControle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.grpParam.ResumeLayout(False)
        Me.grpParam.PerformLayout()
        Me.grpTimer.ResumeLayout(False)
        Me.grpTimer.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRestart As Button
    Friend WithEvents grpParam As GroupBox
    Friend WithEvents scrlCellule As HScrollBar
    Friend WithEvents lblCellule As Label
    Friend WithEvents scrlVCellule As HScrollBar
    Friend WithEvents lblVCellule As Label
    Friend WithEvents scrlVChance As HScrollBar
    Friend WithEvents lblVChance As Label
    Friend WithEvents txtTimer As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnPause As Button
    Friend WithEvents grpTimer As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblTailleY As Label
    Friend WithEvents lblTailleX As Label
    Friend WithEvents btnResize As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblMaxMort As Label
    Friend WithEvents lblMinMort As Label
    Friend WithEvents scrlMaxMort As HScrollBar
    Friend WithEvents scrlMinMort As HScrollBar
    Friend WithEvents lblMinNaissance As Label
    Friend WithEvents scrlMinNaissance As HScrollBar
    Friend WithEvents lblMaxNaissance As Label
    Friend WithEvents scrlMaxNaissance As HScrollBar
    Friend WithEvents cmdRules As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents scrlTailleCellule As HScrollBar
    Friend WithEvents lblTailleCellule As Label
    Friend WithEvents scrlTailleY As HScrollBar
    Friend WithEvents scrlTailleX As HScrollBar
    Friend WithEvents chkRandom As CheckBox
End Class
