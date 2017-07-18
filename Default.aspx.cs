using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    private Usuarios usuarios;
    private SqlDataReader registro;
    protected void Page_Load(object sender, EventArgs e)
    {
        this.usuarios = new Usuarios();
        this.registro = this.usuarios.getUsuarios();
    }
    public SqlDataReader getRegistro()
    {
        return this.registro;
    }
}