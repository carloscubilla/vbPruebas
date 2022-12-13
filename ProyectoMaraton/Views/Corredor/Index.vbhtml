
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Datos del corredor</title>
</head>
<body>
    <div> }
    <h2> Datos del corredor</h2>
    <form action="../Corredor/confirmar" method="post">
        <table>
            <tr>
                <td>Nro. Corredor</td>
                <td><input type="text" name="nro_corredor" id="nro_corredor" /></td>
            </tr>
            <tr>
                <td>Nro. Documento</td>
                <td><input type="text" name="nro_Documento id=" nro_documento /></td>
            </tr>
            <tr>
                <td>Nombre</td>
                <td><input type="text" id="nombre" /></td>
            </tr>
            <tr>
                <td>Fecha Nacimiento</td>
                <td><input type="text" name="fecha_nacimiento" /></td>
            </tr>
            <tr>
                <td>Sexo</td>
                <td>
                    <select>
                        name="sexo" id="sexo"
                        <option value="M"> Masculino</option>
                        <option value="F"> Femenino</option>
                    </select>

                </td>
            </tr>
            <tr>
                <td>Nacionalidad</td>
                <td>
                    <input type="text" name="nacionalidad" id="nacionalidad" />
                </td>
            </tr>
            <tr>
                <td>Monto Inscripcion</td>
                <td>
                    <input type="text" name="monto_inscripcion" />
                </td>
            </tr>
            <tr>
                <td>Hotel</td>
                <td>
                    <input type="text" name="hotel" id="hotel" />
                </td>
            </tr>
            <tr>
                <td>Telefono</td>
                <td>
                    <input type="text" name="telefono" id="telefono" />
                </td>
            </tr>
            <tr>
                <td>Email</td>
                <td>
                    <input type="text" name="email" id="email" />
                </td>
            </tr>

        </table>
        <input type="button" id="btn_calcular" value="Calcular Monto" />
        <input type="submit" id="btn_confirmar "value="confirmar" />

    </form>
    </div>
</body>
</html>
