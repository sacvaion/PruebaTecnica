using AccesoDatos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Producto
    {
        public int IDPRODUCTO { get; set; }
        public string PRODUCTO1 { get; set; }

        public List<PRODUCTO> GetAllProductos()
        {
            List<PRODUCTO> lstProducto = new List<PRODUCTO>();
            try
            {
                Negocio.Implementation.ProductosBO productoBO = new Negocio.Implementation.ProductosBO();
                lstProducto = productoBO.GetAll();
                return lstProducto;
            }
            catch
            {
                return lstProducto;
            }
        }
    }
}