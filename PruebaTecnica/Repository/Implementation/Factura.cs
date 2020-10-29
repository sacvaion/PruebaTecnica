using AccesoDatos.Model;
using Repository.Interface;
using Repository.Object;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class Factura : IFactura
    {
        private Entities context;

        public Factura(Entities dbContext)
        {
            if (dbContext == null)
            {
                context = new Entities();
            }
            else
            {
                context = dbContext;
            }
        }
        public Response Add(FACTURA factura)
        {
            Response response;
            try
            {
                context.FACTURAS.Add(factura);
                context.SaveChanges();
                response = new Response { IsSuccessfull = true, Message = "Exitoso" };
            }
            catch (Exception ex)
            {
                response = new Response { IsSuccessfull = false, Message = "No Exitoso " + ex.Message };
            }
            return response;
        }

        public Response Delete(FACTURA factura)
        {
            Response response;
            try
            {
                context.FACTURAS.Remove(factura);
                context.SaveChanges();
                response = new Response { IsSuccessfull = true, Message = "Exitoso" };
            }
            catch (Exception ex)
            {
                response = new Response { IsSuccessfull = false, Message = "No Exitoso " + ex.Message };
            }
            return response;
        }

        public List<FACTURA> GetAll()
        {
            return context.FACTURAS.ToList();
        }


        public FACTURA GetById(Guid id)
        {
            return context.FACTURAS.FirstOrDefault(x => x.IDFACTURA ==id);
        }

        public Response Update(FACTURA factura)
        {
            Response response;
            try
            {
                context.FACTURAS.AddOrUpdate(factura);
                context.SaveChanges();
                response = new Response { IsSuccessfull = true, Message = "Exitoso" };
            }
            catch (Exception ex)
            {
                response = new Response { IsSuccessfull = false, Message = "No Exitoso " + ex.Message };
            }
            return response;
        }
    }
}
