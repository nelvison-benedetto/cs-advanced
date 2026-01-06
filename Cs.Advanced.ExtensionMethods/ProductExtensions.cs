using System;
using System.Collections.Generic;
using System.Text;

namespace Cs.Advanced.ExtensionMethods;

//static class x extension method
public static class ProductExtensions
{
    //extension method x Product class
    public static double GetDiscount(this Product product) {
        return product.ProductCost * product.DiscountPercentage / 100;
    }


}
