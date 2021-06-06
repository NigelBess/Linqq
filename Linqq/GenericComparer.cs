using System;
using System.Collections.Generic;
using System.Text;

namespace Linqq
{
    public class GenericComparer<T> : IComparer<T>
    {
        private readonly Func<T, double> _exractValue;
        public GenericComparer(Func<T, double> valueExtractor)
        {
            _exractValue = valueExtractor;
        }

        public int Compare(T x, T y) => _exractValue(x).CompareTo(_exractValue(y));
    }
}
