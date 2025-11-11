
using SOLID.Interfaces;

namespace SOLID.Implemented_classes
{
    public class PickUpOrder:Order 
    {
        public double GetTotalPrice() => Price;
    }
}
