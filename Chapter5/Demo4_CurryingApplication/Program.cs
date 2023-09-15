using Curryfy;
using static System.Console;
WriteLine("*** Using the concept of currying.***");
Product product1 = new(100);
double product1Price = IO.GetPriceAfterDiscount(product1);
WriteLine($"MRP: ${product1.MRP}, Final price: ${product1Price}\n");

Product product2 = new(200);
double product2Price = IO.GetPriceAfterDiscount(product2);
WriteLine($"MRP: ${product2.MRP}, Final price: ${product2Price}\n");

class Product
{
    public double MRP { get; }
    public Product(double mrp)
    {
        MRP = mrp;
    }
    // Price calculator after discounts
    public Func<double, int, int, double> GetFinalCost =
        (mrp, seasonal,coupon) => mrp - (mrp * seasonal / 100)- (mrp * coupon / 100);   
}
class IO
{
    public static double GetPriceAfterDiscount(Product product)
    {
        var mrp = product.GetFinalCost.Curry()(product.MRP);
        // Get a seasonal discount
        int seasonalDiscount = new Random().Next(1, 15);
        // Calculate cost after seasonal discount
        WriteLine($"Seasonal Discount={seasonalDiscount}%");
        var afterSeasonalDiscount = mrp(seasonalDiscount);

        // Get a coupon discount
        int couponDiscount = seasonalDiscount < 10 ? 5 : new Random().Next(1, 3);
        // Calculate cost after coupon discount
        WriteLine($"Coupon discount={couponDiscount}%");
        var afterCouponDiscount = afterSeasonalDiscount(couponDiscount);
        return afterCouponDiscount;
    }

}
