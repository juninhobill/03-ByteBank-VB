Namespace Classes.Funcionarios

    Public Class Diretor
        Inherits Funcionario

#Region "PROPRIEDADES"

#End Region

#Region "CONSTRUTORES"

        Public Sub New(_cpf As String, _salario As Double)
            MyBase.New(_cpf, _salario)

            Console.WriteLine("CONSTRUTOR DA CLASSE DIRETOR")
        End Sub

#End Region

#Region "MÉTODOS"

        Public Overrides Function GetBonificacao() As Double

            Return (salario * 1) + MyBase.GetBonificacao()

        End Function

        Public Overrides Sub AumentarSalario()
            salario = salario * 1.2
        End Sub

#End Region

    End Class

End Namespace