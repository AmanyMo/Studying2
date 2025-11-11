using SOLID.Interfaces;

namespace SOLID.Implemented_classes
{
    public class VisaPayment : IPaymentStrategy
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine("Processing VISA card payment");
        }
    }
}
