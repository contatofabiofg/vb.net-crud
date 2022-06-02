Namespace Classes
    Public Class Pessoa

#Region "PROPRIEDADES"
        Private _Id As Integer
        Public ReadOnly Property Id As Integer
            Get
                Return _Id
            End Get
        End Property

        Private _Nome As String
        Public Property Nome As String
            Get
                Return _Nome
            End Get
            Set(value As String)
                _Nome = value
            End Set

        End Property

        Private _Sobrenome As String
        Public Property Sobrenome As String
            Get
                Return _Sobrenome
            End Get
            Set(value As String)
                _Sobrenome = value
            End Set
        End Property

        Private _Endereco As String

        Public Property Endereco As String
            Get
                Return _Endereco
            End Get
            Set(value As String)
                _Endereco = value
            End Set
        End Property

        Private _Sexo As String
        Public Property Sexo As String
            Get
                Return _Sexo
            End Get
            Set(value As String)
                _Sexo = value
            End Set
        End Property

        Private _Data As String
        Public Property Data As String
            Get
                Return _Data
            End Get
            Set(value As String)
                _Data = value
            End Set
        End Property

        Private _Email As String
        Public Property Email As String
            Get
                Return _Email
            End Get
            Set(value As String)
                _Email = value
            End Set
        End Property

        Private _Telefone As String
        Public Property Telefone As String
            Get
                Return _Telefone
            End Get
            Set(value As String)
                _Telefone = value
            End Set
        End Property

        Private _EstadoCivil As String
        Public Property EstadoCivil As String
            Get
                Return _EstadoCivil
            End Get
            Set(value As String)
                _EstadoCivil = value
            End Set
        End Property


#End Region

#Region "CONSTRUTORES"
        Public Sub New(Nome As String, Sobrenome As String, Endereco As String, Sexo As String, Data As String, Email As String, Telefone As String, EstadoCivil As String, contador As Integer)

            _Nome = Nome
            _Sobrenome = Sobrenome
            _Endereco = Endereco
            _Sexo = Sexo
            _Data = Data
            _Email = Email
            _Telefone = Telefone
            _EstadoCivil = EstadoCivil
            _Id = contador

        End Sub


#End Region

#Region "MÉTODOS"



#End Region







    End Class
End Namespace


