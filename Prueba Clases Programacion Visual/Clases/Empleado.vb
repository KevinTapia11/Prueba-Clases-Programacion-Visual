Public Class Empleado
    Inherits Persona

    'Atributos
    Private _tipoContrato As String
    Private _sueldo As Double

    'Propiedades
    Public Property TipoContrato As String
        Get
            Return _tipoContrato
        End Get
        Set(value As String)
            _tipoContrato = value
        End Set
    End Property
    Public Property Sueldo As Double
        Get
            Return _sueldo
        End Get
        Set(value As Double)
            _sueldo = value
        End Set
    End Property

    'Operaciones
    Public Sub calcularSueldo(sueldoBase As Double)

        If (Me.TipoContrato = "C") Then
            Me.Sueldo = sueldoBase + 350
        ElseIf (Me.TipoContrato = "N") Then
            Me.Sueldo = sueldoBase + 750
        Else
            Me.Sueldo = 0
        End If
    End Sub
End Class
