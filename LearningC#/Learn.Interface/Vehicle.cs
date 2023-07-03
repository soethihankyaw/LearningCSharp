using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_.Interface
{
    internal class Vehicle : IDrivealble
    {
        public string Brand { get; set; }

        public Vehicle(string brand, int wheels, double speed)
        {
            Brand = brand;
            Wheels = wheels;
            Speed = speed;
        }

        public int Wheels { get; set; }
        public double Speed { get; set; }

        public void Move()
        {
            Console.WriteLine("The {0} move forward with {1} wheels and {2} MPH", Brand, Wheels, Speed);
        }

        public void Stop()
        {
            Console.WriteLine("The {0} stopped.", Brand);
            Speed = 0;
        }
    }
}

// testing on program using interface
//Vehicle hyunDai = new Vehicle("Retio", 4, 165);

//if (hyunDai is IDrivealble)
//{
//    hyunDai.Move();
//    hyunDai.Stop();
//    hyunDai.Speed = 0;
//    Console.WriteLine("The Speed of {0} is {1} now", hyunDai.Brand, hyunDai.Speed);
//}
//else
//{
//    Console.WriteLine("{0} cannot be drive!!!", hyunDai.Brand);
//}