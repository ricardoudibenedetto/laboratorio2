using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entities;
using System.IO;
using EntitiesDAO;

namespace EntitiesDAO
{
  public class EmailDB : IData<List<EmisorDeEmails>>
  {
    private readonly string connectionString;

    SqlConnection conector = new SqlConnection();
    SqlCommand comando = new SqlCommand();

    /// <summary>
    /// Asigna un valor al connectionString
    /// </summary>
    public EmailDB()
    {
      this.connectionString = Properties.Settings.Default.conexion;
    }
    /// <summary>
    /// guarda el emisor en la base de datos
    /// </summary>
    /// <param name="emisor">emisor a guardar</param>
    public void guardar(Emisor emisor)
    {
      try
      {
        this.comando.CommandType = System.Data.CommandType.Text;
        string consulta;
        EmisorDeEmails emi = (EmisorDeEmails)emisor;
        consulta = $"insert into Emails2 (mensaje,producto,email) values ('{emi.Mensaje}', '{emi.Producto}','{emi.Email}')";
        this.comando.CommandText = consulta;
      }
      catch (Exception e)
      {

        throw e;
      }
    }
    /// <summary>
    /// lee una base de datos de emails
    /// </summary>
    /// <returns>retorna una lista con los datos emisor de mails </returns>
    public List<EmisorDeEmails> leer()
    {
      List<EmisorDeEmails> nueva = new List<EmisorDeEmails>();
      try
      {
        comando.CommandText = "select * from Emails2";


        // se abre la conexion 
        conector.Open();


        // tabla generada 
        SqlDataReader oDr = comando.ExecuteReader();


        //mientras dr pueda leer lee proxima fila y se pare en ella , el primero posiciona en el  uno y tira false cuadno esta en la ultima
        while (oDr.Read())
        {
          nueva.Add(new EmisorDeEmails(oDr["mensaje"].ToString(),(EProducto)Enum.Parse(typeof(EProducto),oDr["producto"].ToString()),oDr["email"].ToString()));

        }
        conector.Close();
        return nueva;
      }
      catch (Exception)
      {

        throw;
      }
    }
  }
}
