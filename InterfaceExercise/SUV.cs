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
            Console.WriteLine($"{Name} Backs up ");
            
            
        }

        public void DriveForward()
        {
            Console.WriteLine($"Please buckle your seatbelt or the {Name} will not move");
        }
    }
}
