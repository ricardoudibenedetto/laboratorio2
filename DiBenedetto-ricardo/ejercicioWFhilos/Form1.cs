using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioWFhilos
{
  public partial class Form1 : Form
  {
    public int count = 0;
    public Form1()
    {
      InitializeComponent();
      this.timer1.Start();
    }

    private void btnCountUno_Click(object sender, EventArgs e)
    {
      timer1.Stop(); 
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      this.txtCountUno.Text = Contador.contador(count);
      this.txtCountDos.Text = Contador.contador(count);
      this.txtCountTres.Text = Contador.contador(count);
      this.txtCountCuatro.Text = Contador.contador(count);
      count++;

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}
