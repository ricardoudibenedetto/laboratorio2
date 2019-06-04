using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace ejercicioPruebaSQLWF
{
  public partial class Form1 : Form
  {
    List<Provincia> provincias;
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      provincias = new List<Provincia>();
     // MessageBox.Show(ConfigurationManager.ConnectionStrings[0].ConnectionString);
      //MessageBox.Show(Properties.Settings.Default.MiCadenaSQL);
      //creo la conexion
      SqlConnection conexion = new SqlConnection(Properties.Settings.Default.MiCadenaSQL);

      SqlCommand comando = new SqlCommand();
      //por defecto es text
      comando.CommandType = System.Data.CommandType.Text;


      // vincula el comando con la conexion 
      comando.Connection = conexion;


      // genera la consulta
      comando.CommandText = "select * from provincias";


      // se abre la conexion 
      conexion.Open();


      // tabla generada 
      SqlDataReader oDr = comando.ExecuteReader();


      //mientras dr pueda leer lee proxima fila y se pare en ella , el primero posiciona en el  uno y tira false cuadno esta en la ultima
      while(oDr.Read())
      {
        provincias.Add(new Provincia((int)((decimal)oDr["Id"]), oDr["Nombre"].ToString()));
      
      }
      this.cboProvincias.DataSource = provincias;

      conexion.Close();
      //string aux = "";
      //foreach (Provincia item in provincias)
      //{
      //  aux += item.ToString() + "\n\r";
      //}

      //MessageBox.Show(aux);
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      string consulta;
      consulta = $"insert into Localidares (ProvinciaID,Nombre) value ({((Provincia)cboProvincias.SelectedItem).Id}, '{this.txtNuevaLocalidad.Text}')";
      // terminar haciendo conexion y agregando la consulta al text
        
    }
  }
}
