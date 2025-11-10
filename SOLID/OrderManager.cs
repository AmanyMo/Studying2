namespace SOLID
{
    public class OrderManager
    {
        void ProcessOrder(Order order)
        {
            Console.WriteLine("Processing Order : " + order.GetName() + "now...");
        }

        void ProcessPayment(Order order,Payment payement)
        {
            Console.WriteLine("Processing payment of order :: ", order.GetName());
            Console.WriteLine("Issuing Payment for amount :: ", order.GetTotalPrice());
            if (string.Equals( payement.GetType() , "VISA",StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Processing VISA card payment");

            else if (string.Equals(payement.GetType(), "MASTER", StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Processing MASTER card payment");

            else if (string.Equals(payement.GetType(), "AMERICAN", StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Processing AMERICAN card payment");
            else 
                Console.WriteLine("Unsupported Payment Method..");
        }
        void SendEmailNotification(Customer customer, string msg)
        {
            Console.WriteLine("Sending Email Notification To :: ",customer.GetEmail() + "  with message" + msg);
        }
    }
}
