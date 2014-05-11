using System;
using System.Linq;
using NUnit.Framework;
using System.Collections;

namespace Sweet.Tests
{
    [TestFixture]
    public class ObjectExtensionsFixture
    {
        [Test]
        public void ToEnumerable()
        {
            var obj = new object();
            var enumerable = obj.ToEnumerable();
            Assert.That(enumerable.First(), Is.EqualTo(obj));
        }
    }
}

