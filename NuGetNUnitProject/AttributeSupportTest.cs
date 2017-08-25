using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace NuGetNUnitProject
{
    [AttributeUsage(AttributeTargets.All)]
    class MyAttribute : System.Attribute { }

    [TestFixture]
    [SetUpFixture]
    [SingleThreaded]
    [TestFixtureSource("asdf")]
    public class AttributeSupportTest
    {
        //Assembly level attributes
        //[LevelOfParallelism(1)] 
        //[AssemblyCleanup]
        //[AssemblyInitialize]


        [Flags]
        enum MyEnum { }

        [ContextStatic]
        [Datapoint]
        [NonSerialized]
        private string FieldDeclaration;

        [Apartment(ApartmentState.MTA)]
        [Author("asdf")]
        [Category("asdf")]
        [CLSCompliant(true)]
        [Combinatorial]
        [Culture]
        [DatapointSource]
        [DefaultFloatingPointTolerance(2)]
        [Description("asdf")]
        [Explicit]
        [Ignore("asdf")]
        [MaxTime(2)]
        [NonParallelizable]
        [Obsolete("asdf")]
        [OneTimeSetUp]
        [OneTimeTearDown]
        [Order(52)]
        [Pairwise]
        [Parallelizable]
        [Platform]
        [Repeat(2)]
        [RequiresThread]
        [Retry(2)]
        [Sequential]
        [SetCulture("en-us")]
        [SetUICulture("en-us")]
        [SetUp]
        [TearDown]
        [Test]
        [TestCase]
        [TestCaseSource("asdf")]
        [TestOf("asdf")]
        [Theory]
        [Timeout(2)]
        public void AttributeSupportTestMethod(
            [Range(0, 10, 2)]double param,
            [Random(1)] int randomParam,
            [Values(3, 3, 3)] int valueParam,
            [ValueSource("asdf")] string paramSrcParam
            )
        { }

    }
}
