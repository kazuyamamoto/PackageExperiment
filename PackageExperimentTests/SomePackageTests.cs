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
            // InternalVisibleTo 属性を有効にしている 
            Assert.AreEqual("World", SomePackage.InternalValue);
        }
    }
}
