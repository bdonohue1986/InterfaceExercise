using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : ICompany, IVehicle
    {
        public bool has3rdrow { get; set; }
        public string HowManySeats { get; set; }
        public string Name {get; set;}
        public int YearEsr {get; set;}
        public int WheelCount {get; set;}
        public string VehicleColor { get; set; }

        public void DriveBackward()
        {
            Console.WriteLine("Did you check your mirrors?");
            var answer = Console.ReadLine().ToLower();
            if (answer == "yes")
            {
                Console.WriteLine("Truck Drives forward");
            }
            if (answer == "no")
            {
                Console.WriteLine("Please check your mirrors.");
            }
            else
            {
                Console.WriteLine("Please respond yes or no");
                answer = Console.ReadLine().ToLower();
            }
        }

        public void DriveForward()
        {
            Console.WriteLine($"Please buckle your seatbelt or the {Name} will not move");
        }
    }
}
