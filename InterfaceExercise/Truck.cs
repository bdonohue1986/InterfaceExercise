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
            throw new NotImplementedException();
        }

        public void DriveForward()
        {
            Console.WriteLine("Is your seatbelt buckled?");
            var answer = Console.ReadLine().ToLower();
            if (answer == "yes")
            {
                Console.WriteLine("Truck Drives forward");
            }
            if (answer == "no")
            {
                Console.WriteLine("Please buckle your seatbelt.");
            }
            else
            {
                Console.WriteLine("Please respond yes or no");
                answer = Console.ReadLine().ToLower();
            }
        }
    }
}
