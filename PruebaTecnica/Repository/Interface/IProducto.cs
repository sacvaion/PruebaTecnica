using AccesoDatos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IProducto
    {
        PRODUCTO GetById(int id);
        List<PRODUCTO> GetAll();
    }
}
