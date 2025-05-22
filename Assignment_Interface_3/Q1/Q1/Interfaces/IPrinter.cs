using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1.Interfaces
{
    internal interface IPrinter
    {
        void Print(string documentName);
        void PrintDocument(string doc)
        {
            Console.WriteLine($"[SecurePrinter] Printing confidential document: {doc}");
        }
    }
}
