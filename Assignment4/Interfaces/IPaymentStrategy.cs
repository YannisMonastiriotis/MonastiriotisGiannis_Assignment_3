using Assignment4.Models;

namespace Assignment4.Interfaces
{
    public interface IPaymentStrategy
    {
        decimal Pay(Tshirt clothing);
    }
}