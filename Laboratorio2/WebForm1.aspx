<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registro de Alumno</title>
    <script type="text/javascript">

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div>
                <h1>Registro de alumno</h1>
            </div>
            <div>
                <label>Nombres: </label>
                <input type="text" placeholder="Nombre" />
            </div>
            <div>
                <label>Apellidos: </label>
                <input type="text" placeholder="Apellidos" />
            </div>
            <div>
                
            </div>
            <div>
                <label>Correo: </label>
                <input type="text" placeholder="example@mail.com" />
            </div>
            <div>
                <label>Direccion: </label>
                <input type="text" placeholder="example@mail.com" />
                <label>Ciudad: </label>
                <select name="ciudad" id="city">
                    <option value="Arequipa">Arequipa</option>
                    <option value="Lima">Lima</option>
                    <option value="Cusco">Cusco</option>
                    <option value="Trujillo">Trujillo</option>
                </select>
            </div>
            <div>
                <label>Requerimiento: </label><br />
                <textarea></textarea>
                <div>
                    <button type="button" class="btn btn-primary">Limpiar</button>
                    <button>Enviar</button>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
