using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise 
{
    internal class Car : ICompany, IVehicle
    {
        public bool HasEcoMode { get; set; }
        public string Name {get; set;}
        public int YearEsr {get; set;}
        public int WheelCount {get; set;}
        public string VehicleColor { get; set; }


        public void DriveBackward()
        {
            Console.WriteLine("Car backs up");
        }

        public void DriveForward()
        {
            throw new NotImplementedException();
        }

        public void NosBoost() 
        {
            Console.WriteLine("Would you like to use NOS");
            var answer =  Console.ReadLine().ToLower();
            if (answer == "yes")
            {
                Console.WriteLine("Boost activated");
            }
            if (answer == "no")
            {
                Console.WriteLine("Came in 4th place");
            }
            else
            {
                answer = Console.ReadLine().ToLower();
            }
        }
    }
}
