using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGetMSTestProject
{
    [TestClass]
    [Serializable]
    [AttributeUsage(AttributeTargets.All)]
    public class NugetAttributeSupportTest
    {
        [ContextStatic]
        [ThreadStatic]
        [NonSerialized]
        private string FieldDeclaration;

        [Flags]
        enum MyEnum { }


        [AssemblyCleanup]
        [AssemblyInitialize]
        [ClassCleanup]
        [ClassInitialize]
        [CLSCompliant(true)]
        [CssIteration("asdf")]
        [CssProjectStructure("asdf")]
        [DataRow(0)]
        [DataSource("asd")]
        [DataTestMethod]
        [DeploymentItem("asdf")]
        [Description("asdf")]
        [ExpectedException(typeof(ArgumentException))]
        [HostType]
        [Ignore("asdf")]
        [LoaderOptimization(1)]
        [MTAThread]
        [Obsolete]
        [Owner("asd")]
        [ParamArray]
        [Priority(1)]
        [Shadowing]
        [STAThread]
        [TestCategory("asd")]
        [TestCleanup]
        [TestInitialize]
        [TestMethod]
        [TestProperty("propName", "propVal")]
        [Timeout(20)]
        [WorkItem(1)]
        public void AttributeSupportTestMethod()
        {

        }


    }

}
