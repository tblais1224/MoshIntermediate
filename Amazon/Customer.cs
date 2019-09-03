using System;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            //  var rating = CalculateRating(true);
            // Console.WriteLine(rating == 0 ? "level 1 promotion" : "level 2 promotion");
            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);

            Console.WriteLine("promote logic changed");
        }
        //protected int CalculateRating(bool excludeOrders)
        //{
        //    return 0;
        //}
    }
}