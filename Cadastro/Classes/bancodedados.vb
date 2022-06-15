Imports Cadastro.Classes.Pessoa
Imports Npgsql



Namespace Classes.bancodedados

    Public Class bancodedados

        Public Property StringConexao As String
        Public Property conexaoDB As NpgsqlConnection

        Public Sub New()

            'StringConexao = "Host=localhost;Username=postgres;Password=Full1574;Database=pessoa"
            StringConexao = "Server=127.0.0.1;Port=5437;Database=cadastro;User Id=postgres;Password=Full1574;"
            conexaoDB = New NpgsqlConnection(StringConexao)
            conexaoDB.Open()


        End Sub

        Public Function Consulta(comandosql As String, ByRef DT As DataTable) As String

            Try
                Dim MeuComando As IDbCommand = New NpgsqlCommand(comandosql, conexaoDB)
                MeuComando.CommandTimeout = 0
                Dim RetornoDoBanco As IDataReader = MeuComando.ExecuteReader()
                DT.Load(RetornoDoBanco)
                Return ""
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Function

        Public Function Ordem(comandosql As String) As String

            Try
                Dim MeuComando As IDbCommand = New NpgsqlCommand(comandosql, conexaoDB)
                MeuComando.CommandTimeout = 0
                Dim RetornoDoBanco As IDataReader = MeuComando.ExecuteReader()
                Return ""

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Function

        Public Sub Close()

            conexaoDB.Close()

        End Sub






    End Class

End Namespace


