using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q1.Interfaces;

namespace Q1.Models
{
    internal class SimplePrinter : IPrinter
    {
        public void Print(string documentName)
        {
            Console.WriteLine($"{documentName}");
        }
    }
}
