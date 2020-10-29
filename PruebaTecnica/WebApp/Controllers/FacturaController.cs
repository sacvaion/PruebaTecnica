using Repository.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class FacturaController : Controller
    {
        // GET: Factura
        public ActionResult Index()
        {
            Models.Factura lstFactura = new Models.Factura();
            return View(lstFactura.lstFacturas());
        }

        public ActionResult Add()
        {
            WebApp.Models.IndexModelView modelView = new Models.IndexModelView();
            Models.Producto productoModel = new Models.Producto();
            modelView.productoFactura = productoModel.GetAllProductos();
            ViewBag.ddlProducto = new SelectList(productoModel.GetAllProductos(), "IDPRODUCTO", "PRODUCTO1");

            return View(modelView);
        }

        [HttpPost]
        public ActionResult Add(IndexModelView view)
        {
            if (ModelState.IsValid)
            {
                view.facturaModel.IDFACTURA = Guid.NewGuid();
                Models.Factura facturaModel = new Models.Factura();
                Response response = facturaModel.add(view.facturaModel);

                if (response.IsSuccessfull)
                {
                    int idTipoProducto = Convert.ToInt32(Request.Form["ddlProducto"]);
                    Models.DetalleFactura detalleFactura = new DetalleFactura();
                    view.detalleFacturaModel.IDFACTURA = view.facturaModel.IDFACTURA;
                    view.detalleFacturaModel.IDPRODUCTO = idTipoProducto;
                    
                    response = detalleFactura.add(view.detalleFacturaModel);
                    if (response.IsSuccessfull)
                    {
                        return RedirectToAction("Index");
                    }
                }
            }
            return View(view);
        }
    }
}