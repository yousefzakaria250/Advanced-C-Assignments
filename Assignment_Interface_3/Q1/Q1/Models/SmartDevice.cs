using Q1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1.Models
{
    internal class SmartDevice : IPrinter, IScanner, IFax
    {
        public void Fax(string doc, string number)
        {
            Console.WriteLine($"Doc {doc} and Number {number}");
        }

        public void Print(string documentName)
        {
            Console.WriteLine($"{documentName}");
        }

        public void Scan(string doc)
        {
            Console.WriteLine($"{doc}");
        }
    }
}
