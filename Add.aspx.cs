using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Add : System.Web.UI.Page
{
    private Conexion con;
    private Usuarios usuarios;
    protected void Page_Load(object sender, EventArgs e)
    {
        this.con = new Conexion();
        this.con.conectar();
        this.usuarios = new Usuarios();
        this.usuarios.jquery();
    }
    public void ProcesarFormulario(object sender, EventArgs e)
    {
        if (IsValid)
        {
            this.usuarios.Insertar(nombre.Text, correo.Text);
            Response.Redirect("Default.aspx");
        }
    }
}