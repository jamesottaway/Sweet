using System;
using System.Collections.Generic;
using System.Linq;

namespace Sweet
{
    public static class IEnumerableExtensions
    {
        public static void Each<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (T item in enumerable) {
                action(item);
            }
        }

        public static IEnumerable<TR> FullOuterJoin<T1, T2, TK, TR>(this IEnumerable<T1> left,
                                                                    IEnumerable<T2> right,
                                                                    Func<T1, TK> leftKey,
                                                                    Func<T2, TK> rightKey,
                                                                    Func<TK, T1, T2, TR> projection,
                                                                    T1 leftDefault = default(T1),
                                                                    T2 rightDefault = default(T2),
                                                                    IEqualityComparer<TK> comparer = null)
        {
            comparer = comparer ?? EqualityComparer<TK>.Default;

            var leftLookup = left.ToLookup(leftKey, comparer);
            var rightLookup = right.ToLookup(rightKey, comparer);

            var keys = new HashSet<TK>(leftLookup.Select(p => p.Key), comparer);
            keys.UnionWith(rightLookup.Select(p => p.Key));

            return from key in keys
                from leftItem in leftLookup[key].DefaultIfEmpty(leftDefault)
                from rightItem in rightLookup[key].DefaultIfEmpty(rightDefault)
                select projection(key, leftItem, rightItem);
        }

        public static IEnumerable<T> Concat<T>(this IEnumerable<T> enumerable, T item)
        {
            return enumerable.Concat(item.ToEnumerable());
        }
    }
}

