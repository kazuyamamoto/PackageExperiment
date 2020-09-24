using System;

namespace PackageExperiment
{
    /// <summary>
    ///     パッケージを表す。
    ///     パッケージが公開しない要素には、パッケージ外からアクセス不可にする。
    /// </summary>
    public static partial class SomePackage
    {
        /// <summary>
        ///     公開定数。
        /// </summary>
        public const string ExportedValue = "hello";

        /// <summary>
        ///     公開関数。
        /// </summary>
        public static void ExportedFunction()
        {
            Console.WriteLine("ExportedFunction!");
        }

        /// <summary>
        ///     公開クラス。
        /// </summary>
        public class ExportedClass
        {
            private readonly UnexportedClass _unexported;

            public ExportedClass()
            {
                _unexported = new UnexportedClass();
            }

            public void Print()
            {
                Console.WriteLine(_unexported.Value());
            }

            /// <summary>
            ///     例外をスローする。
            /// </summary>
            /// <exception cref="ExportedException">必ずスローする。</exception>
            public void Throw()
            {
                throw new ExportedException();
            }
        }

        /// <summary>
        ///     非公開クラス。
        ///     パッケージ内でしかアクセスできない。
        /// </summary>
        private class UnexportedClass
        {
            private readonly int _val;

            public UnexportedClass()
            {
                _val = 123;
            }

            public int Value()
            {
                return _val;
            }
        }

        /// <summary>
        ///     公開例外クラス。
        /// </summary>
        public class ExportedException : Exception { }
    }
}
