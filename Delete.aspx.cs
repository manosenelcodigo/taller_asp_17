using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Delete : System.Web.UI.Page
{
    private Usuarios usuarios;
    protected void Page_Load(object sender, EventArgs e)
    {

        this.usuarios = new Usuarios();
        string valor = Request.QueryString["id"];
        int id = int.Parse(valor);
        this.usuarios.Borrar(id);
        Response.Redirect("Default.aspx");
    }
}