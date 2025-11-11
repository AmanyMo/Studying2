
using SOLID.Interfaces;

namespace SOLID
{
    public class PaymentProcessor
    {
        private readonly IPaymentStrategy _paymentService;
        public PaymentProcessor(IPaymentStrategy paymentService)
        {
            _paymentService = paymentService;
        }
        public void ProcessPayment(Order order)
        {
            Console.WriteLine("Processing payment of order :: ", order.GetName());
            Console.WriteLine("Issuing Payment for amount :: ", order.GetTotalPrice());
            _paymentService.ProcessPayment(order.GetTotalPrice());

            //if (string.Equals(payement.GetType(), "VISA", StringComparison.OrdinalIgnoreCase))
            //    Console.WriteLine("Processing VISA card payment");

            //else if (string.Equals(payement.GetType(), "MASTER", StringComparison.OrdinalIgnoreCase))
            //    Console.WriteLine("Processing MASTER card payment");

            //else if (string.Equals(payement.GetType(), "AMERICAN", StringComparison.OrdinalIgnoreCase))
            //    Console.WriteLine("Processing AMERICAN card payment");
            //else
            //    Console.WriteLine("Unsupported Payment Method..");
        }
    }
}
