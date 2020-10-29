using AccesoDatos.Model;
using Repository.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IDetalleFactura
    {
        DETALLEFACTURA GetById(Guid id);
        List<DETALLEFACTURA> GetAll();
        Response Add(DETALLEFACTURA detalleFactura);
        Response Update(DETALLEFACTURA detalleFactura);
        Response Delete(DETALLEFACTURA detalleFactura);
    }
}
