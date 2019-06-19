using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
  public class Sql : IArchivo<Queue<Patente>>
  {
    private SqlCommand comando;
    private SqlConnection conexion;

    public Sql()
    {
      this.conexion = new SqlConnection(Properties.Settings.Default.MiConexion);
      this.comando = new SqlCommand();
      this.comando.CommandType = CommandType.Text;
      this.comando.Connection = conexion;
    }

    public void Guardar(string archivo, Queue<Patente> datos)
    {
      try
      {
        conexion.Open();
        if (conexion.State is ConnectionState.Open)
        {
          while (datos.Count > 0)
          {
            comando.CommandText = $"insert into {archivo} (patente,tipo) values ('{datos.Dequeue().CodigoPatente}', '{datos.Dequeue().TipoCodigo}')";

          }

        }
      }
      catch (Exception e)
      {

        throw e;
      }
      finally
      {
        conexion.Close();
      }
    }

    public void Leer(string archivos, out Queue<Patente> datos)
    {
      try
      {
        Queue<Patente> patentes = new Queue<Patente>();
        conexion.Open();
        comando.CommandText = $"select * from {archivos}";
        SqlDataReader reader = comando.ExecuteReader();
        while (reader.Read())
        {
          patentes.Enqueue(new Patente(reader["patente"].ToString(), (Patente.Tipo)Enum.Parse(typeof(Patente.Tipo), reader["tipo"].ToString())));
        }
        datos = patentes;
      }
      catch (Exception e)
      {

        throw e;
      }
      finally
      {
        conexion.Close();
      }
    }
  }
}
