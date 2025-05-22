using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1.Models
{
    internal abstract class OfficeMachine
    {
        private string modelName; 
        protected OfficeMachine(string modelName)
        {
            this.modelName = modelName;   
        }

      public void ShowModelInfo()
      {
            Console.WriteLine($"Model: {modelName}");
      }

        public abstract void Start();

    }
}
