Imports Cadastro.Classes
Imports Cadastro
Imports Cadastro.Classes.bancodedados


Public Class Form1


#Region "CONSTRUTOR"


    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        CampoTabela.View = View.Details
        CampoTabela.LabelEdit = False
        CampoTabela.AllowColumnReorder = False
        CampoTabela.FullRowSelect = True
        CampoTabela.GridLines = True

        CampoTabela.Columns.Add("Id", 30, HorizontalAlignment.Center)
        CampoTabela.Columns.Add("Nome Completo", 200, HorizontalAlignment.Center)
        CampoTabela.Columns.Add("Endereço", 200, HorizontalAlignment.Center)
        CampoTabela.Columns.Add("Sexo", 50, HorizontalAlignment.Center)
        CampoTabela.Columns.Add("Data de Nasc.", 100, HorizontalAlignment.Center)
        CampoTabela.Columns.Add("E-mail", 150, HorizontalAlignment.Center)
        CampoTabela.Columns.Add("Estado Civil", 100, HorizontalAlignment.Center)
        CampoTabela.Columns.Add("Telefone", 150, HorizontalAlignment.Center)



        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub
#End Region

#Region "VARIÁVEIS GLOBAIS"
    Dim contador As Integer = 1
    Dim ListaDePessoas As New List(Of Pessoa)
    Dim pessoaPraRemover As Pessoa
    Dim atualizar As New Atualizar
    Dim estado As String

