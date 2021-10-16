
Namespace Classes.Funcionarios

    Public Class Funcionario

#Region "PROPRIEDADES"
        Public Property nome As String

        Private Property m_salario As Double
        Public Property salario As Double

            Get
                Return m_salario
            End Get
            Protected Set(value As Double)
                m_salario = value
            End Set

        End Property

        Private m_cpf As String
        Public ReadOnly Property cpf As String

            Get
                Return m_cpf
            End Get

        End Property

        Private Shared m_TotaldeFuncionarios As Integer
        Public Shared ReadOnly Property TotaldeFuncionarios() As Integer

            Get
                Return m_TotaldeFuncionarios
            End Get
        End Property

#End Region

#Region "CONSTRUTORES"

        Public Sub New(_cpf As String, _salario As Double)
            m_cpf = _cpf
            m_salario = _salario
            m_TotaldeFuncionarios += 1
            Console.WriteLine("CONSTRUTOR DA CLASSE FUNCIONÁRIO")
        End Sub

#End Region

#Region "MÉTODOS"

        Public Overridable Function GetBonificacao() As Double

            Return salario * 0.1

        End Function

        Public Overridable Sub AumentarSalario()
            m_salario = m_salario * 1.1
        End Sub

#End Region

    End Class

End Namespace
