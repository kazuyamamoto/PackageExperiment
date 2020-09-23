using NUnit.Framework;
using PackageExperiment;

namespace PackageExperimentTests
{
    public class SomePackageTests
    {
        [Test]
        public void AccessPackageExported()
        {
            Assert.AreEqual("hello", SomePackage.ExportedValue);
        }

        [Test]
        public void AccessPackageInternal()
        {
            Assert.AreEqual("World", SomePackage.InternalValue);
        }
    }
}
