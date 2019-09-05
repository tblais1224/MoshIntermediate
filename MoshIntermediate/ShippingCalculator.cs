namespace MoshIntermediate
{
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }
    //shippingCalc implement IShippingCalc
    public class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
            {
                return order.TotalPrice * 0.1f;
            }

            return 0;
        }
    }
}