<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Lbl_Principal = New System.Windows.Forms.Label()
        Me.Btm_Click = New System.Windows.Forms.Button()
        Me.Btm_Teste_Heranca = New System.Windows.Forms.Button()
        Me.Btm_Classe_Base = New System.Windows.Forms.Button()
        Me.Btm_Aumento = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_Principal
        '
        Me.Lbl_Principal.AutoSize = True
        Me.Lbl_Principal.Location = New System.Drawing.Point(13, 13)
        Me.Lbl_Principal.Name = "Lbl_Principal"
        Me.Lbl_Principal.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Principal.TabIndex = 0
        Me.Lbl_Principal.Text = "Label1"
        '
        'Btm_Click
        '
        Me.Btm_Click.Location = New System.Drawing.Point(16, 49)
        Me.Btm_Click.Name = "Btm_Click"
        Me.Btm_Click.Size = New System.Drawing.Size(99, 50)
        Me.Btm_Click.TabIndex = 1
        Me.Btm_Click.Text = "Button1"
        Me.Btm_Click.UseVisualStyleBackColor = True
        '
        'Btm_Teste_Heranca
        '
        Me.Btm_Teste_Heranca.Location = New System.Drawing.Point(136, 49)
        Me.Btm_Teste_Heranca.Name = "Btm_Teste_Heranca"
        Me.Btm_Teste_Heranca.Size = New System.Drawing.Size(272, 49)
        Me.Btm_Teste_Heranca.TabIndex = 2
        Me.Btm_Teste_Heranca.Text = "Button1"
        Me.Btm_Teste_Heranca.UseVisualStyleBackColor = True
        '
        'Btm_Classe_Base
        '
        Me.Btm_Classe_Base.Location = New System.Drawing.Point(16, 140)
        Me.Btm_Classe_Base.Name = "Btm_Classe_Base"
        Me.Btm_Classe_Base.Size = New System.Drawing.Size(99, 53)
        Me.Btm_Classe_Base.TabIndex = 3
        Me.Btm_Classe_Base.Text = "Button1"
        Me.Btm_Classe_Base.UseVisualStyleBackColor = True
        '
        'Btm_Aumento
        '
        Me.Btm_Aumento.Location = New System.Drawing.Point(136, 140)
        Me.Btm_Aumento.Name = "Btm_Aumento"
        Me.Btm_Aumento.Size = New System.Drawing.Size(272, 52)
        Me.Btm_Aumento.TabIndex = 4
        Me.Btm_Aumento.Text = "Button1"
        Me.Btm_Aumento.UseVisualStyleBackColor = True
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btm_Aumento)
        Me.Controls.Add(Me.Btm_Classe_Base)
        Me.Controls.Add(Me.Btm_Teste_Heranca)
        Me.Controls.Add(Me.Btm_Click)
        Me.Controls.Add(Me.Lbl_Principal)
        Me.Name = "Frm_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents Btm_Click As Button
    Friend WithEvents Btm_Teste_Heranca As Button
    Friend WithEvents Btm_Classe_Base As Button
    Friend WithEvents Btm_Aumento As Button
End Class
