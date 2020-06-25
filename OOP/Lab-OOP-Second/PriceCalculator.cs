using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Lab_OOP_Second
{
    public class PriceCalculator
    {

        public static decimal GetTotalPrice(
            decimal perDay,
            int countOfDays,
            Season season,
            DiscountType discount = DiscountType.None)
        {
            int seasonMultiply = (int)season;
            decimal discountPercent = (decimal)discount / 100;

            decimal finalPrice = perDay * countOfDays * seasonMultiply;
            finalPrice -= finalPrice * discountPercent;

            return finalPrice;
        }
    }
}
