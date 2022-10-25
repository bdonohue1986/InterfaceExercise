using System;
using System.Collections.Generic;
using System.Linq;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            var cars = new List<IVehicle>();

            var explorer = new SUV() { VehicleColor = "Blue", Name = "Ford Explorer ", has3rdrow = true ,YearEsr = 2019, HowManySeats = "7", WheelCount = 4 };
           cars.Add(explorer);
            explorer.DriveBackward();
            explorer.DriveForward();
            var f150 = new Truck() { WheelCount = 6, YearEsr = 2022, BedOrTrunk = "Bed", HasHitch = true, Name = "Ford F-150", VehicleColor = "Red" };
            cars.Add(f150);
            f150.DriveBackward();
            f150.DriveForward();
            var new740 = new Car() { VehicleColor = "Silver", Name = "BMW 740", HasEcoMode = true, WheelCount = 4, YearEsr = 2020 };
            cars.Add(new740);
            new740.DriveBackward();
            new740.DriveForward();
            new740.NosBoost();

            foreach (var car in cars)
            {
                 cars.Count();
                car.DriveForward();
                car.DriveBackward();
               
            }
            
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
