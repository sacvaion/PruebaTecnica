using AccesoDatos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class IndexModelView
    {
        public Factura facturaModel { get; set; }
        public DetalleFactura detalleFacturaModel { get; set; }
        public List<PRODUCTO> productoFactura { get; set; }

    }
}