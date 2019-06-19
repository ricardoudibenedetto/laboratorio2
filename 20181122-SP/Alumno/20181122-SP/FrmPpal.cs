using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;
using Archivos;
using System.Threading;
using Patentes;

namespace _20181122_SP
{
  public partial class FrmPpal : Form
  {
    Queue<Patente> cola;
    List<Thread> threads;
    public FrmPpal()
    {
      InitializeComponent();
      this.threads = new List<Thread>();
      this.cola = new Queue<Patente>();
    }

    public void ProximaPatente(VistaPatente vp)
    {
      while (this.cola.Count > 0)
      {
        Thread t = new Thread(vp.MostrarPatente);
        t.Start(this.cola.Dequeue());
        this.threads.Add(t);
        //vp.MostrarPatente(this.cola.Dequeue());

      }
    }
    private void FrmPpal_Load(object sender, EventArgs e)
    {
      this.vistaPatente1.FinExposicion += ProximaPatente;
      this.vistaPatente2.FinExposicion += ProximaPatente;

    }

    private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
    {

    }

    private void btnXml_Click(object sender, EventArgs e)
    {

    }

    private void btnTxt_Click(object sender, EventArgs e)
    {

    }

    private void btnSql_Click(object sender, EventArgs e)
    {

    }

    private void FinalizarSimulacion()
    {

    }

    private void vistaPatente1_Load(object sender, EventArgs e)
    {

    }
  }
}
