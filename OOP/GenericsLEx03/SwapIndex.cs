using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsLEx03
{
    public class SwapIndex<T>
    {

        public List<T> ListOfData { get; set; }

        public SwapIndex(List<T> value)
        {
            this.ListOfData = value;
        }


        public void Swap(List<T> items, int firstIndex, int secondIndex)
        {
            T temp = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = temp;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in this.ListOfData)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }

            return sb.ToString().TrimEnd();
        }

    }
}
