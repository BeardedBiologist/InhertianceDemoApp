using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo 
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Corolla corolla = new Corolla();

            Console.ReadLine();
        }
    }

    public class Car
    {
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }

        public void StartCar()
        {
            
        }

        public void StopCar()
        {

        }
    }

    public class Tundra
    {
        
    }

    // A Corolla is a car
    public class Corolla : Car
    {
        
    }

    // A Camry is a car
    public class Camry : Car
    {

    }
}