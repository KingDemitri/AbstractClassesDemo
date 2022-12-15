using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public string Year { get; set; } = "default";
        public string Make { get; set; } = "default value";
        public string Model { get; set; } = "default value";

        //Step 4
        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} has a Default Virtual Drive Method");
        }
    }
}
