using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linqq
{
    public static class EnumFunctions
    {
        public static IEnumerable<T> GetEnumValues<T>() => Enum.GetValues(typeof(T)).Cast<T>();
    }
}
