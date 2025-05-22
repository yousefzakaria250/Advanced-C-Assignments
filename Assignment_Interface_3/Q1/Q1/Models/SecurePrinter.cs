using Q1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1.Models
{
    internal class SecurePrinter : IPrinter
    {
        public void Print(string documentName)
        {
            Console.WriteLine(documentName);
        }

        
    }
}
