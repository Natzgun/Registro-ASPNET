<%@ Page Title="Formulario estudiante" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormStudent.aspx.cs" Inherits="Laboratorio2.FormStudent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
        <div class="container" id="formularioEstudiantes">
            <div>
                <h1>Registro de alumno</h1>
            </div>
            <div class="container">
                <div class="mb-3 row">
                <div class="col">
                    <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
                </div>
                <div class="col">
                    <input id="nameInput" type="text" class="form-control" placeholder="Nombre" />
                </div>
            </div>
            </div>
            
            <div class="mb-3 row">
                <div class="col">
                    <asp:Label ID="Label2" runat="server" Text="Apellidos:"></asp:Label>
                </div>
                <div class="col">
                    <input id="apellidoInput" class="form-control" type="text" placeholder="Apellidos" />
                </div>

            </div>
            <div class="mb-3">
                <asp:Label ID="Label3" runat="server" Text="Sexo:"></asp:Label>
                <asp:RadioButton ID="RadioButtonM" runat="server" class="form-radio-input ms-3" GroupName="genero" />
                <asp:Label ID="Label4" runat="server" Text="Masculino"></asp:Label>
                <asp:RadioButton ID="RadioButtonF" runat="server" class="form-radio-input ms-3" GroupName="genero"/>
                <asp:Label ID="Label5" runat="server" Text="Femenino"></asp:Label>
            </div>
            <div class="mb-3 d-flex">
                <asp:Label ID="Label6" runat="server" Text="Correo:"></asp:Label>
                <input id="emailInput" class="form-control ms-3" type="email" placeholder="example@mail.com" />
            </div>
            <div class="mb-3 d-flex">
                <div>
                    <asp:Label ID="Label7" runat="server" Text="Direccion:"></asp:Label>
                    <input id="addressInput" class="form-control" type="text" placeholder="Ingresa aqui tu direccion" />
                </div>
                <div class="ms-2">
                    <asp:Label ID="Label8" runat="server" Text="Ciudad:"></asp:Label>
                    <select id="dropDownCity" class="form-select" name="ciudad" id="city">
                        <option value="Arequipa">Arequipa</option>
                        <option value="Lima">Lima</option>
                        <option value="Cusco">Cusco</option>
                        <option value="Trujillo">Trujillo</option>
                    </select>
                </div>
                
                
            </div>
            <div class="mb-3">
                <textarea id="requiredArea" class="form-control" placeholder="Requerimiento"></textarea>
                <div class="mt-4">
                    <asp:Button ID="ButtonClean" class="btn btn-warning"  UseSubmitBehavior="false" runat="server" Text="Limpiar"  OnClientClick="return Clean()" />
                    <asp:Button ID="ButtonSend" class="btn btn-success" runat="server" Text="Enviar" OnClientClick="return sendInformation()" />
                </div>
            </div>
        </div>
</asp:Content>
