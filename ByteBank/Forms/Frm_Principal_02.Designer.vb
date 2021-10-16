<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal_02
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
        Me.Lbl_Principal_02 = New System.Windows.Forms.Label()
        Me.Btm_Bonificacao = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_Principal_02
        '
        Me.Lbl_Principal_02.AutoSize = True
        Me.Lbl_Principal_02.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_Principal_02.Name = "Lbl_Principal_02"
        Me.Lbl_Principal_02.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Principal_02.TabIndex = 0
        Me.Lbl_Principal_02.Text = "Label1"
        '
        'Btm_Bonificacao
        '
        Me.Btm_Bonificacao.Location = New System.Drawing.Point(15, 45)
        Me.Btm_Bonificacao.Name = "Btm_Bonificacao"
        Me.Btm_Bonificacao.Size = New System.Drawing.Size(138, 65)
        Me.Btm_Bonificacao.TabIndex = 1
        Me.Btm_Bonificacao.Text = "Button1"
        Me.Btm_Bonificacao.UseVisualStyleBackColor = True
        '
        'Frm_Principal_02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btm_Bonificacao)
        Me.Controls.Add(Me.Lbl_Principal_02)
        Me.Name = "Frm_Principal_02"
        Me.Text = "Frm_Principal_02"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Principal_02 As Label
    Friend WithEvents Btm_Bonificacao As Button
End Class
