using SOLID.Interfaces;

namespace SOLID.Implemented_classes
{
    public class MasterCardPayment : IPaymentStrategy
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine("Processing MASTER card payment"+ amount);
        }
    }
}
