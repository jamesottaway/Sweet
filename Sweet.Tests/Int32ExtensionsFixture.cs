using System;
using NUnit.Framework;

namespace Sweet.Tests
{
    [TestFixture]
    public class Int32ExtensionsFixture
    {
        [Test]
        public void TimesCanBeInvokedWithFunc()
        {
            var result = 3.Times(i => i);

            Assert.That(result, Is.EqualTo(new[] { 1, 2, 3 }));
        }

        [Test]
        public void TimesCanBeInvokedWithAction()
        {
            var count = 0;
            3.Times(() => count++);

            Assert.That(count, Is.EqualTo(3));
        }
    }
}

