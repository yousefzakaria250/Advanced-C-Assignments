using Q1.Interfaces;
using Q1.Models;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------- Q1 ----------------");
            // Q1
            SimplePrinter simplePrinter = new SimplePrinter();
            simplePrinter.Print("Invoice.pdf");

            Console.WriteLine("-------------------- Q2 ----------------");
            // Q2

            SmartDevice smartDevice = new SmartDevice();
            smartDevice.Print("Invoice.pdf");
            smartDevice.Scan("Scanning files....");
            smartDevice.Fax("Fax files..." , "12");

            Console.WriteLine("-------------------- Q3 ----------------");

             IMaintenance serviceMachine   = new ServiceMachine();
            serviceMachine.PowerOn();
            serviceMachine.SelfCheck();

            Console.WriteLine("-------------------- Q4 ----------------");

            SecurePrinter securePrinter = new SecurePrinter();
            securePrinter.PrintDocument();


            IPrinter printer = new SecurePrinter();
            printer.PrintDocument("test");


            Console.WriteLine("-------------------- Q5 ----------------");

            Copier copier = new Copier();
            copier.ShowModelInfo();
            copier.Start();

            Console.WriteLine("-------------------- Q6 ----------------");

            SmartCopier smartCopier = new SmartCopier();
            smartCopier.ShowModelInfo();
            smartCopier.Start();
            smartCopier.Print("Test.pdf");
            smartCopier.Fax("test", "2323");
            smartCopier.PowerOn();
            smartCopier.SelfCheck();

        }
    }
}
