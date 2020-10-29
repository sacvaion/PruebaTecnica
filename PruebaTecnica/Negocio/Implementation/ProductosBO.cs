using AccesoDatos.Model;
using Repository.Implementation;
using Repository.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Implementation
{
    public class ProductosBO
    { 
        private Entities _service;

        public List<PRODUCTO> GetAll()
        {
            List<PRODUCTO> lstProducto;
            try
            {
                Producto productoService = new Producto(_service);
                lstProducto = productoService.GetAll();
            }
            catch (Exception ex)
            {
                lstProducto = new List<PRODUCTO>();
            }
            return lstProducto;
        }
        public PRODUCTO GetById(int id)
        {
            PRODUCTO oProducto;
            try
            {
                Producto productoService = new Producto(_service);
                oProducto = productoService.GetById(id);
            }
            catch (Exception ex)
            {
                oProducto = new PRODUCTO();
            }
            return oProducto;
        }

    }
}
