using Assignment4.Interfaces;
using Assignment4.Models.PaymentOptions.Services;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Web.Http;

namespace Assignment4.Models.Services
{
    [DisplayName("Bank")]
    public class Bank : Payment, IPaymentStrategy
    {
        public bool CollectPaymentDetails()
        {
            try
            {
                //bank.BankAccountNumber = bank.User.BankAccountNumber;
                //bank.BankName = bank.User.BankName;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            return true;
        }

        public bool ValidatePaymentDetails()
        {
            return true;
        }

        public decimal Pay(Tshirt tshirt)
        {
            if (tshirt.Cost == 0)
                throw new HttpResponseException(HttpStatusCode.NoContent);

            Debug.WriteLine($"Paying {tshirt.Cost}");

            return tshirt.Cost;
        }
    }
}