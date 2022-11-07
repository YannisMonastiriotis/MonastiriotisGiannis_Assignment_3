using Assignment4.Interfaces;
using Assignment4.Models.PaymentOptions.Services;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Web.Http;

namespace Assignment4.Models.Services
{
    [DisplayName("Card")]
    public class Card : Payment, IPaymentStrategy
    {
        public decimal Pay(Tshirt tshirt)
        {
            if (tshirt.Cost == 0)
                throw new HttpResponseException(HttpStatusCode.NoContent);

            Debug.WriteLine($"Paying {tshirt.Cost}");
            return tshirt.Cost;
        }
    }
}