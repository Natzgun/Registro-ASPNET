<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Auxiliar.aspx.cs" Inherits="Laboratorio2.Auxiliar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <title>Cookies Estudiante</title>
    <script defer src="/Scripts/bootstrap.js"></script>
    <script src="./Scripts/jquery-3.4.1.js"></script>
    <script defer type="text/javascript">
        function callAjax() {
            //alert('Algo');
            let send = $('#areaCookie').val();
            $.ajax({
                url: 'Auxiliar.aspx/getInformacion',
                type: 'POST',
                async: true,
                data: '{ valor: "' + send + '" }',
                dataType: "json",
                contentType: "application/json; charset=utf-8",
                success: exito,
            });
            return false;
        }
        function exito(data) {
            var returnS = data.d;
            $('#TextBoxAjax').val(data.d);
            $('#TextBoxAjax').css("visibility", "visible");
            return false;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class=" mt-4 mb-2 row">
                <div class="col">
                    <asp:Label ID="LabelUsuario" runat="server" Text="Usuario" CssClass="form-label"></asp:Label>
                </div>
            </div>
            <div class="mb-2 row">
                <div class="col">
                    <asp:Label ID="LabelNombre" runat="server" Text="Nombre" CssClass="form-label"></asp:Label>
                </div>
            </div>
            <div class="mb-2 row">
                <div class="col">
                    <asp:Label ID="LabelApellido" runat="server" Text="Apellido" CssClass="form-label"></asp:Label>
                </div>
            </div>

            <div class="mb-2">
                <asp:Button ID="ButtonCookie" class="btn btn-dark" UseSubmitBehavior="false" runat="server" Text="Mostrar Cookie" OnClick="ButtonCookie_Click" />
            </div>
            <div class="mb-2 row">
                <div class="col-md-6">
                    <asp:TextBox ID="areaCookie" runat="server" Rows="4" class="form-control" placeholder="Requerimiento"></asp:TextBox>
                </div>
            </div>


            <div class="row mt-3">
                <div class="cols-sm-2">
                    <asp:Button ID="ButtonAjax" runat="server" Text="Ajax"
                        OnClientClick="return callAjax();" class="btn btn-success btn-lg" />
                </div>
            </div>
            <div class="row">
                <div class="form-group row mt-3">
                    <div class="col-sm-9">
                        <div class="form-floating row mt-3">
                            <asp:TextBox ID="TextBoxAjax" runat="server" class="form-control"
                                Style="visibility: hidden"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </form>
</body>
</html>
