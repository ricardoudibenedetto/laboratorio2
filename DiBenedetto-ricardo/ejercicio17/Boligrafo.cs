using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioBoligrafo
{
  public class Boligrafo
  {
    const short cantidadTintaMaxima = 100;
    private ConsoleColor color;
    private short tinta;

    public Boligrafo(short tinta, ConsoleColor color)
    {
      this.color = color;
      this.tinta = tinta;
    }

    public short GetTinta()
    {
      return this.tinta;
    }

    public ConsoleColor GetColor()
    {
      return this.color;
    }

    private void SetTinta(short tinta)
    {
      if (tinta > 0)
      {
        if (this.tinta + tinta > cantidadTintaMaxima)
        {
          this.tinta = cantidadTintaMaxima;
        }
        else
        {
          this.tinta += tinta;
        }
      }
      else
      {
        if (this.tinta - tinta < 0)
        {
          this.tinta = 0;
        }
        else
        {
          this.tinta += tinta;
        }
      }
    }

    public void Recargar()
    {
      SetTinta(100);
    }

    public bool Pintar(int gasto, out string dibujo)
    {
      bool flag = false;
      dibujo = "";
      if (gasto < this.tinta)
      {
        this.SetTinta((short)(gasto * -1));
        flag = true;
        for (int i = 0; i < gasto; i++)
        {
          dibujo += "*";
        }
      }

      return flag;
    }

  }
}
