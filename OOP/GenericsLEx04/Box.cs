using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GenericsLEx04
{
    class Box<T>
    {
        List<T> ListOfItems { get; set; }

        public Box(List<T> listOfItems)
        {
            this.ListOfItems = listOfItems;
        }

        public int BiggerElements<T>(List<T> items, T element )
            where T: IComparable<T>
        {
            int count = 0;

            foreach (var item in items)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }


            return count;
        }

    }
}
