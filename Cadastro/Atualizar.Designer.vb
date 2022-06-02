<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Atualizar
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CampoAtualizarPessoa = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CampoAtualizarNome = New System.Windows.Forms.TextBox()
        Me.CampoAtualizarSobrenome = New System.Windows.Forms.TextBox()
        Me.CampoAtualizarEndereco = New System.Windows.Forms.TextBox()
        Me.CampoAtualizarEmail = New System.Windows.Forms.TextBox()
        Me.CampoAtualizarSexo = New System.Windows.Forms.ComboBox()
        Me.CampoAtualizarEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.CampoAtualizarTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.CampoAtualizarData = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BotaoAtualizar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CampoAtualizarPessoa
        '
        Me.CampoAtualizarPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CampoAtualizarPessoa.FormattingEnabled = True
        Me.CampoAtualizarPessoa.Location = New System.Drawing.Point(12, 57)
        Me.CampoAtualizarPessoa.Name = "CampoAtualizarPessoa"
        Me.CampoAtualizarPessoa.Size = New System.Drawing.Size(121, 23)
        Me.CampoAtualizarPessoa.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Selecione a Pessoa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Sobrenome"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Endereço"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(156, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Sexo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Telefone"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 332)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 15)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Estado Civil"
        '
        'CampoAtualizarNome
        '
        Me.CampoAtualizarNome.Location = New System.Drawing.Point(15, 118)
        Me.CampoAtualizarNome.Name = "CampoAtualizarNome"
        Me.CampoAtualizarNome.Size = New System.Drawing.Size(148, 23)
        Me.CampoAtualizarNome.TabIndex = 10
        '
        'CampoAtualizarSobrenome
        '
        Me.CampoAtualizarSobrenome.Location = New System.Drawing.Point(15, 162)
        Me.CampoAtualizarSobrenome.Name = "CampoAtualizarSobrenome"
        Me.CampoAtualizarSobrenome.Size = New System.Drawing.Size(160, 23)
        Me.CampoAtualizarSobrenome.TabIndex = 11
        '
        'CampoAtualizarEndereco
        '
        Me.CampoAtualizarEndereco.Location = New System.Drawing.Point(15, 206)
        Me.CampoAtualizarEndereco.Name = "CampoAtualizarEndereco"
        Me.CampoAtualizarEndereco.Size = New System.Drawing.Size(269, 23)
        Me.CampoAtualizarEndereco.TabIndex = 12
        '
        'CampoAtualizarEmail
        '
        Me.CampoAtualizarEmail.Location = New System.Drawing.Point(156, 297)
        Me.CampoAtualizarEmail.Name = "CampoAtualizarEmail"
        Me.CampoAtualizarEmail.Size = New System.Drawing.Size(100, 23)
        Me.CampoAtualizarEmail.TabIndex = 15
        '
        'CampoAtualizarSexo
        '
        Me.CampoAtualizarSexo.FormattingEnabled = True
        Me.CampoAtualizarSexo.Items.AddRange(New Object() {"M", "F"})
        Me.CampoAtualizarSexo.Location = New System.Drawing.Point(15, 250)
        Me.CampoAtualizarSexo.Name = "CampoAtualizarSexo"
        Me.CampoAtualizarSexo.Size = New System.Drawing.Size(68, 23)
        Me.CampoAtualizarSexo.TabIndex = 16
        '
        'CampoAtualizarEstadoCivil
        '
        Me.CampoAtualizarEstadoCivil.FormattingEnabled = True
        Me.CampoAtualizarEstadoCivil.Items.AddRange(New Object() {"Casado(a)", "Solteiro(a)"})
        Me.CampoAtualizarEstadoCivil.Location = New System.Drawing.Point(17, 350)
        Me.CampoAtualizarEstadoCivil.Name = "CampoAtualizarEstadoCivil"
        Me.CampoAtualizarEstadoCivil.Size = New System.Drawing.Size(121, 23)
        Me.CampoAtualizarEstadoCivil.TabIndex = 17
        '
        'CampoAtualizarTelefone
        '
        Me.CampoAtualizarTelefone.Location = New System.Drawing.Point(17, 297)
        Me.CampoAtualizarTelefone.Name = "CampoAtualizarTelefone"
        Me.CampoAtualizarTelefone.Size = New System.Drawing.Size(116, 23)
        Me.CampoAtualizarTelefone.TabIndex = 18
        '
        'CampoAtualizarData
        '
        Me.CampoAtualizarData.Location = New System.Drawing.Point(156, 250)
        Me.CampoAtualizarData.Name = "CampoAtualizarData"
        Me.CampoAtualizarData.Size = New System.Drawing.Size(100, 23)
        Me.CampoAtualizarData.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(156, 232)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 15)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Data de Nascimento"
        '
        'BotaoAtualizar
        '
        Me.BotaoAtualizar.Location = New System.Drawing.Point(17, 394)
        Me.BotaoAtualizar.Name = "BotaoAtualizar"
        Me.BotaoAtualizar.Size = New System.Drawing.Size(75, 23)
        Me.BotaoAtualizar.TabIndex = 21
        Me.BotaoAtualizar.Text = "Atualizar"
        Me.BotaoAtualizar.UseVisualStyleBackColor = True
        '
        'Atualizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 450)
        Me.Controls.Add(Me.BotaoAtualizar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CampoAtualizarData)
        Me.Controls.Add(Me.CampoAtualizarTelefone)
        Me.Controls.Add(Me.CampoAtualizarEstadoCivil)
        Me.Controls.Add(Me.CampoAtualizarSexo)
        Me.Controls.Add(Me.CampoAtualizarEmail)
        Me.Controls.Add(Me.CampoAtualizarEndereco)
        Me.Controls.Add(Me.CampoAtualizarSobrenome)
        Me.Controls.Add(Me.CampoAtualizarNome)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CampoAtualizarPessoa)
        Me.Name = "Atualizar"
        Me.Text = "Atualizar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CampoAtualizarPessoa As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CampoAtualizarNome As TextBox
    Friend WithEvents CampoAtualizarSobrenome As TextBox
    Friend WithEvents CampoAtualizarEndereco As TextBox
    Friend WithEvents CampoAtualizarEmail As TextBox
    Friend WithEvents CampoAtualizarSexo As ComboBox
    Friend WithEvents CampoAtualizarEstadoCivil As ComboBox
    Friend WithEvents CampoAtualizarTelefone As MaskedTextBox
    Friend WithEvents CampoAtualizarData As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BotaoAtualizar As Button
End Class
