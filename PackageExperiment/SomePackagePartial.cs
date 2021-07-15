using System;

namespace PackageExperiment
{
    /// <summary>
    ///     パッケージの別ファイルでの定義。
    ///     1つのパッケージに要素が多すぎる場合、ファイルを分けることもできる。
    /// </summary>
    public static partial class SomePackage
    {
        public interface IExported
        {
            public void Hello();
        }

        public class ExportedImpl : IExported
        {
            public void Hello()
            {
                Console.WriteLine("hello world");
            }
        }

        internal const string InternalValue = "World";

        private const string PrivateValue = "Japan";

        public static string GetInternalValue()
        {
            return InternalValue;
        }

        public static string GetPrivateValue()
        {
            return PrivateValue;
        }
    }
}
