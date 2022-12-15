using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool HasHandlebars { get; set; }


        public override void DriveAbstract()
        {
            Console.WriteLine($"This {GetType().Name} A L S O has Abstract Implementation!");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} has a Virtual Drive Override"); ;
        }
    }
}
