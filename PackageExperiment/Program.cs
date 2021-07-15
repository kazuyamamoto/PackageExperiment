using System;

namespace PackageExperiment
{
    internal static class Program
    {
        private static void Main()
        {
            // var uc = new SomePackage.UnexportedClass(); // コンパイルエラー!
            var ec = new SomePackage.ExportedClass();
            ec.Print();

            try
            {
                ec.Throw();
            }
            catch (SomePackage.ExportedException e)
            {
                Console.WriteLine(e);
            }
            
            Console.WriteLine(SomePackage.ExportedValue);
            SomePackage.ExportedFunction();
            
            SomePackage.IExported ei = new SomePackage.ExportedImpl();
            ei.Hello();
            
            ei = new ExternalImpl();
            ei.Hello();
        }
    }

    class ExternalImpl : SomePackage.IExported
    {
        public void Hello()
        {
            Console.WriteLine("Hello from external impl");
        }
    }
}
