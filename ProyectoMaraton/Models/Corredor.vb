'Con MustInherit indicamos que corredor sera la clase padre
Public MustInherit Class Corredor
    ' Atributos de la clase corredor

    Protected NroCorredor As Integer
    Protected NroDocumento As String
    Protected Nombre As String
    Protected FechaNacimiento As Date
    Protected Sexo As String
    Protected Nacionalidad As String
    Protected MontoInscripcion As Integer
    'Propiedades de la clase
    Public Property pNroCorredor As Integer
        Get
            Return Me.NroCorredor
        End Get
        Set(value As Integer)
            Me.NroCorredor = value

        End Set
    End Property

    Public Property pNroDocumento As String
        Get
            Return Me.NroDocumento
        End Get
        Set(value As String)
            Me.NroDocumento = value
        End Set
    End Property
    Public Property pFechaNacimiento As Date
        Get
            Return Me.FechaNacimiento
        End Get
        Set(value As Date)
            Me.FechaNacimiento = value
        End Set
    End Property
    Public Property pSexo As String
        Get
            Return Me.Sexo
        End Get
        Set(value As String)
            Me.Sexo = value
        End Set
    End Property
    Public Property pNAcionalidad As String
        Get
            Return Me.Nacionalidad
        End Get
        Set(value As String)
            Me.Nacionalidad = value
        End Set
    End Property
    Public Property pMontoInscripcion As Integer
        Get
            Return Me.MontoInscripcion
        End Get
        Set(value As Integer)
            Me.MontoInscripcion = value
        End Set
    End Property
    Public Property pNombre As String
        Get
            Return Me.Nombre
        End Get
        Set(value As String)
            Me.Nombre = value

        End Set
    End Property
    'Metodo para calcular el monto de la inscripcion
    Function CalcularMontoInscripcion() As Integer
        Dim vMonto As Integer = 0
        Dim vEdad As Integer = 0
        'determinar el tipo de corredor
        If Me.NroCorredor > 50 Then 'es corredor aficionado
            'calcular la edad
            vEdad = DateDiff(DateInterval.Year, Me.FechaNacimiento, Date.Today)
            Select Case vEdad
                Case 18 To 29
                    vMonto = 40
                Case 30 To 39
                    vMonto = 30
                Case > 39
                    vMonto = 20
            End Select

        Else ' de 0 a 50 corredor elite
            vMonto = 0
        End If
        'retornar el monto
        Return vMonto
    End Function
End Class

'Definicion de clases hijas
Public Class Elite
    Inherits Corredor
    Private Hotel As String
    Public Property pHotel As String
        Get
            Return Me.Hotel
        End Get
        Set(value As String)
            Me.Hotel = value
        End Set
    End Property
End Class
Public Class Aficionado
    Inherits Corredor
    Private Telefono As String
    Private Email As String
    Public Property pTelefono As String
        Get
            Return Me.Telefono
        End Get
        Set(value As String)
            Me.Telefono = value
        End Set
    End Property

    Public Property pEmail As String
        Get
            Return Me.Email
        End Get
        Set(value As String)
            Me.Email = value
        End Set
    End Property
End Class