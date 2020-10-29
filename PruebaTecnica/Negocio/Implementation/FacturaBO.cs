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
    public class FacturaBO
    {
        private Entities _service;

        public Response Add(Guid id, string sNoFactura, DateTime Fecha, string sTipoDePago, string sDocCliente, string sNombreCliente, int iSubTotal, int iDescuento, int iva, int iTotalDescuento, int iTotalImpuesto, int iTotal)
        {
            Response response;
            try
            {
                FACTURA oFactura = new FACTURA
                {
                    IDFACTURA = id,
                    NUMEROFACTURA = sNoFactura,
                    FECHA = Fecha,
                    TIPODEPAGO = sTipoDePago,
                    DOCUMENTOCLIENTE = sDocCliente,
                    NOMBRECLIENTE = sNombreCliente,
                    SUBTOTAL = iSubTotal,
                    DESCUENTO = iDescuento,
                    IVA = iva,
                    TOTALDESCUENTO = iTotalDescuento,
                    TOTALIMPUESTO = iTotalImpuesto,
                    TOTAL = iTotal
                };

                Factura facturaService = new Factura(_service);
                response = facturaService.Add(oFactura);
            }
            catch (Exception ex)
            {
                response = new Response { IsSuccessfull = false, Message = "No Exitosa" };
            }
            return response;
        }

        public Response Update(Guid id, string sNoFactura, DateTime Fecha, string sTipoDePago, string sDocCliente, string sNombreCliente, int iSubTotal, int iDescuento, int iva, int iTotalDescuento, int iTotalImpuesto, int iTotal)
        {
            Response response;
            try
            {
                FACTURA oFactura = new FACTURA
                {
                    IDFACTURA = id,
                    NUMEROFACTURA = sNoFactura,
                    FECHA = Fecha,
                    TIPODEPAGO = sTipoDePago,
                    DOCUMENTOCLIENTE = sDocCliente,
                    NOMBRECLIENTE = sNombreCliente,
                    SUBTOTAL = iSubTotal,
                    DESCUENTO = iDescuento,
                    IVA = iva,
                    TOTALDESCUENTO = iTotalDescuento,
                    TOTALIMPUESTO = iTotalImpuesto,
                    TOTAL = iTotal
                };

                Factura facturaService = new Factura(_service);
                response = facturaService.Add(oFactura);
            }
            catch (Exception ex)
            {
                response = new Response { IsSuccessfull = false, Message = "No Exitosa" };
            }
            return response;
        }

        public List<FACTURA> GetAll()
        {
            List<FACTURA> lstFacturas;
            try
            {
                Factura facturaService = new Factura(_service);
                lstFacturas = facturaService.GetAll();
            }
            catch (Exception)
            {
                lstFacturas = new List<FACTURA>();
            }
            return lstFacturas;
        }

        public FACTURA GetById(Guid id)
        {
            FACTURA oFacturas;
            try
            {
                Factura facturaService = new Factura(_service);
                oFacturas = facturaService.GetById(id);
            }
            catch (Exception)
            {
                oFacturas = new FACTURA();
            }
            return oFacturas;
        }
    }
}
