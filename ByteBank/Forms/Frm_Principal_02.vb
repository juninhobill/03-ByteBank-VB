Imports ByteBank.Classes.Bibliotecas
Imports ByteBank.Classes.Funcionarios

Public Class Frm_Principal_02
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Text = "Cálculo Bonificação"
        Lbl_Principal_02.Text = "Cálculo Bonificação"
        Btm_Bonificacao.Text = "Cálculo da Bonificação"

    End Sub

    Private Sub Btm_Bonificacao_Click(sender As Object, e As EventArgs) Handles Btm_Bonificacao.Click

        Dim TotalBonificacao As New GerenciadorBonificacao

        Dim Carlos As New Diretor("123.123.123-54", 5000)
        Dim Pedro As New Designer("123.123.123-05", 3000)
        Dim Joao As New Gerente("123.123.123-89", 4000)
        Dim Carla As New Auxiliar("123.123.123-90", 2000)

        TotalBonificacao.Registrar(Carlos)
        TotalBonificacao.Registrar(Pedro)
        TotalBonificacao.Registrar(Joao)
        TotalBonificacao.Registrar(Carla)

        MsgBox("O valor total da bonificação será de: " + TotalBonificacao.getBonificacao.ToString)

    End Sub
End Class