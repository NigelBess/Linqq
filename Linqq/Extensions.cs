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
    }
}
