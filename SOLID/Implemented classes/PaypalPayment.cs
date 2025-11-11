using SOLID.Interfaces;

namespace SOLID.Implemented_classes
{
    public class PaypalPayment : IPaymentStrategy
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine("Processing Paypal payment");
        }
    }
}
