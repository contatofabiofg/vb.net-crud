<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CampoTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.CampoEstadoCivil = New System.Windows.Forms.GroupBox()
        Me.RadioCasado = New System.Windows.Forms.RadioButton()
        Me.RadioSolteiro = New System.Windows.Forms.RadioButton()
        Me.BotaoLimpar = New System.Windows.Forms.Button()
        Me.BotaoSalvar = New System.Windows.Forms.Button()
        Me.CampoSexo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CampoData = New System.Windows.Forms.MaskedTextBox()
        Me.CampoEndereco = New System.Windows.Forms.TextBox()
        Me.CampoEmail = New System.Windows.Forms.TextBox()
        Me.CampoSobrenome = New System.Windows.Forms.TextBox()
        Me.CampoNome = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CampoTabela = New System.Windows.Forms.ListView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BotaoRemoverNome = New System.Windows.Forms.Button()
        Me.BotaoRemoverId = New System.Windows.Forms.Button()
        Me.CampoRemoverNome = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CampoRemoverId = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BotaoAtualizarDados = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.CampoEstadoCivil.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CampoTelefone)
        Me.GroupBox1.Controls.Add(Me.CampoEstadoCivil)
        Me.GroupBox1.Controls.Add(Me.BotaoLimpar)
        Me.GroupBox1.Controls.Add(Me.BotaoSalvar)
        Me.GroupBox1.Controls.Add(Me.CampoSexo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.CampoData)
        Me.GroupBox1.Controls.Add(Me.CampoEndereco)
        Me.GroupBox1.Controls.Add(Me.CampoEmail)
        Me.GroupBox1.Controls.Add(Me.CampoSobrenome)
        Me.GroupBox1.Controls.Add(Me.CampoNome)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(651, 157)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cadastrar"
        '
        'CampoTelefone
        '
        Me.CampoTelefone.Location = New System.Drawing.Point(334, 83)
        Me.CampoTelefone.Mask = "00-00000-9999"
        Me.CampoTelefone.Name = "CampoTelefone"
        Me.CampoTelefone.Size = New System.Drawing.Size(100, 23)
        Me.CampoTelefone.TabIndex = 6
        '
        'CampoEstadoCivil
        '
        Me.CampoEstadoCivil.Controls.Add(Me.RadioCasado)
        Me.CampoEstadoCivil.Controls.Add(Me.RadioSolteiro)
        Me.CampoEstadoCivil.Location = New System.Drawing.Point(445, 69)
        Me.CampoEstadoCivil.Name = "CampoEstadoCivil"
        Me.CampoEstadoCivil.Size = New System.Drawing.Size(200, 43)
        Me.CampoEstadoCivil.TabIndex = 19
        Me.CampoEstadoCivil.TabStop = False
        Me.CampoEstadoCivil.Text = "Estado Civil"
        '
        'RadioCasado
        '
        Me.RadioCasado.AutoSize = True
        Me.RadioCasado.Location = New System.Drawing.Point(16, 18)
        Me.RadioCasado.Name = "RadioCasado"
        Me.RadioCasado.Size = New System.Drawing.Size(78, 19)
        Me.RadioCasado.TabIndex = 7
        Me.RadioCasado.TabStop = True
        Me.RadioCasado.Text = "Casado(a)"
        Me.RadioCasado.UseVisualStyleBackColor = True
        '
        'RadioSolteiro
        '
        Me.RadioSolteiro.AutoSize = True
        Me.RadioSolteiro.Location = New System.Drawing.Point(100, 18)
        Me.RadioSolteiro.Name = "RadioSolteiro"
        Me.RadioSolteiro.Size = New System.Drawing.Size(79, 19)
        Me.RadioSolteiro.TabIndex = 8
        Me.RadioSolteiro.TabStop = True
        Me.RadioSolteiro.Text = "Solteiro(a)"
        Me.RadioSolteiro.UseVisualStyleBackColor = True
        '
        'BotaoLimpar
        '
        Me.BotaoLimpar.Location = New System.Drawing.Point(570, 128)
        Me.BotaoLimpar.Name = "BotaoLimpar"
        Me.BotaoLimpar.Size = New System.Drawing.Size(75, 23)
        Me.BotaoLimpar.TabIndex = 10
        Me.BotaoLimpar.Text = "Limpar"
        Me.BotaoLimpar.UseVisualStyleBackColor = True
        '
        'BotaoSalvar
        '
        Me.BotaoSalvar.Location = New System.Drawing.Point(489, 128)
        Me.BotaoSalvar.Name = "BotaoSalvar"
        Me.BotaoSalvar.Size = New System.Drawing.Size(75, 23)
        Me.BotaoSalvar.TabIndex = 9
        Me.BotaoSalvar.Text = "Salvar"
        Me.BotaoSalvar.UseVisualStyleBackColor = True
        '
        'CampoSexo
        '
        Me.CampoSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CampoSexo.FormattingEnabled = True
        Me.CampoSexo.Items.AddRange(New Object() {"M", "F"})
        Me.CampoSexo.Location = New System.Drawing.Point(538, 37)
        Me.CampoSexo.Name = "CampoSexo"
        Me.CampoSexo.Size = New System.Drawing.Size(79, 23)
        Me.CampoSexo.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(538, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Sexo"
        '
        'CampoData
        '
        Me.CampoData.Location = New System.Drawing.Point(6, 81)
        Me.CampoData.Mask = "00/00/0000"
        Me.CampoData.Name = "CampoData"
        Me.CampoData.Size = New System.Drawing.Size(100, 23)
        Me.CampoData.TabIndex = 4
        Me.CampoData.ValidatingType = GetType(Date)
        '
        'CampoEndereco
        '
        Me.CampoEndereco.Location = New System.Drawing.Point(334, 37)
        Me.CampoEndereco.Name = "CampoEndereco"
        Me.CampoEndereco.Size = New System.Drawing.Size(186, 23)
        Me.CampoEndereco.TabIndex = 2
        '
        'CampoEmail
        '
        Me.CampoEmail.Location = New System.Drawing.Point(134, 81)
        Me.CampoEmail.Name = "CampoEmail"
        Me.CampoEmail.Size = New System.Drawing.Size(166, 23)
        Me.CampoEmail.TabIndex = 5
        '
        'CampoSobrenome
        '
        Me.CampoSobrenome.Location = New System.Drawing.Point(134, 37)
        Me.CampoSobrenome.Name = "CampoSobrenome"
        Me.CampoSobrenome.Size = New System.Drawing.Size(166, 23)
        Me.CampoSobrenome.TabIndex = 1
        '
        'CampoNome
        '
        Me.CampoNome.Location = New System.Drawing.Point(6, 37)
        Me.CampoNome.Name = "CampoNome"
        Me.CampoNome.Size = New System.Drawing.Size(100, 23)
        Me.CampoNome.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(334, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Celular(com DDD)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(334, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Endereço"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(134, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "E-mail"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(134, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sobrenome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Data de Nascimento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome"
        '
        'CampoTabela
        '
        Me.CampoTabela.Location = New System.Drawing.Point(18, 210)
        Me.CampoTabela.Name = "CampoTabela"
        Me.CampoTabela.Size = New System.Drawing.Size(1159, 107)
        Me.CampoTabela.TabIndex = 1
        Me.CampoTabela.UseCompatibleStateImageBehavior = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BotaoRemoverNome)
        Me.GroupBox2.Controls.Add(Me.BotaoRemoverId)
        Me.GroupBox2.Controls.Add(Me.CampoRemoverNome)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.CampoRemoverId)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(678, 26)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(229, 157)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Apagar Dados"
        '
        'BotaoRemoverNome
        '
        Me.BotaoRemoverNome.Location = New System.Drawing.Point(112, 89)
        Me.BotaoRemoverNome.Name = "BotaoRemoverNome"
        Me.BotaoRemoverNome.Size = New System.Drawing.Size(75, 23)
        Me.BotaoRemoverNome.TabIndex = 21
        Me.BotaoRemoverNome.Text = "Remover"
        Me.BotaoRemoverNome.UseVisualStyleBackColor = True
        '
        'BotaoRemoverId
        '
        Me.BotaoRemoverId.Location = New System.Drawing.Point(112, 39)
        Me.BotaoRemoverId.Name = "BotaoRemoverId"
        Me.BotaoRemoverId.Size = New System.Drawing.Size(75, 23)
        Me.BotaoRemoverId.TabIndex = 20
        Me.BotaoRemoverId.Text = "Remover"
        Me.BotaoRemoverId.UseVisualStyleBackColor = True
        '
        'CampoRemoverNome
        '
        Me.CampoRemoverNome.Location = New System.Drawing.Point(6, 89)
        Me.CampoRemoverNome.Name = "CampoRemoverNome"
        Me.CampoRemoverNome.Size = New System.Drawing.Size(100, 23)
        Me.CampoRemoverNome.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 15)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Remover pelo Nome"
        '
        'CampoRemoverId
        '
        Me.CampoRemoverId.Location = New System.Drawing.Point(6, 40)
        Me.CampoRemoverId.Name = "CampoRemoverId"
        Me.CampoRemoverId.Size = New System.Drawing.Size(100, 23)
        Me.CampoRemoverId.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 15)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Remover pelo Id"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 15)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Pessoas Cadastradas"
        '
        'BotaoAtualizarDados
        '
        Me.BotaoAtualizarDados.Location = New System.Drawing.Point(928, 33)
        Me.BotaoAtualizarDados.Name = "BotaoAtualizarDados"
        Me.BotaoAtualizarDados.Size = New System.Drawing.Size(132, 23)
        Me.BotaoAtualizarDados.TabIndex = 4
        Me.BotaoAtualizarDados.Text = "AtualizarDados"
        Me.BotaoAtualizarDados.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1189, 450)
        Me.Controls.Add(Me.BotaoAtualizarDados)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.CampoTabela)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.CampoEstadoCivil.ResumeLayout(False)
        Me.CampoEstadoCivil.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CampoSobrenome As TextBox
    Friend WithEvents CampoNome As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioSolteiro As RadioButton
    Friend WithEvents RadioCasado As RadioButton
    Friend WithEvents CampoData As MaskedTextBox
    Friend WithEvents CampoEndereco As TextBox
    Friend WithEvents CampoEmail As TextBox
    Friend WithEvents CampoSexo As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BotaoLimpar As Button
    Friend WithEvents BotaoSalvar As Button
    Friend WithEvents CampoTabela As ListView
    Friend WithEvents CampoEstadoCivil As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CampoRemoverId As TextBox
    Friend WithEvents BotaoRemoverNome As Button
    Friend WithEvents BotaoRemoverId As Button
    Friend WithEvents CampoRemoverNome As TextBox
    Friend WithEvents CampoTelefone As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents BotaoAtualizarDados As Button
End Class
