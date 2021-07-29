Public Class Cliente
    Inherits Persona

    'Atributos
    Private _categoria As String
    Private _codigo As String

    'Propiedades
    Public Property Categoria As String
        Get
            Return _categoria
        End Get
        Set(value As String)
            _categoria = value
        End Set
    End Property

    Public Property Codigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property

    'Operación
    Public Sub generarCodigo()
        Me.Codigo = "C" & Me.Apellidos.Substring(0, 3) + "16"
    End Sub
End Class
