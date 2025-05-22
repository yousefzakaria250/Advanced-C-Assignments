using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3.Models
{
    internal class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }

        public int Age 
        {
            get { return DateTime.Now.Year - Year; }
        
        }

        public double Drive(int distance)
        {
            Mileage = Mileage + distance;   
            return Mileage;
        }

        public override string ToString()
        {
            return $"My Car Model {Model} and Make in {Make} and in Year {Year} and Age of my Car {Age}";
        }
    }
}
