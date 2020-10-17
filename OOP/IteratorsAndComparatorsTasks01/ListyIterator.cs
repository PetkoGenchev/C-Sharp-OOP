using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparatorsTasks01
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        public List<T> genericList { get; set; }
        public int indexOfList { get; set; }


        public ListyIterator(List<T> usingList)
        {
            this.genericList = usingList;
        }


        public bool Move(List<T> usingList,int indexOfList)
        {
            if (indexOfList >= usingList.Count)
            {
                return false;
            }
            else
            {
                indexOfList++;
                return true;
            }
        }

        public bool HasNext(List<T> usingList, int indexOfList)
        {
            if(indexOfList == usingList.Count - 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Print(List<T> usingList, int indexOfList)
        {

            try
            {
                Console.WriteLine(usingList[indexOfList]);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid Operation!");
            }
        }


        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.genericList)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
