using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Class.Static.This.NullableTypes
{
    internal class Animal
    {
        private string name;
        private string sound;
        private static int numOfAnimals = 0;
        private const string SHELTER = "HOME SWEET HOME";
        private readonly int idNumber;

        public string Sound { get => sound; set => sound = value; }
        public static int NumOfAnimals { get => numOfAnimals; set => numOfAnimals = value; }

        public Animal()
        {
            name = "No Name";
            sound = "No Sound";
            NumOfAnimals++;
        }

        public Animal(string name, string sound)
        {
            this.name = name;
            this.sound = sound;
            NumOfAnimals++;
        }

        //public Animal(string name="No Name", string sound = "No Sound")
        //{
        //    this.name = name;
        //    this.sound = sound;
        //    numOfAnimals++;
        //}

        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", name, sound);
        }

        public static int getNumAnimals()
        {
            return NumOfAnimals;
        }

        //For testing must be run on Program.Main
        //Animal animal = new Animal("Pape", "WOof");
        //Console.WriteLine("{0} make a {1} when he saw a stranger!", animal.name, animal.sound);

        //setter with validation    
        public void SetName(string name)
        {
            if(!name.Any(Char.IsDigit))
            {
                this.name = name;
            } else
            {
                this.name = "No Name";
                Console.WriteLine("Name Can't Contain Number.");
            }
        }

        public string GetName()
        {
            return name;
        }
    }
}
