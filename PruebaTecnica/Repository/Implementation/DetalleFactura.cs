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
    public class DetalleFactura : IDetalleFactura
    {
        private Entities context;

        public DetalleFactura(Entities dbContext)
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

        public Response Add(DETALLEFACTURA detalleFactura)
        {
            Response response;
            try
            {
                context.SaveChangesAsync();

                context.DETALLEFACTURAs.Add(detalleFactura);
                context.SaveChanges();
                response = new Response { IsSuccessfull = true, Message = "Exitoso" };
            }
            catch(System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
            catch (Exception ex)
            {
                response = new Response { IsSuccessfull = false, Message = "No Exitoso " + ex.Message };
            }
            return response;
        }

        public Response Delete(DETALLEFACTURA detalleFactura)
        {
            Response response;
            try
            {
                context.DETALLEFACTURAs.Remove(detalleFactura);
                context.SaveChanges();
                response = new Response { IsSuccessfull = true, Message = "Exitoso" };
            }
            catch (Exception ex)
            {
                response = new Response { IsSuccessfull = false, Message = "No Exitoso " + ex.Message };
            }
            return response;
        }

        public List<DETALLEFACTURA> GetAll()
        {
            return context.DETALLEFACTURAs.ToList();
        }

        public DETALLEFACTURA GetById(Guid id)
        {
            return context.DETALLEFACTURAs.FirstOrDefault(x => x.IDFACTURA ==id);
        }

        public Response Update(DETALLEFACTURA detalleFactura)
        {
            Response response;
            try
            {
                context.DETALLEFACTURAs.AddOrUpdate(detalleFactura);
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
