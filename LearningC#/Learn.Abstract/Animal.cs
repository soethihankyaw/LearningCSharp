using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_.Learn.Abstract
{
    internal class Animal
    {
        private string name;
        private string sound;

        private AnimalInfoId animalInfoId = new AnimalInfoId();

        public void SetAnimalInfoID(int idNum, string owner)
        {
            animalInfoId.IdNum = idNum;
            animalInfoId.Owner = owner;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{name} make sound like {sound}");
        }

        public void GetAnimalIdInfo()
        {
            Console.WriteLine("{0} has the ID of {1} and is owned by {2}", name, animalInfoId.IdNum, animalInfoId.Owner);
        }


        public string Sound { get => sound; set => sound = value; }

        public string Name { get => name; set => name = value; }


        public Animal()
        {
            name = "No Name";
            sound = "No Sound";

        }

        public Animal(string name, string sound, string owner)
        {
            this.name = name;
            this.sound = sound;

        }

        //public Animal(string name="No Name", string sound = "No Sound")
        //{
        //    this.name = name;
        //    this.sound = sound;
        //    numOfAnimals++;
        //}


        //For testing must be run on Program.Main
        //Animal animal = new Animal("Pape", "WOof");
        //Console.WriteLine("{0} make a {1} when he saw a stranger!", animal.name, animal.sound);

        //setter with validation    
        public void SetName(string name)
        {
            if (!name.Any(char.IsDigit))
            {
                this.name = name;
            }
            else
            {
                this.name = "No Name";
                Console.WriteLine("Name Can't Contain Number.");
            }
        }

        public string GetName()
        {
            return name;
        }

        public class AnimalHealth
        {
            public bool HealthyWeight(double height, double weight)
            {
                double calc = height / weight;
                if (calc <= .18 && calc >= .27)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
    }
}
