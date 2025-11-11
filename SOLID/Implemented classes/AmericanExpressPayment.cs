using SOLID.Interfaces;

namespace SOLID.Implemented_classes
{
    public class AmericanExpressPayment : IPaymentStrategy
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine("Processing Americans express  card payment"+ amount);
        }
    }
}
