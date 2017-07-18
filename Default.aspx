<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html>
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
                <p>
                    <a href="Add.aspx" class="btn btn-success">Agregar</a>
                </p>
                <table class="table table-bordered">
                    <thead>
                        <tr>
                            <th>ID</th>
                        <th>Nombre</th>
                        <th>E-Mail</th>
                            <th>Acciones</th>

                        </tr>
                    </thead>
                    <tbody>
                        <%
                            while (getRegistro().Read())
                            {
                                %>
                                <tr>
                                    <td><%=getRegistro()["id"] %></td>
                                    <td><%=getRegistro()["nombre"] %></td>
                                    <td><%=getRegistro()["correo"] %></td>
                                    <td>
                                        <a href="Edit.aspx?id=<%=getRegistro()["id"] %>"><span class="glyphicon glyphicon-pencil" aria-hidden="true"></span></a>
                                        <a href="javascript:void(0);" onclick="eliminar('Delete.aspx?id=<%=getRegistro()["id"] %>');"><span class="glyphicon glyphicon-trash" aria-hidden="true"></span></a>
                                    </td>
                                </tr>
                                <%
                            }
                        %>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
    <script type="text/javascript" src="public/js/jquery.js"></script>
    <script type="text/javascript" src="public/js/funciones.js"></script>
</body>
</html>
