using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaPresentacionAdmin.Controllers
{
    public class MantenedorController : Controller
    {
        // GET: Mantenedor
        public ActionResult Clientes()
        {
            return View();
        }

        public ActionResult Productos()
        {
            return View();
        }
        public ActionResult Proveedor()
        {
            return View();
        }
        public ActionResult Rel_Ventas()
        {
            return View();
        }



    }
}