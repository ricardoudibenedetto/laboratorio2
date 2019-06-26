using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesDAO
{
  public interface IData<T>
  {
    void guardar(Emisor emisor);
    T leer();
  }
}
