<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormStudents.aspx.cs" Inherits="Laboratorio2.FormStudents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <title>Formulario estudiante</title>
    <script defer type="text/javascript" src="/Scripts/Forms/formStudent.js"></script>
    <script defer src="/Scripts/bootstrap.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container" id="formularioEstudiantes">
                <div class="mt-4 mb-4">
                    <h1>Registro de alumno</h1>
                </div>
                <div class="mb-3 row">
                    <div class="col-md-2">
                        <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
                    </div>
                    <div class="col-md-4">
                        <asp:TextBox ID="nameInput" runat="server" type="text" class="form-control" placeholder="Nombre"></asp:TextBox>
                    </div>
                </div>

                <div class="mb-3 row">
                    <div class="col-md-2">
                        <asp:Label ID="Label2" runat="server" Text="Apellidos:"></asp:Label>
                    </div>
                    <div class="col-md-4">
                        <asp:TextBox ID="apellidoInput" runat="server" class="form-control" type="text" placeholder="Apellidos"></asp:TextBox>
                    </div>

                </div>
                <div class="mb-3 row">
                    <div class="col-md-2">
                        <asp:Label ID="Label3" runat="server" Text="Sexo:"></asp:Label>
                    </div>
                    <div class="col-md-4">
                        <asp:RadioButton ID="radioM" runat="server" GroupName="sexo" />
                        <asp:Label ID="Label4" runat="server" Text="Masculino"></asp:Label>
                        <asp:RadioButton ID="radioF" runat="server" GroupName="sexo" />
                        <asp:Label ID="Label5" runat="server" Text="Femenino"></asp:Label>
                    </div>
                </div>
                <div class="mb-3 row">
                    <div class="col-md-2">
                        <asp:Label ID="Label6" runat="server" Text="Correo:"></asp:Label>

                    </div>
                    <div class="col-md-4">
                        <asp:TextBox ID="emailInput" runat="server" class="form-control" type="email" placeholder="example@mail.com"></asp:TextBox>

                    </div>
                </div>
                <div class="mb-3 row">
                    <div class="col-md-3">
                        <asp:Label ID="Label7" runat="server" Text="Direccion:"></asp:Label>
                        <asp:TextBox ID="addressInput" runat="server" class="form-control" type="text" placeholder="Ingresa aqui tu direccion"></asp:TextBox>
                    </div>
                    <div class="col-md-3">
                        <asp:Label ID="Label8" runat="server" Text="Ciudad:"></asp:Label>
                        <asp:DropDownList ID="DropDownList1" class="form-select" runat="server">
                            <asp:ListItem id="primer" Text="Seleccione una opción" Value="0"></asp:ListItem>
                        </asp:DropDownList>
                        <%--<select id="dropDownCity" class="form-select" name="ciudad" id="city">
                            <option value="Arequipa">Arequipa</option>
                            <option value="Lima">Lima</option>
                            <option value="Cusco">Cusco</option>
                            <option value="Trujillo">Trujillo</option>
                        </select>--%>
                    </div>


                </div>
                <div class="row">
                    <div class="col-md-6">
                        <asp:TextBox ID="requiredArea" runat="server" Rows="4" class="form-control" placeholder="Requerimiento"></asp:TextBox>
                    </div>
                </div>
                <div class="mt-4">
                    <asp:Button ID="ButtonClean" class="btn btn-warning" UseSubmitBehavior="false" runat="server" Text="Limpiar" OnClientClick="return Clean()" />
                    <asp:Button ID="ButtonSend" class="btn btn-success" runat="server" Text="Enviar" OnClientClick="return sendInformation()" data-bs-toggle="modal" data-bs-target="#staticBackdrop" OnClick="ButtonSend_Click" />
                </div>
            </div>
        </div>

        <div class="container">
            <section class="row">
                <asp:Panel ID="datosDiv" runat="server" class="mt-4 border border-2 col-md-6"></asp:Panel>
            </section>
        </div>


        <%-- Modal de alerta --%>
        <div class="modal fade" id="staticBackdrop" data-bs-backdrop="static" data-bs-keyboard="false" tabindex="-1" aria-labelledby="staticBackdropLabel" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="staticBackdropLabel">Alerta en formulario</h5>
                        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close" onclick="cleanHTML()"></button>
                    </div>
                    <div class="modal-body" id="content-modal-text">
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-danger" data-bs-dismiss="modal" id="btnCloseModal" onclick="cleanHTML()">Close</button>
                    </div>
                </div>
            </div>
        </div>


    </form>
    <%--<script src="/Scripts/bootstrap.js"></script>--%>
    <%--<script type="text/javascript" src="/Scripts/Forms/formStudent.js"></script>--%>
</body>
</html>
