using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectVS2015
{
    [AttributeUsage(AttributeTargets.All)]
    class MyAttribute : System.Attribute { }

    [TestClass]
    [Serializable]
    public class UnitTestPrjAttributeSupportTest
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
        //[DataRow(0)]
        [DataSource("asd")]
        //[DataTestMethod]
        [DeploymentItem("asdf")]
        [Description("asdf")]
        [ExpectedException(typeof(ArgumentException))]
        [HostType("asdf")]
       // [Ignore("asdf")] //text not supported
        [LoaderOptimization(1)]
        [MTAThread]
        [Obsolete("asdf")]
        [Owner("asd")]
        [Priority(1)]
        [Shadowing("asdf")]
        [STAThread]
        [TestCategory("asd")]
        [TestCleanup]
        [TestInitialize]
        [TestMethod]
        [TestProperty("propName", "propVal")]
        [Timeout(20)]
        [WorkItem(1)]
        public void AttributeSupportTestMethod() { }


    }

}
