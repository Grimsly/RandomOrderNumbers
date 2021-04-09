using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomOrderNumbers
{
    class CreateIntList
    {
        public static List <int> CreateIntLinqList(int start, int end)
        {
            return Enumerable.Range(start, end).ToList();
        }

        public static List <int> CreateIntForList(int start, int end)
        {
            List<int> list = new List<int>();
            for (int i = start; i <= end; i++)
            {
                list.Add(i);
            }

            return list;
        }
    }
}
