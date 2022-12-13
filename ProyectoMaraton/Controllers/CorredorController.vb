Imports System.Web.Mvc

Namespace Controllers
    Public Class CorredorController
        Inherits Controller

        ' GET: Corredor
        Function Index() As ActionResult
            Return View()
        End Function

        'Accion Para obtener el monto de la incripccion
        Function CalcularMonto(fecha_nac As Date, nro_corredor As Integer) As Action
            'Determinar el tipo de corredor para crear el objeto
            If nro_corredor > 50 Then
                'crear el objeto de la clase aficionado
                Dim vCorredor As New Aficionado
                'asignamos en las propiedades del objeto los valores del
                vCorredor.pFechaNacimiento = fecha_nac
                vCorredor.pNroCorredor = nro_corredor
                'Retornamos el monto que devuelveel monto de la clase 
                Return Content(vCorredor.CalcularMontoInscripcion)
                'Else
                'si es corredor elite tambien realizamos el mismo procedimiento
                Dim vCorredor As New Elite
                'vCorredor.pFechaNacimiento = fecha_nac
                vCorredor.pNroCorredor = nro_corredor
                Return Content(vCorredor.CalcularMontoInscripcion)

            End If

        End Function
        ' Accion para confirmar la incripccion
        ' Obtenemos los daros desde la vist
        Function Confirmar(form As FormCollection) As ActionResult
            If form("nro_corredor") > 50 Then
                Dim vCorredor As New Aficionado
                vCorredor.pNroCorredor = form("nro_corredor")
                vCorredor.pNroDocumento = form("nro_documento")
                vCorredor.pSexo = form("sexo")
                vCorredor.pNAcionalidad = form("nacionalidad")
                vCorredor.pMontoInscripcion = form("monto_inscripcion")
                'Agregamos los atributos adicionales de la clase afiocionado
                vCorredor.pTelefono = form("telefono")
                vCorredor.pEmail = form("email")
                'retornamos el objeto vcorredor a la vista confirmar
                Return View(vCorredor)
            Else
                'si el corredor es elite tambien asignamoslas mismas propiedades
                'padre
                Dim vCorredor As New Elite
                vCorredor.pNroCorredor = form("nro_corredor")
                vCorredor.pNroDocumento = form("nro_documento")
                vCorredor.pSexo = form("sexo")
                vCorredor.pNAcionalidad = form("nacionalidad")
                vCorredor.pMontoInscripcion = form("monto_inscripcion")
                'asignamos el atributo adicional
                vCorredor.pHotel = form("hotel")
                Return View(vCorredor)

            End If
        End Function

    End Class
End Namespace