Imports AutenticacaoByteBank.Classes.Funcionarios
Imports AutenticacaoByteBank.Classes.Externos

Namespace Classes.Bibliotecas

    Public Class SistemaInterno

        Public Function Logar(Entidade As IAutentica, senhaTentativa As String)

            Dim vRetorno As Boolean
            vRetorno = Entidade.Autenticar(senhaTentativa)
            Return vRetorno

        End Function

    End Class

End Namespace