#End Region

    Private Function EstadoCivil() As String

        If RadioCasado.Checked Then
            estado = "Casado(a)"

        Else
            estado = "Solteiro(a)"
        End If
        Return estado
    End Function

    Private Sub BotaoSalvar_Click(sender As Object, e As EventArgs)
        'Dim estadocivil As String

        EstadoCivil()

        If ValidarCampos() Then
            Dim pessoa As New Pessoa(CampoNome.Text, CampoSobrenome.Text, CampoEndereco.Text, CampoSexo.Text, CampoData.Text, CampoEmail.Text, CampoTelefone.Text, estado, contador)
            contador += 1
            ListaDePessoas.Add(pessoa)

            ListarPessoas(ListaDePessoas)
        End If
    End Sub

    Public Function Buscar(coluna As String, informacao As String)

        Try
            Dim Comando As String = $"SELECT * FROM pessoa WHERE {coluna} = '{informacao}';"
            Dim Dt As New DataTable
            Dim BancoDeDados As New bancodedados()
            Dim Resultado = BancoDeDados.Consulta(Comando, Dt)
            BancoDeDados.Close()
            If Dt.Rows(0)(coluna) IsNot Nothing Then
                Return Dt
            End If


        Catch ex As Exception
            MsgBox($"{coluna} não encontrado.")
            Return Nothing

        End Try


    End Function



    Sub ListarPessoas(vpessoa As List(Of Pessoa))
        CampoTabela.Items.Clear()
        atualizar.CampoAtualizarPessoa.Items.Clear()
        Dim TabelaDoBanco As DataTable
        TabelaDoBanco = BuscarNoBanco()


    End Sub

    Sub ApagarCampos()
        CampoNome.Text = ""
        CampoSobrenome.Text = ""
        CampoEndereco.Text = ""
        CampoSexo.SelectedIndex = -1
        CampoData.Text = ""
        CampoEmail.Text = ""
        CampoTelefone.Text = ""
        RadioCasado.Checked = False
        RadioSolteiro.Checked = False

    End Sub

    Private Sub BotaoLimpar_Click(sender As Object, e As EventArgs) Handles BotaoLimpar.Click
        ApagarCampos()
    End Sub

    Private Sub BotaoRemoverId_Click(sender As Object, e As EventArgs) Handles BotaoRemoverId.Click
        Dim confirmacao As Integer
        Dim pessoapraremover As DataTable
        If CampoRemoverId.Text = Nothing Then
            MsgBox("Preencha o campo com o Id.")
        Else

            pessoapraremover = Buscar("id", CampoRemoverId.Text)
            If pessoapraremover IsNot Nothing Then
                confirmacao = MsgBox($"Tem certeza que deseja remover {pessoapraremover.Rows(0)("nome")}?", MsgBoxStyle.YesNo, "Remover")
                If confirmacao = 6 Then
                    Try
                        Dim Comando As String = $“DELETE FROM pessoa WHERE id = {CampoRemoverId.Text}"
                        Dim BancoDeDados As New bancodedados()
                        BancoDeDados.Ordem(Comando)
                        BancoDeDados.Close()
                        MsgBox("Removido com Sucesso!")
                        Consultar()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If

            End If




        End If
        pessoapraremover = Nothing

    End Sub

    Private Sub BotaoRemoverNome_Click(sender As Object, e As EventArgs) Handles BotaoRemoverNome.Click
        Dim confirmacao As Integer
        Dim pessoapraremover As DataTable
        If CampoRemoverNome.Text = Nothing Then
            MsgBox("Preencha o campo com o Nome.")
        Else

            pessoapraremover = Buscar("nome", CampoRemoverNome.Text)
            If pessoapraremover IsNot Nothing Then
                confirmacao = MsgBox($"Tem certeza que deseja remover {pessoapraremover.Rows(0)("nome")}?", MsgBoxStyle.YesNo, "Remover")
                If confirmacao = 6 Then
                    Try
                        Dim Comando As String = $“DELETE FROM pessoa WHERE nome = '{CampoRemoverNome.Text}'"
                        Dim BancoDeDados As New bancodedados()
                        BancoDeDados.Ordem(Comando)
                        BancoDeDados.Close()
                        MsgBox("Removido com Sucesso!")
                        Consultar()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If

            End If




        End If
        pessoapraremover = Nothing
    End Sub

    Function ValidarCampos() As Boolean
        If (String.IsNullOrEmpty(CampoNome.Text)) Or
           (String.IsNullOrEmpty(CampoEndereco.Text)) Or
           (String.IsNullOrEmpty(CampoSobrenome.Text)) Or
           (String.IsNullOrEmpty(CampoSexo.SelectedItem)) Or
           (String.IsNullOrEmpty(CampoTelefone.Text)) Or
           (String.IsNullOrEmpty(CampoEmail.Text)) Then
            Return False
        Else
            Return True
        End If
    End Function



    Function BuscarNoBanco() As DataTable
        Try
            Dim Comando As String = "SELECT * FROM pessoa;"
            Dim Dt As New DataTable
            Dim BancoDeDados As New bancodedados()
            Dim Resultado = BancoDeDados.Consulta(Comando, Dt)
            BancoDeDados.Close()
            Return Dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        End Try

    End Function

    Sub Consultar()
        CampoTabela.Items.Clear()
        Dim TabelaDoBanco As DataTable
        TabelaDoBanco = BuscarNoBanco()

        For i As Integer = 0 To TabelaDoBanco.Rows.Count - 1
            Dim Linha As New ListViewItem
            Linha.Name = TabelaDoBanco.Rows(i)("id")
            Linha.Text = TabelaDoBanco.Rows(i)("id")
            Linha.SubItems.Add($"{TabelaDoBanco.Rows(i)("nome")} {TabelaDoBanco.Rows(i)("sobrenome")}")
            Linha.SubItems.Add(TabelaDoBanco.Rows(i)("endereco"))
            Linha.SubItems.Add(TabelaDoBanco.Rows(i)("sexo"))
            Linha.SubItems.Add(TabelaDoBanco.Rows(i)("datadenascimento"))
            Linha.SubItems.Add(TabelaDoBanco.Rows(i)("email"))
            Linha.SubItems.Add(TabelaDoBanco.Rows(i)("estadocivil"))
            Linha.SubItems.Add(TabelaDoBanco.Rows(i)("telefone"))
            CampoTabela.Items.Add(Linha)


            ApagarCampos()

        Next
    End Sub

    Private Sub BotaoAtualizarDados_Click(sender As Object, e As EventArgs) Handles BotaoAtualizarDados.Click
        atualizar.DesativarCampos()
        atualizar.LimparCamposAtualizacao()
        atualizar.ListarCampos()
        atualizar.ShowDialog()

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BotaoConsultar.Click

        Consultar()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BotaoSalvar.Click
        EstadoCivil()
        Try
            Dim Comando As String = $“INSERT INTO pessoa (nome, sobrenome, endereco, datadenascimento, sexo, estadocivil, email, telefone) VALUES ('{CampoNome.Text}', '{CampoSobrenome.Text}', '{CampoEndereco.Text}', '{CampoData.Text}', '{CampoSexo.SelectedItem}', '{estado}', '{CampoEmail.Text}', '{CampoTelefone.Text}');”
            Dim BancoDeDados As New bancodedados()
            BancoDeDados.Ordem(Comando)
            BancoDeDados.Close()
            MsgBox("Adicionado com Sucesso!")
            Consultar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


End Class
