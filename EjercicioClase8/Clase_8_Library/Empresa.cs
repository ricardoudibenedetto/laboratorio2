using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_8_Library
{
  public class Empresa
  {
    List<Empleado> _nominaEmpleados;
    string _razonSocial;
    string _direccion;
    float _ganancias;

    #region "Constructores"
    private Empresa()
    {
      this._nominaEmpleados = new List<Empleado>();
      //alumno
    }
    public Empresa(string razonSocial, string direccion, float ganancias):this()
    {
      this._razonSocial = razonSocial;
      this._direccion = direccion;
      this._ganancias = ganancias;
    }
    #endregion

    #region "Propiedades"
    //alumno
    public string RazonSocial
    {
      get
      {
        return this._razonSocial;
      }
      set
      {
        this._razonSocial = value;
      }
    }
    public string Direccion
    {
      get
      {
        return this._direccion;
      }
      set
      {
        this._direccion = value;
      }
    }
    public float Ganancias
    {
      get
      {
        return this._ganancias;
      }
      set
      {
        this._ganancias = value;
      }
    }
    #endregion

    #region "Métodos"
    public string MostrarEmpresa()
    {
      string textoEmpresa = $"La empresa{this.RazonSocial} sita en la calle{this.Direccion} cuenta con ganancias por{this.Ganancias} y con{this._nominaEmpleados.Count} empleados\r\n";
      foreach(Empleado item in this._nominaEmpleados)
      {
        textoEmpresa += item.Mostrar();
      }
      return textoEmpresa;
      //NOMBRE: [nombre]
      //  APELLIDO: [apellido]
      //  LEGAJO: [legajo]
      //  SALARIO: $[salario]
    //alumno
  }
    #endregion

    #region "Operadores"
    /// <summary>
    /// Agregará un empleado a una empresa, siempre y cuando no figure ya en la nómina
    /// </summary>
    /// <param name="empresa">Empresa interesada.</param>
    /// <param name="empleado">Empleado a agregar.</param>
    /// <returns></returns>
    public static Empresa operator +(Empresa empresa, Empleado empleado)
    {
      bool flag = false;
      foreach (Empleado item in empresa._nominaEmpleados)
      {
        if(item == empleado)
        {
          flag = true;
        }
      }
      if(flag == false )
      {
        empresa._nominaEmpleados.Add(empleado);
        return empresa;
      }
      else
      {
        return empresa;
      }
      //alumno
    }
    #endregion
  }
}
