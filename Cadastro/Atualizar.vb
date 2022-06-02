Imports Cadastro.Classes

Public Class Atualizar
    Private Sub Atualizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Public Sub PreencherCamposAtualizacao()

        For Each pessoa As Pessoa In Form1.GetListaDePessoas
            If pessoa.Nome = CampoAtualizarPessoa.SelectedItem Then
                AtivarCampos()
                CampoAtualizarNome.Text = pessoa.Nome
                CampoAtualizarData.Text = pessoa.Data
                CampoAtualizarEmail.Text = pessoa.Email
                CampoAtualizarEndereco.Text = pessoa.Endereco
                CampoAtualizarEstadoCivil.SelectedItem = pessoa.EstadoCivil
                CampoAtualizarSobrenome.Text = pessoa.Sobrenome
                CampoAtualizarSexo.SelectedItem = pessoa.Sexo
                CampoAtualizarTelefone.Text = pessoa.Telefone

            End If
        Next
    End Sub

    Private Sub CampoAtualizarPessoa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CampoAtualizarPessoa.SelectedIndexChanged
        PreencherCamposAtualizacao()

    End Sub

    Private Sub BotaoAtualizar_Click(sender As Object, e As EventArgs) Handles BotaoAtualizar.Click
        If CampoAtualizarPessoa.SelectedItem = Nothing Then
            Me.Close()
        Else
            For Each pessoa As Pessoa In Form1.GetListaDePessoas
                If pessoa.Nome = CampoAtualizarPessoa.SelectedItem Then
                    CampoAtualizarPessoa.Items.Remove(pessoa.Nome)
                    pessoa.Nome = CampoAtualizarNome.Text
                    pessoa.Data = CampoAtualizarData.Text
                    pessoa.Email = CampoAtualizarEmail.Text
                    pessoa.Endereco = CampoAtualizarEndereco.Text
                    pessoa.EstadoCivil = CampoAtualizarEstadoCivil.SelectedItem
                    pessoa.Sobrenome = CampoAtualizarSobrenome.Text
                    pessoa.Sexo = CampoAtualizarSexo.SelectedItem
                    pessoa.Telefone = CampoAtualizarTelefone.Text
                End If
                LimparCamposAtualizacao()
                Form1.ListarPessoas(Form1.GetListaDePessoas)
                CampoAtualizarPessoa.SelectedIndex = -1
                Me.Close()

            Next
        End If


    End Sub

    Sub LimparCamposAtualizacao()
        CampoAtualizarNome.Text = Nothing
        CampoAtualizarData.Text = Nothing
        CampoAtualizarEmail.Text = Nothing
        CampoAtualizarEndereco.Text = Nothing
        CampoAtualizarEstadoCivil.SelectedIndex = -1
        CampoAtualizarSobrenome.Text = Nothing
        CampoAtualizarSexo.SelectedIndex = -1
        CampoAtualizarTelefone.Text = Nothing
        CampoAtualizarPessoa.SelectedIndex = -1
        DesativarCampos()

    End Sub

    Sub DesativarCampos()
        CampoAtualizarNome.Enabled = False
        CampoAtualizarData.Enabled = False
        CampoAtualizarEmail.Enabled = False
        CampoAtualizarEndereco.Enabled = False
        CampoAtualizarEstadoCivil.Enabled = False
        CampoAtualizarSobrenome.Enabled = False
        CampoAtualizarSexo.Enabled = False
        CampoAtualizarTelefone.Enabled = False
    End Sub
    Sub AtivarCampos()
        CampoAtualizarNome.Enabled = True
        CampoAtualizarData.Enabled = True
        CampoAtualizarEmail.Enabled = True
        CampoAtualizarEndereco.Enabled = True
        CampoAtualizarEstadoCivil.Enabled = True
        CampoAtualizarSobrenome.Enabled = True
        CampoAtualizarSexo.Enabled = True
        CampoAtualizarTelefone.Enabled = True

    End Sub

End Class


