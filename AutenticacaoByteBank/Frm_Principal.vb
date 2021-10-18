Imports AutenticacaoByteBank.Classes.Bibliotecas
Imports AutenticacaoByteBank.Classes.Funcionarios
Imports AutenticacaoByteBank.Classes.Externos

Public Class Frm_Principal
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Text = "Autenticação Byte Bank"
        Lbl_Principal.Text = "Autenticação Byte Bank"
        Btm_Autentica.Text = "Autentica"
        Btm_Autentica2.Text = "Autentica com Representante"

    End Sub

    Private Sub Btm_Autentica_Click(sender As Object, e As EventArgs) Handles Btm_Autentica.Click

        Dim Pedro As New Diretor("123.123.123-90", 20000)
        Pedro.senha = "abc"

        Dim Alberto As New Gerente("123.123.123-89", 20000)
        Alberto.senha = "999"

        Dim vLoga As Boolean
        Dim SistemaInterno As New SistemaInterno
        vLoga = SistemaInterno.Logar(Pedro, "abc")
        MsgBox("A tentativa de logar no sistema resultou em: " + vLoga.ToString)

        vLoga = SistemaInterno.Logar(Alberto, "999")
        MsgBox("A tentativa de logar no sistema resultou em: " + vLoga.ToString)

    End Sub

    Private Sub Btm_Autentica2_Click(sender As Object, e As EventArgs) Handles Btm_Autentica2.Click

        Dim Pedro As New Diretor("123.123.123-90", 20000)
        Pedro.senha = "abcde"

        Dim Alberto As New Representante()
        Alberto.senha = "9999999999"

        Dim vLoga As Boolean
        Dim SistemaInterno As New SistemaInterno
        vLoga = SistemaInterno.Logar(Pedro, "abcde")
        MsgBox("A tentativa de logar no sistema (Funcionário) resultou em: " + vLoga.ToString)

        vLoga = SistemaInterno.Logar(Alberto, "9999999999")
        MsgBox("A tentativa de logar no sistema (Representante) resultou em: " + vLoga.ToString)

    End Sub
End Class
