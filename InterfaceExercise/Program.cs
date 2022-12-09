using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Car myFirstCar = new Car { Year = 2020, Make = "Honda", Model = "Civic", HasTrunk = true, Logo = "Eagle", YearEstablished = 2022  };
            Truck myFirstTruck = new Truck { Year = 2023, Make = "Honda", Model = "RidgeLine", HasBed = true, Logo = "Eagle", YearEstablished = 2022 };
            SUV myFirstSUV = new SUV { Year = 2019, Make = "Honda", Model = "HR-V", HasCargoHold = true, Logo = "Eagle", YearEstablished = 2022 };



            List<IVehicle> vehicles = new List<IVehicle>();
            vehicles.Add(myFirstCar);
            vehicles.Add(myFirstTruck);
            vehicles.Add(myFirstSUV);  

            List<ICompany> companys = new List<ICompany>();
            companys.Add(myFirstCar);
            

            foreach(IVehicle vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year} Make: {vehicle.Make} Model: {vehicle.Model}");
                Console.WriteLine();
                vehicle.Drive();
                Console.WriteLine();
            }

            foreach(ICompany company in companys)
            {
                Console.WriteLine($" My Company logo is an {company.Logo} and it was established in {company.YearEstablished}");
            }










            #region ToDo
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
            #endregion
        }
        
    }
}
