using System.ComponentModel.DataAnnotations;

namespace SOLID
{
    public class Customer
    {
        string  EmailAddress;
        public string GetEmail() => EmailAddress;
    }
}
