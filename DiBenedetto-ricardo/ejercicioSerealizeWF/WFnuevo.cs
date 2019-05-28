using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ejercicioSerealizeEntidades;
namespace ejercicioSerealizeWF
{
  public partial class WFnuevo : Form
  {
    public Persona persona;
    public WFnuevo()
    {
      InitializeComponent();
    }

    private void btnAceptar_Click(object sender, EventArgs e)
    {
       this.persona = new Persona(this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtDNI.Text), int.Parse(this.txtNumeroTarjeta.Text));
      this.DialogResult = DialogResult.OK;
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
    }
  }
}
