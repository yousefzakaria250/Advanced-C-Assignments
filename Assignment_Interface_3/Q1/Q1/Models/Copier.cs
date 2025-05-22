using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1.Models
{
    internal class Copier :OfficeMachine
    {
        public Copier() :base("Test Model Name"){ }

        public override void Start()
        {
            Console.WriteLine("Copier is starting up...");
        }
    }
}
