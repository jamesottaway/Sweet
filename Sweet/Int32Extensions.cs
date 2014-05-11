using System;
using System.Collections.Generic;
using System.Linq;

namespace Sweet
{
    public static class Int32Extensions
    {
        public static IEnumerable<T> Times<T>(this Int32 limit, Func<Int32, T> func)
        {
            var result = Enumerable.Empty<T>();
            for (var i = 1; i <= limit; i++) {
                result = result.Concat(func(i));
            }
            return result;
        }

        public static void Times(this Int32 limit, Action action)
        {
            for (var i = 1; i <= limit; i++) {
                action();
            }
        }
    }
}

