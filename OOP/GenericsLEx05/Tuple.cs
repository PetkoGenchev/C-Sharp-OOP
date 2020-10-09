using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GenericsLEx05
{
    public class Tuple<TFirst,TSecond,TThird>
    {
        public TFirst FirstItem { get; set; }
        public TSecond SecondItem { get; set; }

        public TThird ThirdItem { get; set; }

        public Tuple(TFirst firstItem, TSecond secondItem, TThird thirdItem)
        {
            this.FirstItem = firstItem;
            this.SecondItem = secondItem;
            this.ThirdItem = thirdItem;
        }

        public override string ToString()
        {
            return $"{FirstItem} -> {SecondItem} -> {ThirdItem}";
        }
    }
}
