using System;
namespace ConsoleUI
{
	public abstract class Vehicle
	{
        public int Year { get; set; } = 2004;
        public string Make { get; set; } = "default Make";
        public string Model { get; set; } = "default Model";


        public abstract void DriveAbstract(); //no implementation

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive.");

        }
    }
}

