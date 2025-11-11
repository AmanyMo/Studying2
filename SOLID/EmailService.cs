
namespace SOLID
{
    public  class EmailService
    {
        public void SendEmailNotification(Customer customer, string msg)
        {
            Console.WriteLine("Sending Email Notification To :: ", customer.GetEmail() + "  with message" + msg);
        }
    }
}
