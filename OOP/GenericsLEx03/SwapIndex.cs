using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsLEx03
{
    public class SwapIndex<T>
    {
        public T listItem { get; set; }

        public SwapIndex(T listItem)
        {
            this.listItem = listItem;
        }


    }
}
