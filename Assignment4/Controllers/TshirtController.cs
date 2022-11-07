using Assignment4.Models;
using Assignment4.Models.PaymentOptions.Services;
using Assignment4.Models.Services;
using Assignment4.Models.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Assignment4.Controllers
{
    public enum Payments
    {
        Bank = 1,
        Card = 2,
        Cash = 3
    };

    public class TshirtController : Controller
    {
        // GET: Tshirt
        private readonly ApplicationDbContext _context;

        public TshirtController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var dbSizes = _context.Sizes.ToList();
            var dbFabrics = _context.Fabrics.ToList();
            var dbColors = _context.Colors.ToList();

            var NewPayments = new Dictionary<int, Payments>();
            NewPayments.Add(1, Payments.Bank);
            NewPayments.Add(2, Payments.Cash);
            NewPayments.Add(3, Payments.Card);

            TshirtViewmodel tshirt = new TshirtViewmodel()
            {
                Sizes = dbSizes,
                Fabrics = dbFabrics,
                Colors = dbColors,
                PaymentChoices = NewPayments
            };
            return View(tshirt);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(TshirtViewmodel tshirt, FormCollection form)
        {
            var pay = Request.Form.GetValues("PaymentChoices.Keys");
            //Debug.WriteLine(pay[0]);
            // string payment = null;

            var dbColor = _context.Colors.SingleOrDefault(c => c.Id == tshirt.Color.Id);
            var dbFabric = _context.Fabrics.SingleOrDefault(c => c.Id == tshirt.Fabric.Id);
            var dbSize = _context.Sizes.SingleOrDefault(c => c.Id == tshirt.Size.Id);

            var Tzert = new Tshirt(dbColor, dbSize, dbFabric)
            {
                Cost = ((dbColor.Price + dbFabric.Price + dbSize.Price) * 1.13M)
            };

            _context.Tshirts.Add(Tzert);
            Order order = new Order();

            if (Tzert != null)
            {
                switch (pay[0])
                {
                    case "1":
                        order.ChosePayment(Tzert, new Bank());
                        break;

                    case "2":
                        order.ChosePayment(Tzert, new Cash());
                        break;

                    case "3":
                        order.ChosePayment(Tzert, new Card());
                        break;

                    default:
                        Console.WriteLine("Not payed");
                        break;
                }
            }

            order._payed = Tzert.Cost;
            order._product = Tzert;
            _context.Order.Add(order);
            //_context.SaveChanges();
            order.SetOrderDetails();

            return RedirectToAction("Index", "Tshirt");
        }
    }
}