using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle - DONE
             * The vehicle class shall have three string properties Year, Make, and Model - DONE
             * Set the defaults to something generic in the Vehicle class - DONE "default value"
             * Vehicle shall have an abstract method called DriveAbstract with no implementation - DONE
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation. - DONE Console WriteLine inside Brackets
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle - DONE
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle - DONE
             * Provide the implementations for the abstract methods - DONE
             * Only in the Motorcycle class will you override the virtual drive method - DONE
            */

            // Create a list of Vehicle called vehicles
            List<Vehicle> vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */
            Car car1 = new Car() { HasTrunk= true, Make = "Placeholder Make 1",Model = "Placeholder Model 1", Year = "Placeholder Year" };
            Motorcycle mcycle1= new Motorcycle() { HasHandlebars = true, Make = "Placeholder Make 2", Model = "Placeholder Make 2", Year = "2000" };
            Vehicle hessTruck= new Car() { HasTrunk = true, Make = "Placeholder Make 3", Model = "Placeholder Model 3", Year = "Placeholder Year 3" };
            Vehicle moped = new Motorcycle() { HasHandlebars = true, Make = "Placeholder Make 4", Model = "Placeholder Model 4", Year = "Placeholder Year 4" };
            Console.WriteLine();
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            //This also will set the order they display?

            vehicles.Add(car1);
            vehicles.Add(hessTruck);
            vehicles.Add(moped);
            vehicles.Add(mcycle1);

            foreach (var item in vehicles)
            {
                Console.WriteLine($"Make: {item.Make}");
                Console.WriteLine();
                Console.WriteLine($"Model: {item.Model}");
                Console.WriteLine();
                Console.WriteLine($"Year: {item.Year}");
                Console.WriteLine();
                item.DriveAbstract();
                item.DriveVirtual();
                Console.WriteLine();
            }

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
        }
    }
}
