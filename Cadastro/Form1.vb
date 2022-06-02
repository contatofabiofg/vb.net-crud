Imports Cadastro.Classes
Imports Cadastro

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
        CampoTabela.Columns.Add("Telefone", 80, HorizontalAlignment.Center)



        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub
#End Region

#Region "VARIÁVEIS GLOBAIS"
    Dim contador As Integer = 1
    Dim ListaDePessoas As New List(Of Pessoa)
    Dim pessoaPraRemover As Pessoa
    Dim atualizar As New Atualizar

#End Region



    Private Sub BotaoSalvar_Click(sender As Object, e As EventArgs) Handles BotaoSalvar.Click
        Dim estadocivil As String
        If RadioCasado.Checked Then
            estadocivil = "Casado(a)"
        Else
            estadocivil = "Solteiro(a)"
        End If

        If ValidarCampos() Then
            Dim pessoa As New Pessoa(CampoNome.Text, CampoSobrenome.Text, CampoEndereco.Text, CampoSexo.Text, CampoData.Text, CampoEmail.Text, CampoTelefone.Text, estadocivil, contador)
            contador += 1
            ListaDePessoas.Add(pessoa)

            ListarPessoas(ListaDePessoas)
        End If



    End Sub

    Sub ListarPessoas(vpessoa As List(Of Pessoa))
        CampoTabela.Items.Clear()
        atualizar.CampoAtualizarPessoa.Items.Clear()

        For i As Integer = 0 To ListaDePessoas.Count - 1
            Dim Linha As New ListViewItem
            Linha.Name = vpessoa(i).Id
            Linha.Text = vpessoa(i).Id
            Linha.SubItems.Add($"{ListaDePessoas(i).Nome} {ListaDePessoas(i).Sobrenome}")
            Linha.SubItems.Add(ListaDePessoas(i).Endereco)
            Linha.SubItems.Add(ListaDePessoas(i).Sexo)
            Linha.SubItems.Add(ListaDePessoas(i).Data)
            Linha.SubItems.Add(ListaDePessoas(i).Email)
            Linha.SubItems.Add(ListaDePessoas(i).EstadoCivil)
            Linha.SubItems.Add(ListaDePessoas(i).Telefone.ToString)
            CampoTabela.Items.Add(Linha)

            atualizar.CampoAtualizarPessoa.Items.Add(ListaDePessoas(i).Nome)
            ApagarCampos()

        Next
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
        If ListaDePessoas.Count <> 0 Then
            If CampoRemoverId.Text = Nothing Then
                MsgBox("Preencha o campo com o Id.")
            Else
                Try
                    For Each pessoa As Pessoa In ListaDePessoas
                        If pessoa.Id = Val(CampoRemoverId.Text) Then
                            pessoaPraRemover = pessoa
                        End If
                    Next
                    confirmacao = MsgBox($"Tem certeza que deseja remover {pessoaPraRemover.Nome}?", MsgBoxStyle.YesNo, "Remover")
                    If confirmacao = 6 Then
                        ListaDePessoas.Remove(pessoaPraRemover)
                        ListarPessoas(ListaDePessoas)
                    End If
                Catch ex As Exception
                    MsgBox("Revise os campos")
                End Try
            End If

        End If

        pessoaPraRemover = Nothing
    End Sub

    Private Sub BotaoRemoverNome_Click(sender As Object, e As EventArgs) Handles BotaoRemoverNome.Click
        Dim confirmacao As Integer
        If ListaDePessoas.Count <> 0 Then
            If CampoRemoverNome.Text = Nothing Then
                MsgBox("Preencha o campo com o Nome.")
            Else
                Try
                    For Each pessoa As Pessoa In ListaDePessoas
                        If pessoa.Nome = CampoRemoverNome.Text Then
                            pessoaPraRemover = pessoa
                        End If
                    Next
                    confirmacao = MsgBox($"Tem certeza que deseja remover {pessoaPraRemover.Nome}?", MsgBoxStyle.YesNo, "Remover")
                    If confirmacao = 6 Then
                        ListaDePessoas.Remove(pessoaPraRemover)
                        ListarPessoas(ListaDePessoas)
                    End If
                Catch ex As Exception
                    MsgBox("Revise os campos")
                End Try
            End If
        End If

        pessoaPraRemover = Nothing
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

    Private Sub BotaoAtualizarDados_Click(sender As Object, e As EventArgs) Handles BotaoAtualizarDados.Click
        atualizar.DesativarCampos()
        atualizar.LimparCamposAtualizacao()
        atualizar.ShowDialog()

    End Sub

    Public Function GetListaDePessoas()
        Return ListaDePessoas
    End Function
End Class
