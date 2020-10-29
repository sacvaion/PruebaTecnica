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
    public class DetalleFacturaBO
    {
        private Entities _service;

        public Response Add(Guid idFactura, int  idProducto,  short iNoProductos, int iDescuento, int iValorUnidad,int iTotalPago)
        {
            Response response;
           /*
            FacturaBO facturaBO = new FacturaBO();
            var oFactura = facturaBO.GetById(idFactura);
            ProductosBO productosBO = new ProductosBO();
            var oProducto = productosBO.GetById(idProducto);

            */
            try
            {
                DETALLEFACTURA oDetalleFactura = new DETALLEFACTURA
                {
                    IDFACTURA   = idFactura,
                    IDPRODUCTO  = idProducto,
                    NOPRODUCTOS = iNoProductos,
                    DESCUENTO   = iDescuento,
                    VALORUNIDAD = iValorUnidad,
                    TOTALPAGO   = iTotalPago
                };

                

                DetalleFactura detalleFacturaService = new DetalleFactura(_service);
                response = detalleFacturaService.Add(oDetalleFactura);
            }
            catch (Exception ex)
            {
                response = new Response { IsSuccessfull = false, Message = "No Exitosa" };
            }
            return response;
        }

        public Response Update(Guid idFactura, int idProducto, short iNoProductos, int iDescuento, int iValorUnidad, int iTotalPago)
        {
            Response response;
            try
            {
                DETALLEFACTURA oDetalleFactura = new DETALLEFACTURA
                {
                    IDFACTURA = idFactura,
                    IDPRODUCTO = idProducto,
                    NOPRODUCTOS = iNoProductos,
                    DESCUENTO = iDescuento,
                    VALORUNIDAD = iValorUnidad,
                    TOTALPAGO = iTotalPago
                };

                DetalleFactura detalleFacturaService = new DetalleFactura(_service);
                response = detalleFacturaService.Add(oDetalleFactura);
            }
            catch (Exception ex)
            {
                response = new Response { IsSuccessfull = false, Message = "No Exitosa" };
            }
            return response;
        }

        public List<DETALLEFACTURA> GetAll()
        {
            List<DETALLEFACTURA> lstDetalleFacturas;
            try
            {
                DetalleFactura detalleFacturaService = new DetalleFactura(_service);
                lstDetalleFacturas = detalleFacturaService.GetAll();
            }
            catch (Exception)
            {
                lstDetalleFacturas = new List<DETALLEFACTURA>();
            }
            return lstDetalleFacturas;
        }

        public DETALLEFACTURA GetAll(Guid idFactura)
        {
            DETALLEFACTURA oDetalleFacturas;
            try
            {
                DetalleFactura detalleFacturaService = new DetalleFactura(_service);
                oDetalleFacturas = detalleFacturaService.GetById(idFactura);
            }
            catch (Exception)
            {
                oDetalleFacturas = new DETALLEFACTURA();
            }
            return oDetalleFacturas;
        }

    }
}
