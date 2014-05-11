using System;
using System.Linq;
using System.Collections.Generic;

namespace Sweet
{
    public static class ObjectExtensions
    {
        public static IEnumerable<T> ToEnumerable<T>(this T obj)
        {
            return Enumerable.Repeat(obj, 1);
        }
    }
}

