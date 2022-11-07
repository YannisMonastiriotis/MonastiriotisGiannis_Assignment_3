using Assignment4.Controllers;
using Assignment4.Interfaces;
using System.Collections.Generic;

namespace Assignment4.Models.Viewmodels
{
    public class TshirtViewmodel
    {
        public IPaymentStrategy Payment { get; set; }
        public IEnumerable<Color> Colors { get; set; }
        public IEnumerable<Fabric> Fabrics { get; set; }
        public IEnumerable<Size> Sizes { get; set; }
        public IEnumerable<Tshirt> Tshirts { get; set; }

        public Tshirt Tshirt { get; set; }
        public int TshirtId { get; set; }
        public Color Color { get; set; }

        public Fabric Fabric { get; set; }

        public Size Size { get; set; }

        public Dictionary<int, Payments> PaymentChoices = new Dictionary<int, Payments>();
    }
}