namespace Assignment4.Models
{
    public class Tshirt
    {
        public string _Color { get; set; }
        public string _Size { get; set; }
        public string _Fabric { get; set; }

        public decimal Cost { get; set; }

        public int Id { get; set; }

        public Tshirt()
        {

        }
        public Tshirt(Color Color, Size Size, Fabric Fabric)
        {
            _Color = Color.Type;
            _Size = Size.Type;
            _Fabric = Fabric.Type;
        }

        //private  decimal _TotalCost;

        //public Tshirt(Color color,Fabric fabric,Size size)
        //{
        //    Color = color;
        //    Fabric = fabric;
        //    Size = size;
        //    Cost = (color.Price + size.Price + fabric.Price) * 0.13M;
        //}

        //public Tshirt(Color color, Size size, Fabric fabric,IPaymentStrategy payment)
        //{
        //    _color = color;
        //    _size = size;
        //    _fabric = fabric;
        //    _payment = payment;
        //}
    }
}