namespace Cs.Advanced.ExtensionMethods;

class Program
{
    static void Main(string[] args)
    {
        Product p = new Product() { ProductCost = 1000, DiscountPercentage = 10 };
        
        Console.WriteLine(p.GetDiscount());  //call the extension method
        Console.ReadKey();

    }
}