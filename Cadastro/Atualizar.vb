Imports Cadastro.Classes
Imports Cadastro.Classes.bancodedados

Public Class Atualizar
    Private Sub Atualizar_Load(sender As Object, e As EventArgs) Handles MyBase.Closed

        LimparCamposAtualizacao()
        DesativarCampos()

    End Sub

    Sub PreencherCamposAtualizacao()

        AtivarCampos()
        Dim TabelaDoBanco As DataTable
        TabelaDoBanco = Form1.Buscar("nome", CampoAtualizarPessoa.SelectedItem)

        CampoAtualizarNome.Text = TabelaDoBanco.Rows(0)("nome")
        CampoAtualizarData.Text = TabelaDoBanco.Rows(0)("datadenascimento")
        CampoAtualizarEmail.Text = TabelaDoBanco.Rows(0)("email")
        CampoAtualizarEndereco.Text = TabelaDoBanco.Rows(0)("endereco")
        CampoAtualizarEstadoCivil.SelectedItem = TabelaDoBanco.Rows(0)("estadocivil")
        CampoAtualizarSobrenome.Text = TabelaDoBanco.Rows(0)("sobrenome")
        CampoAtualizarSexo.SelectedItem = TabelaDoBanco.Rows(0)("sexo")
        CampoAtualizarTelefone.Text = TabelaDoBanco.Rows(0)("telefone")


    End Sub


    Private Sub CampoAtualizarPessoa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CampoAtualizarPessoa.SelectedIndexChanged
        If Me.Visible = True Then
            PreencherCamposAtualizacao()
        End If

    End Sub

    Private Sub BotaoAtualizar_Click(sender As Object, e As EventArgs) Handles BotaoAtualizar.Click
        If CampoAtualizarPessoa.SelectedItem = Nothing Then
            Me.Close()
        Else

            Dim TabelaDoBanco As DataTable
            TabelaDoBanco = Form1.Buscar("nome", CampoAtualizarPessoa.SelectedItem)



            Try
                Dim Comando As String = $“Update pessoa SET nome = '{CampoAtualizarNome.Text}', sobrenome = '{CampoAtualizarSobrenome.Text}', endereco = '{CampoAtualizarEndereco.Text}', datadenascimento = '{CampoAtualizarData.Text}', sexo = '{CampoAtualizarSexo.SelectedItem}', estadocivil = '{CampoAtualizarEstadoCivil.SelectedItem}', email = '{CampoAtualizarEmail.Text}', telefone = '{CampoAtualizarTelefone.Text}' WHERE nome = '{CampoAtualizarPessoa.SelectedItem}';”
                Dim BancoDeDados As New bancodedados()
                BancoDeDados.Ordem(Comando)
                BancoDeDados.Close()
                MsgBox("Atualizado com Sucesso!")
                Me.Close()
                Form1.Consultar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try




            'For Each pessoa As Pessoa In Form1.GetListaDePessoas
            '    If pessoa.Nome = CampoAtualizarPessoa.SelectedItem Then
            '        CampoAtualizarPessoa.Items.Remove(pessoa.Nome)
            '        pessoa.Nome = CampoAtualizarNome.Text
            '        pessoa.Data = CampoAtualizarData.Text
            '        pessoa.Email = CampoAtualizarEmail.Text
            '        pessoa.Endereco = CampoAtualizarEndereco.Text
            '        pessoa.EstadoCivil = CampoAtualizarEstadoCivil.SelectedItem
            '        pessoa.Sobrenome = CampoAtualizarSobrenome.Text
            '        pessoa.Sexo = CampoAtualizarSexo.SelectedItem
            '        pessoa.Telefone = CampoAtualizarTelefone.Text
            '    End If
            '    LimparCamposAtualizacao()
            '    Form1.ListarPessoas(Form1.GetListaDePessoas)
            '    CampoAtualizarPessoa.SelectedIndex = -1
            '    Me.Close()

            'Next
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
    Sub ListarCampos()
        CampoAtualizarPessoa.Items.Clear()
        Dim TabelaDoBanco As DataTable
        TabelaDoBanco = Form1.BuscarNoBanco()
        For i As Integer = 0 To TabelaDoBanco.Rows.Count - 1
            CampoAtualizarPessoa.Items.Add(TabelaDoBanco.Rows(i)("nome"))
        Next
    End Sub

End Class


