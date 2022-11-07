using System.Collections.Generic;

namespace Assignment4.Models
{
    public class Color
    {
        public decimal Price { get; set; }
        public string Type { get; set; }
        public int Id { get; set; }

        public IEnumerable<Tshirt> Tshirts { get; set; }
        //public Color()
        //{
        //}
    }
}