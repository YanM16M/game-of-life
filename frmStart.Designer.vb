<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStart
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
        Me.grpLancement = New System.Windows.Forms.GroupBox()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.grpLancement.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpLancement
        '
        Me.grpLancement.Controls.Add(Me.btnQuitter)
        Me.grpLancement.Controls.Add(Me.btnStart)
        Me.grpLancement.Location = New System.Drawing.Point(12, 12)
        Me.grpLancement.Name = "grpLancement"
        Me.grpLancement.Size = New System.Drawing.Size(362, 127)
        Me.grpLancement.TabIndex = 0
        Me.grpLancement.TabStop = False
        Me.grpLancement.Text = "Menu de lancement"
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(6, 72)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(350, 47)
        Me.btnQuitter.TabIndex = 1
        Me.btnQuitter.Text = "Quitter !"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(6, 19)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(350, 47)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Jouer !"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 147)
        Me.Controls.Add(Me.grpLancement)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmStart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le jeu de la vie"
        Me.grpLancement.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpLancement As GroupBox
    Friend WithEvents btnQuitter As Button
    Friend WithEvents btnStart As Button
End Class
