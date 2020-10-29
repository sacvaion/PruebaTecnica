using AccesoDatos.Model;
using Repository.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class DetalleFactura
    {
        public System.Guid IDFACTURA { get; set; }
        public int IDPRODUCTO { get; set; }
        public short NOPRODUCTOS { get; set; }
        public Nullable<int> DESCUENTO { get; set; }
        public Nullable<int> VALORUNIDAD { get; set; }
        public Nullable<int> TOTALPAGO { get; set; }

        public virtual FACTURA FACTURA { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }

        public List<DETALLEFACTURA> lstFacturas()
        {
            List<DETALLEFACTURA> lstDetalleFactura = new List<DETALLEFACTURA>();
            try
            {
                Negocio.Implementation.DetalleFacturaBO detalleFacturaBO = new Negocio.Implementation.DetalleFacturaBO();
                lstDetalleFactura = detalleFacturaBO.GetAll();
                return lstDetalleFactura;
            }
            catch
            {
                return lstDetalleFactura;
            }
        }

        public Response add(DetalleFactura oDetalleFactura)
        {
            Response response;
            try
            {
                Negocio.Implementation.DetalleFacturaBO detalleFacturaBO = new Negocio.Implementation.DetalleFacturaBO();
                response = detalleFacturaBO.Add(oDetalleFactura.IDFACTURA, oDetalleFactura.IDPRODUCTO, oDetalleFactura.NOPRODUCTOS, (int)oDetalleFactura.DESCUENTO, (int)oDetalleFactura.VALORUNIDAD, (int)oDetalleFactura.TOTALPAGO);
            }
            catch (Exception ex)
            {
                response = new Response { IsSuccessfull = false, Message = ex.Message };
            }
            return response;
        }
    }
}