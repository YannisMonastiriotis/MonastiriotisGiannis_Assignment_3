using Assignment4.Interfaces;
using System.Collections.Generic;

namespace Assignment4.Models
{
    internal interface IWearablePayment
    {
        Dictionary<Tshirt, decimal> ChosePayment(Tshirt product, IPaymentStrategy payment);
    }
}