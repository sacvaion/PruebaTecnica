using AccesoDatos.Model;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class Producto : IProducto
    {
        private Entities context;

        public Producto(Entities dbContext)
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

        public List<PRODUCTO> GetAll()
        {
            return context.PRODUCTOS.ToList();
        }

        public PRODUCTO GetById(int id)
        {
            return context.PRODUCTOS.FirstOrDefault(x => x.IDPRODUCTO ==id);
        }
    }
}
