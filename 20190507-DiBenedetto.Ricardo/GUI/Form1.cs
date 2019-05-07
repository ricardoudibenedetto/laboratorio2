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
namespace GUI
{
  public partial class Form1 : Form
  {
    Maquina m1;
    PlacaVideo placa;
    

    public Form1()
    {
      InitializeComponent();
    }
    /// <summary>
    /// el load inicializa una maquina
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Form1_Load(object sender, EventArgs e)
    {
      m1 = new Maquina("LAB01pc02");

    }
    /// <summary>
    /// agrega una placa a la maquina
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnAgregar_Click(object sender, EventArgs e)
    {
      placa = new PlacaVideo(this.txtMarca.Text, this.txtModelo.Text, (int)this.nudMemoria.Value);
      
      MessageBox.Show(m1 + placa);
    }
    /// <summary>
    /// saca una placa de la maquina
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnSacar_Click(object sender, EventArgs e)
    {
      
      MessageBox.Show(m1 - placa);
    }

   

    private void btnSystemInfo_Click(object sender, EventArgs e)
    {
      this.rtxtSystemInfo.Text = " ";
      this.rtxtSystemInfo.Text = m1.SystemInfo;
    }
  }
}
