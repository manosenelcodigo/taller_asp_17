<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Add.aspx.cs" Inherits="Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8"/>
    <title>Conexión a SQL Server</title>
    <link href="/public/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
   <div class="container">
       <div class="panel panel-primary">
            <div class="panel-heading">Conexión a SQL Server</div>
            <div class="panel-body">
                <ol class="breadcrumb">
                  <li><a href="Default.aspx">Inicio</a></li>
                  <li class="active">Agregar Registro</li>
                </ol>
                <!--formulario-->
                <form runat="server" method="post"  id="form">
                     <p>
                        <asp:ValidationSummary runat="server" HeaderText="" DisplayMode="BulletList" CssClass="alert alert-danger" />
                    </p>
                     <p>
                        <asp:Label runat="server" >Nombre:</asp:Label>
                        <asp:TextBox ID="nombre" runat="server" CssClass="form-control" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="nombre" ErrorMessage="El campo nombre es requerido" Display="None"></asp:RequiredFieldValidator>
                    </p>
                    <p>
                        <asp:Label runat="server" >E-Mail:</asp:Label>
                        <asp:TextBox ID="correo" runat="server" CssClass="form-control" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="correo" ErrorMessage="El campo E-Mail es requerido" Display="None"></asp:RequiredFieldValidator>

                         <asp:RegularExpressionValidator ControlToValidate="correo" ErrorMessage="El E-Mail ingresado no es válido" Display="None" ValidationExpression="^[\w-]+@[\w-]+\.(com|net|org|edu|mil)$" runat="server">
              </asp:RegularExpressionValidator>

                    </p>
                    <hr />
                    <asp:Button ID="enviar_form" runat="server" Text="Enviar" CssClass="btn btn-default" OnClick="ProcesarFormulario"/>
                </form>
                <!--/formulario-->

            </div>
           </div>
       </div>

   </div>
    <script type="text/html" src="~/public/js/jquery.js"></script>
</body>
</html>
