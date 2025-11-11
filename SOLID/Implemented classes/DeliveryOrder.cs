
using SOLID.Interfaces;

namespace SOLID.Implemented_classes
{
    public class DeliveryOrder: Order , IShippingCostCalculator
    {
       
        public override double GetTotalPrice() => Price + ShippingCost;

    }
}
