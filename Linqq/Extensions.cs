using System;
using System.Collections.Generic;
using System.Linq;

namespace Linqq
{
    public static class Extensions
    {
        public static IEnumerable<T> Enumerate<T>(this T[,] array)
        {
            foreach (var item in array)
            {
                yield return item;
            }
        }

        public static IEnumerable<Tuple<T, int>> WithIndex<T>(this IEnumerable<T> enumerable)
        {
            int index = 0;
            foreach (var item in enumerable)
            {
                yield return new Tuple<T, int>(item, index++);
            }
        }

        public static T MaxBy<T>(this IEnumerable<T> enumerable, Func<T, double> traitToCompare)
        {
            var max = double.MinValue;
            T maxItem = default;
            foreach (var item in enumerable)
            {
                var value = traitToCompare(item);
                if (value > max)
                {
                    max = value;
                    maxItem = item;
                }
            }

            return maxItem;
        }

        public static List<T> SortBy<T>(this List<T> list, Func<T,double> sortyBy)
        {
            var returnList = list.ToList();
            var comparer = new GenericComparer<T>(sortyBy);
            returnList.Sort(comparer);
            return returnList;
        }

 

        



    }
}
