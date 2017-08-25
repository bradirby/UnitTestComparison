using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrjToTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGetMSTestProject
{

    public class AssertSupportTest
    {
        public void AssertSupportMethodTest()
        {
            var sut = new SystemUnderTest();

            Assert.AreEqual(null, sut);
            Assert.AreEqual<string>(null, "asdf");
            Assert.AreNotEqual(1,2);
            Assert.AreNotSame(sut, sut);
            Assert.AreSame(sut, sut);
            Assert.Equals(1, 2);
            Assert.Fail();
            Assert.Inconclusive();
            Assert.IsFalse(true);
            Assert.IsInstanceOfType(sut, typeof(SystemUnderTest));
            Assert.IsNotInstanceOfType(sut, typeof(SystemUnderTest));
            Assert.IsNotNull(sut);
            Assert.IsNull(sut);
            Assert.IsTrue(true);
            Assert.ThrowsException<ArgumentException>(() => sut.ToString());
            Assert.ThrowsExceptionAsync<ArgumentException>(() => sut.ToString());
        }


    }

}
