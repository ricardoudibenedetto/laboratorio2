using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClase06
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      this.cmbNumero.SelectedIndex = 1 ;
    }

    private void btnContinuar_Click(object sender, EventArgs e)
    {
      StringBuilder salidaMensageBox = new StringBuilder();
      salidaMensageBox.AppendLine($"Nombre : {this.txtNombre.Text} ");
      salidaMensageBox.AppendLine($"Apellido : {this.txtApellido.Text} ");
      salidaMensageBox.AppendLine($"Email : {this.txtEmail.Text} ");
      salidaMensageBox.AppendLine($"Contraseña : {this.txtContraseña.Text} ");
      if(this.rdoSexoFemenino.Checked == true)
      {
        salidaMensageBox.AppendLine($"Sexo : femenino ");
      }
      MessageBox.Show(salidaMensageBox.ToString());
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      cmbNumero.Items.Add("+23");
    }
  }
}
