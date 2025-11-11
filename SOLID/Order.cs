
using SOLID.Interfaces;

namespace SOLID
{
    public class Order 
    {
        protected string Name;
        protected double Price;

        protected readonly double ShippingCost = 10.0;
        public Order()
        {
            Name = "Test";
            Price = 15.5;
        }
        public string GetName() => Name;
        public virtual double GetTotalPrice() => Price;
        //        public double GetTotalPrice() => Price + ShippingCost;
    }
}
