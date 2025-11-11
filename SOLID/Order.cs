
namespace SOLID
{
    public class Order
    {
        private static string Name ="Test";
        private static double Price=15.5;

        public string GetName() => Name;
        public double GetTotalPrice() => Price;
    }
}
