Imports ByteBank.Classes.Funcionarios

Namespace Classes.Bibliotecas

    Public Class GerenciadorBonificacao

#Region "PROPRIEDADES"

        Private _totalBonificacao As Double

        Public Sub Registrar(Funcionario As Funcionario)
            _totalBonificacao += Funcionario.GetBonificacao
        End Sub

        Public Function getBonificacao() As Double
            Return _totalBonificacao
        End Function

#End Region

    End Class

End Namespace