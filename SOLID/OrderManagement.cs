
namespace SOLID
{
    public class OrderManagement
    {
        public void ProcessOrder(Order order)
        {
            Console.WriteLine("Processing Order : " + order.GetName() + "now...");
        }
    }
}
