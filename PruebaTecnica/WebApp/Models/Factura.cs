using AccesoDatos.Model;
using Repository.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace WebApp.Models
{
    public class Factura
    {

        public System.Guid IDFACTURA { get; set; }
        public string NUMEROFACTURA { get; set; }
        public System.DateTime FECHA { get; set; }
        public string TIPODEPAGO { get; set; }
        public string DOCUMENTOCLIENTE { get; set; }
        public string NOMBRECLIENTE { get; set; }
        public int SUBTOTAL { get; set; }
        public int DESCUENTO { get; set; }
        public int IVA { get; set; }
        public int TOTALDESCUENTO { get; set; }
        public int TOTALIMPUESTO { get; set; }
        public int TOTAL { get; set; }

        public IEnumerable<FACTURA> Facturas { get; set; }
        public IEnumerable<DETALLEFACTURA> DetalleFacturas { get; set; }
        
        public List<FACTURA> lstFacturas()
        {
            List<FACTURA> lstProducto = new List<FACTURA>();
            try
            {
                Negocio.Implementation.FacturaBO facturaBO = new Negocio.Implementation.FacturaBO();
                lstProducto = facturaBO.GetAll();                
                return lstProducto;
            }
            catch
            {
                return lstProducto;
            }
        }

        public Response add(Factura oFactura)
        {
            Response response;
            try
            {
                Negocio.Implementation.FacturaBO facturaBO = new Negocio.Implementation.FacturaBO();
                response = facturaBO.Add(oFactura.IDFACTURA, oFactura.NUMEROFACTURA, oFactura.FECHA, oFactura.TIPODEPAGO, oFactura.DOCUMENTOCLIENTE, oFactura.NOMBRECLIENTE, 
                    oFactura.SUBTOTAL, oFactura.DESCUENTO, oFactura.IVA, oFactura.TOTALDESCUENTO, oFactura.TOTALIMPUESTO, oFactura.TOTAL);
            }
            catch (Exception ex)
            {
                response = new Response { IsSuccessfull = false, Message = ex.Message };
            }
            return response;
        }
    }
}