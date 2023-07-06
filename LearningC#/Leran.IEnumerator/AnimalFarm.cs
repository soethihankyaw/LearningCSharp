using LearningC_.Leran.IEnumerator;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_.Leran.IEnumerator
{
    class AnimalFarm : IEnumerable
    {
        private List<Animals> animalsList = new List<Animals>();

        public AnimalFarm() { }

        public AnimalFarm(List<Animals> animalsList)
        {
            this.animalsList = animalsList;
        }

        public System.Collections.IEnumerator GetEnumerator()
        {
            return animalsList.GetEnumerator();
        }

        public Animals this[int index]
        {
            get { return (Animals)animalsList[index]; }
            set { animalsList.Insert(index, value); }
        }

        public int Count
        {
            get {
                return animalsList.Count;
            }
        }
    }
}

//AnimalFarm myAnimals = new AnimalFarm();
//myAnimals[0] = new Animals("Wulfur");
//myAnimals[1] = new Animals("Austin");
//myAnimals[2] = new Animals("Thanos");
//myAnimals[3] = new Animals("Kukukoo");

//foreach (Animals animal in myAnimals)
//{
//    Console.WriteLine(animal.Name);
//}