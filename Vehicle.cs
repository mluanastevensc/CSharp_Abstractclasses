using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {
        
        public string Model { get; set; } = "Avaton";
        public string Make { get; set; } = "Toyota";
        public int Year { get; set; } = 2000;

        public abstract void DriveAbstract();


        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is viartually in drive");
        }

    }
}
