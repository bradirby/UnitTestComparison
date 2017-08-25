using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PrjToTest;

namespace NuGetNUnitProject
{

    public class AssertSupportTest
    {
        public void AssertSupportMethodTest()
        {
            var sut = new SystemUnderTest();

            Assert.AreEqual(null, sut);
            Assert.AreEqual<string>(null, "asdf");
            Assert.AreNotEqual(1, 2);
            Assert.AreNotSame(sut, sut);
            Assert.AreSame(sut, sut);
            Assert.ByVal();
            Assert.Catch(() => sut.ToString());
            Assert.Catch<ArgumentException>(() => sut.ToString());
            Assert.CatchAsync(() => sut.ToString());
            Assert.CatchAsync<ArgumentException>(() => sut.ToString());
            Assert.Contains();
            Assert.DoesNotThrow();
            Assert.DoesNotThrowAsync();
            Assert.Equals();
            Assert.Fail();
            Assert.False();
            Assert.IsFalse();
            Assert.Greater();
            Assert.GreaterOrEqual();
            Assert.Ignore();
            Assert.Inconclusive();
            Assert.IsAssignableFrom();
            Assert.IsAssignableFrom<>();
            Assert.IsNotAssignableFrom();
            Assert.IsNotAssignableFrom<>();
            Assert.IsInstanceOf();
            Assert.IsInstanceOf<>();
            Assert.IsNotInstanceOf();
            Assert.IsNotInstanceOf<>();
            Assert.Less();
            Assert.LessOrEqual();
            Assert.Multiple();
            Assert.Negative();
            Assert.Null();
            Assert.NotNull();
            Assert.Pass();
            Assert.Positive();
            Assert.ReferenceEquals();
            Assert.That();
            Assert.Throws();
            Assert.Throws<>();
            Assert.ThrowsAsync();
            Assert.ThrowsAsync<>();
            Assert.True();
            Assert.Warn();
            Assert.Zero();
        }


    }

}
