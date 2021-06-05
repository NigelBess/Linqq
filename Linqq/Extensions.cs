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
    }
}
