using System;
using System.Collections.Generic;

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



    }
}
