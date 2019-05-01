using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PracticaParcialUno;
namespace PracticaPrimerParcialWF
{
    public partial class Form1 : Form
    {
        DirectorTecnico dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            this.dt = new DirectorTecnico(this.txtNombre.Text, this.txtApellido.Text, (int)this.nudEdad.Value, (int)this.nudDni.Value, (int)this.nudExperiencia.Value);
            MessageBox.Show($"Se a creado un director tecnico:\r\n {dt.Mostrar()}", "DT CREADO");
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if(dt is null)
            {
                MessageBox.Show("El DT no ha sido creado");
            }else 
                if(dt.ValidarAptitud())
            {
                MessageBox.Show("El es apto para dirigir ");
            }
            else
            {
                MessageBox.Show("El DT no es apto");
            }
        }
    }
}
