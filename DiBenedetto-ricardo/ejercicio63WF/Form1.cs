using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace ejercicio63WF
{
  public partial class Form1 : Form
  {
    //int count = 0;
    //Thread t1;
    //public string HoraActual()
    //{
    //  return DateTime.Now.ToString();
    //}
    //public void HoraLabal(object o)
    //{
    //  this.lblHora.Text = ((DateTime)o).ToString();
    //}
    Thread t1;

    delegate void Callback();

    public void MostrarHora()
    {
      if (this.lblHora.InvokeRequired)
      {
        Callback d = new Callback(this.MostrarHora);
        
        this.lblHora.Invoke(d);
      }
      else
      {
      this.lblHora.Text = DateTime.Now.ToString();
      }

    }

    public void Metodohilo()
    {
      while (true)
      {
        this.MostrarHora();
        Thread.Sleep(1000);
      }
    }
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.lblHora.Text = DateTime.Now.ToString();
      this.t1 = new Thread(this.Metodohilo);
      this.t1.Start();
     //t1 = new Thread(HoraLabal);
     // t1.Start((object)DateTime.Now);
      //this.lblHora.Text = this.HoraActual();
      //this.timer1.Start();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      //this.lblHora.Text = this.HoraActual();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      t1.Abort();
    }
  }
}
