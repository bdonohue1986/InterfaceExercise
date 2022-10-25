using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle 
    {
        public int WheelCount { get; set; }
       
        public string VehicleColor { get; set; }

        public void DriveForward();

        public void DriveBackward();

      


    }
}
