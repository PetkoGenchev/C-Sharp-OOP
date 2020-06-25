using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace Lab_OOP_Second
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> entry = Console.ReadLine()
                .Split()
                .ToList();

            decimal perDay = decimal.Parse(entry[0], CultureInfo.InvariantCulture);
            int countOfDays = int.Parse(entry[1]);
            string season = entry[2];
            string discount = "None";

            if (entry.Count>3)
            {
                discount = entry[3];
            }

            var calculator = new PriceCalculator();


            decimal totalPrice = PriceCalculator.GetTotalPrice(perDay,
            countOfDays,
            Enum.Parse<Season>(season),
            Enum.Parse<DiscountType>(discount));

            Console.WriteLine($"{totalPrice:f2}");



        }
    }




}
