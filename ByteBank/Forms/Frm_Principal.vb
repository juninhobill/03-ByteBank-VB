Imports ByteBank.Classes.Bibliotecas
Imports ByteBank.Classes.Funcionarios

Public Class Frm_Principal
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Text = "Principal"
        Lbl_Principal.Text = "Principal"
        Btm_Click.Text = "Clique aqui"
        Btm_Teste_Heranca.Text = "Clique aqui para testar herança"
        Btm_Classe_Base.Text = "Executa exemplo classe base"
        Btm_Aumento.Text = "Aumento Salarial"

    End Sub

    Private Sub Btm_Click_Click(sender As Object, e As EventArgs) Handles Btm_Click.Click

        Dim gerenciadorBonificacao As New GerenciadorBonificacao

        Dim Carlos As New Gerente("18769787832", "10000")
        Carlos.nome = "Carlos Antonio"
        gerenciadorBonificacao.Registrar(Carlos)

        Dim Bia As New Diretor("18769787832", "20000")
        Bia.nome = "Beatriz Regina"

        gerenciadorBonificacao.Registrar(Bia)

        MsgBox("Salário do " + Carlos.nome + " é " + Carlos.salario.ToString)
        MsgBox("A bonificação do " + Carlos.nome + " será de " + Carlos.GetBonificacao.ToString)

        MsgBox("Salário da " + Bia.nome + " é " + Bia.salario.ToString)
        MsgBox("A bonificação da " + Bia.nome + " será de " + Bia.GetBonificacao.ToString)

        Dim totalBonificacao As Double
        totalBonificacao += Carlos.GetBonificacao
        totalBonificacao += Bia.GetBonificacao
        MsgBox("O valor total de bonificação será de: " + totalBonificacao.ToString + _
            " o valor calculado pela biblioteca foi de " + gerenciadorBonificacao.getBonificacao.ToString)

    End Sub

    'Private Sub Btm_Teste_Heranca_Click(sender As Object, e As EventArgs) Handles Btm_Teste_Heranca.Click

    '    Dim vFuncionario As New Funcionario("18769787832", "1000")

    '    Dim vDiretorFuncionario As New Funcionario("18769787832", "10000")
    '    MsgBox("Número de funcionários atualmente instanciados é de: " + Funcionario.TotaldeFuncionarios.ToString)

    '    Dim vDiretor As New Diretor("18769787832", "1000")
    '    MsgBox("Número de funcionários e diretores atualmente instanciados é de: " + Funcionario.TotaldeFuncionarios.ToString)

    '    Dim vGerente As New Gerente("18769787832", "1000")
    '    MsgBox("Número de funcionários, diretores e gerentes atualmente instanciados é de: " + Funcionario.TotaldeFuncionarios.ToString)

    '    Dim vTexto As String
    '    vTexto = "O CPF do Funcionário é: " + vFuncionario.cpf + " e " + vDiretorFuncionario.cpf + vbCrLf
    '    vTexto += "O CPF do Diretor é: " + vDiretor.cpf + vbCrLf
    '    vTexto += "O CPF do Gerente é: " + vGerente.cpf + vbCrLf

    '    vDiretorFuncionario = vDiretor

    '    Dim vSaida As String

    '    vSaida = "A bonificação de vDiretor é " + vDiretor.GetBonificacao().ToString + vbCrLf
    '    vSaida += "A bonificação de vFuncionario é " + vFuncionario.GetBonificacao().ToString + vbCrLf
    '    vSaida += "A bonificação de vDiretorFuncionario é " + vDiretorFuncionario.GetBonificacao().ToString + vbCrLf

    '    MsgBox(vSaida)
    '    MsgBox(vTexto)


    'End Sub

    Private Sub Btm_Classe_Base_Click(sender As Object, e As EventArgs) Handles Btm_Classe_Base.Click

        Dim vDiretor As New Diretor("18769787832", "10000")

        MsgBox("A bonificação do diretor é: " + vDiretor.GetBonificacao.ToString)

    End Sub

    'Private Sub Btm_Aumento_Click(sender As Object, e As EventArgs) Handles Btm_Aumento.Click

    '    Dim vFuncionario As New Funcionario("18769787832", "1000")

    '    Dim vGerente As New Gerente("18769787832", "2000")

    '    Dim vDiretor As New Diretor("18769787832", "3000")

    '    Dim vTexto As String

    '    vTexto = "O salário do Funcionário é: " + vFuncionario.salario.ToString + vbCrLf
    '    vTexto += "O salário do Gerente é: " + vGerente.salario.ToString + vbCrLf
    '    vTexto += "O salário do Diretor é: " + vDiretor.salario.ToString + vbCrLf

    '    MsgBox(vTexto)

    '    vFuncionario.AumentarSalario()
    '    vGerente.AumentarSalario()
    '    vDiretor.AumentarSalario()
    '    vTexto = "O salário do Funcionário é: " + vFuncionario.salario.ToString + vbCrLf
    '    vTexto += "O salário do Gerente é: " + vGerente.salario.ToString + vbCrLf
    '    vTexto += "O salário do Diretor é: " + vDiretor.salario.ToString + vbCrLf
    '    MsgBox(vTexto)

    'End Sub
End Class
