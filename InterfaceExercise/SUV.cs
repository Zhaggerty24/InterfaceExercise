using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
   public class SUV : IVehicle, ICompany
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool HasCargoHold { get; set; }
        public string Logo { get; set; }
        public int YearEstablished { get; set; }

        public void Drive()
        {
            Console.WriteLine($"My {GetType().Name} drives well!");
        }
    }
}
