using Assignment4.Interfaces;
using System.Collections.Generic;

namespace Assignment4.Models.PaymentOptions.Services
{
    public class Orders
    {
        private readonly ApplicationDbContext _context;

        public int Id { get; set; }
        //public Dictionary<decimal,Tshirt> Order { get; set; }

        public decimal Payment { get; set; }

        public Tshirt Tshirt { get; set; }

        public Order _Order { get; set; }

        public Orders()
        {
            _context = new ApplicationDbContext();

            _Order = new Order()
            {
                _product = Tshirt,
                _payed = Payment
            };
            OrderComplete(_Order);
        }

        public void OrderComplete(Order order)
        {
            _context.Order.Add(order);
        }
    }

    public class Order : IWearablePayment
    {
        private readonly ApplicationDbContext _context;
        public int Id { get; set; }
        public IPaymentStrategy _payment { get; private set; }
        public Tshirt _product { get; set; }

        public decimal _payed { get; set; }

        public static Dictionary<Tshirt, decimal> OrderComplete { get; set; }

        public Order()
        {
            _context = new ApplicationDbContext();
            OrderComplete = new Dictionary<Tshirt, decimal>();
        }

        public Dictionary<Tshirt, decimal> ChosePayment(Tshirt product, IPaymentStrategy payment)
        {
            _product = product;
            _payment = payment;
            decimal payed = _payment.Pay(_product);
            OrderComplete.Add(_product, payed);

            DoPay();
            _context.SaveChanges();
            return OrderComplete;
        }

        public void DoPay()
        {
            if (OrderComplete.ContainsKey(_product))
            {
                Orders orders = new Orders();
            }
        }

        public void SetOrderDetails()
        {
            Orders ordersComplete = new Orders()
            {
                Payment = _payed,
                Tshirt = _product,
                _Order = this
            };
            _context.Orders.Add(ordersComplete);
            _context.SaveChanges();
        }
    }
}