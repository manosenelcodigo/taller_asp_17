using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;

public class Usuarios : Conexion
{
    private SqlDataReader registro;
    private SqlConnection con;
    public Usuarios()
    {
        this.con = getConexion();
    }
    public void jquery()
    {
        ScriptManager.ScriptResourceMapping.AddDefinition
            (
                "jquery", new ScriptResourceDefinition
                {
                    Path = "~/public/js/jquery.js",
                    DebugPath = "~/public/js/jquery.js",
                    CdnSupportsSecureConnection = true,
                    LoadSuccessExpression = "window.jQuery"
                }
            );
    }
    public SqlDataReader getUsuarios()
    {
        conectar();
        String sql = "select id,nombre,correo from usuarios;";

        SqlCommand comando = new SqlCommand(sql, this.con);
        this.registro = comando.ExecuteReader();
        return this.registro;
    }
    public void Insertar(String nombre, String correo)
    {
        conectar();
        String sql = "insert into usuarios " +
                        "values " +
                        "('" + nombre + "','" + correo + "')";
        SqlCommand comando = new SqlCommand(sql, this.con);
        comando.ExecuteNonQuery();
        cerrar();
    }
    public void Borrar(int id)
    {
        conectar();
        String sql = "delete from usuarios where id='" + id + "'";
        SqlCommand comando = new SqlCommand(sql, this.con);
        comando.ExecuteNonQuery();
        cerrar();
    }
    public SqlDataReader getUsuarioPorId(int id)
    {
        conectar();
        String sql = "select id,nombre,correo from usuarios where id='" + id + "'; ";
        SqlCommand comando = new SqlCommand(sql, this.con);
        this.registro = comando.ExecuteReader();
        //cerrar();
        return this.registro;
    }
    public int Modificar(String nombre, String correo, String id)
    {
        cerrar();
        conectar();
        int numero = int.Parse(id);
        String sql = "update usuarios " +
                      " set " +
                      " nombre='" + nombre + "'," +
                      " correo='" + correo + "'" +
                      " where " +
                      " id=" + numero + " ";
        SqlCommand comando = new SqlCommand(sql, this.con);
        int cantidad = comando.ExecuteNonQuery();
        cerrar();
        return cantidad;
    }
}