using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Edit : System.Web.UI.Page
{
    private Usuarios usuarios;
    private SqlDataReader registro;
    private String nom;
    private String mail;

    public string Mail
    {
        get
        {
            return mail;
        }

        set
        {
            mail = value;
        }
    }

    public string Nom
    {
        get
        {
            return nom;
        }

        set
        {
            nom = value;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        this.usuarios = new Usuarios();
        this.usuarios.jquery();
        string valor = Request.QueryString["id"];
        int id = int.Parse(valor);
        this.usuarios.jquery();
        this.registro = this.usuarios.getUsuarioPorId(id);
        if (this.registro.Read())
        {
            this.nom = this.registro["nombre"].ToString();
            this.mail = this.registro["correo"].ToString();
            this.id_usuario.Value = valor;
        }
    }
    public void ProcesarFormulario(object sender, EventArgs e)
    {
        if (IsValid)
        {
            int cantidad = this.usuarios.Modificar(this.nombre.Text, this.correo.Text, this.id_usuario.Value);
            if (cantidad == 1)//se ejecutó la consulta correctamente
            {
                Response.Redirect("Default.aspx");
            }
            else//se produjo error con ñandú porque mi muñeca me habló
            {
                Response.Redirect("Edit.aspx?id=" + id_usuario.Value);
            }
        }
    }
}