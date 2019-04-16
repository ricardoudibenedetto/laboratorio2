using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Clase_8_Library;

namespace Clase_8
{
  public partial class frmEmpresa : Form
  {
    Empresa _empresa;

    public Empresa Empresa
    {
      //alumno
      get
      {
        return this._empresa;
      }
      set
      {
        this._empresa = value;
      }
    }

    public frmEmpresa(Empresa empresa)
    {
      InitializeComponent();
      //alumno

    }

    private void btnAceptar_Click(object sender, EventArgs e)
    {
      float ganancias = float.Parse(this.mtxtGanancias.Text.Replace(".", ",").Substring(1, mtxtGanancias.Text.Length - 1));
      if (this._empresa == null)
      {
        this._empresa = new Empresa(this.txtRazonSocial.Text, this.txtDireccion.Text, float.Parse(this.mtxtGanancias.Text.Substring(1)));
        //alumno instanciar Empresa
      }
      else
      {
        this._empresa.RazonSocial = this.txtRazonSocial.Text;
        this._empresa.Direccion = this.txtDireccion.Text;
        this._empresa.Ganancias = ganancias;
      }
      this.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.Close();
    }
  }
}
