using System;
using System.Threading;

namespace Entities
{
  [Serializable]
  public class EmisorDeEmails : Emisor
  {
    private string email;

    public EmisorDeEmails()
    {

    }
    public string Email
    {
      set => email = value;
      get => email;
    }

    /// <summary>
    /// valida si hay manejadores, en caso de que no haya, lanza un EmisorException 
    /// indicando que no hay manejadores. Caso contrario duerme el Thread 3 segundos y 
    /// luego invoca al evento EventMensaje pasándose a sí mismo (“.Invoke(this)”) como 
    /// parámetro.
    /// </summary>
    public override void EnviarMensaje()
    {
      if (true)
      {
       
            //FALTA TODO EVENTO , NO TENGO IDEA DE COMO HACERLO
            Thread.Sleep(3000);
          
            this.EventMensaje.Invoke(this);
         
       
      }
      else
      {
        throw new EmisorException();
      }
    }

    public EmisorDeEmails(string mnsj, EProducto prod, string mail)
        : base(mnsj, prod)
    {
      this.email = mail;
    }
  }
}
