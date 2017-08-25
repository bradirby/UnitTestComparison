using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [AttributeUsage(AttributeTargets.All)]
    class MyAttribute : System.Attribute
    {

    }

    [TestClass]
    [Serializable]
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
