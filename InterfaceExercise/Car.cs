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
            Console.WriteLine("Car backs up.");
        }

        public void DriveForward()
        {
            Console.WriteLine("Car drives.");
        }

        public void NosBoost()
        {
            Console.WriteLine($"the {Name}'s Boost activated");
        }
          
    }
}
