using Q1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1.Models
{
    internal class ServiceMachine : IMaintenance
    {
        public void PowerOn()
        {
            Console.WriteLine("Device is now powered on.");
        }

        public void SelfCheck()
        {
            Console.WriteLine("Running diagnostics...");
        }
    }
}
