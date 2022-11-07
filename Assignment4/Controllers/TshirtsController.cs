using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Assignment4.Models;

namespace Assignment4.Controllers
{
    public class TshirtsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Tshirts
        public ActionResult Index()
        {
            return View(db.Tshirts.ToList());
        }

        // GET: Tshirts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tshirt tshirt = db.Tshirts.Find(id);
            if (tshirt == null)
            {
                return HttpNotFound();
            }
            return View(tshirt);
        }

   

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
