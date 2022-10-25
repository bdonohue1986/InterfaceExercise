using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public bool HasHitch { get; set; }

        public string BedOrTrunk { get; set; }
        public int WheelCount {get; set;}
        public string VehicleColor { get; set; }

        public string Name {get; set;}
        public int YearEsr {get; set;}

        public void DriveBackward()
        {
            Console.WriteLine("Loud beeping and bright white lights activate");
        }

        public void DriveForward()
        {
            Console.WriteLine($"{Name} drives off");
            
         
        }
    }
}
