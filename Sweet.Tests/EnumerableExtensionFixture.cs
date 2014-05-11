using System;
using NUnit.Framework;
using System.Linq;

namespace Sweet.Tests
{
    [TestFixture]
    public class EnumerableExtensionFixture
    {
        [Test]
        public void Each()
        {
            var count = 0;

            new[] { 1, 2, 3, 4, 5 }.Each(i => count += i);

            Assert.That(count, Is.EqualTo(15));
        }

        [Test]
        public void FullOuterJoin()
        {
            var left = new[] { "a", "b", "c", "d", "e" };
            var right = new[] { "c", "d", "e", "f", "g" };

            var joined = left.FullOuterJoin(right,
                                            l => l,
                                            r => r,
                                            (key, l, r) => l + r);

            var expected = new[] { "a", "b", "cc", "dd", "ee", "f", "g" };

            Assert.That(joined, Is.EquivalentTo(expected));
        }

        [Test]
        public void Concat()
        {
            var number = 1;
            var times = 5;

            var enumerable = Enumerable.Repeat(number, times);

            Assert.That(enumerable.Concat(number), Is.EquivalentTo(Enumerable.Repeat(number, times+1)));
        }
    }
}

