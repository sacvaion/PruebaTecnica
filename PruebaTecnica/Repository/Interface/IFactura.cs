using AccesoDatos.Model;
using Repository.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IFactura
    {
        FACTURA GetById(Guid id);
        List<FACTURA> GetAll();
        Response Add(FACTURA factura);
        Response Update(FACTURA factura);
        Response Delete(FACTURA factura);
    }
}
