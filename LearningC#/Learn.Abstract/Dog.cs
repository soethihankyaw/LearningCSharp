using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LearningC_.Learn.Abstract
{
    internal class Dog : Animal
    {
        public string Sound2 { get; set; } = "Woof";

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} say {Sound} and {Sound2}");
        }
    }


}

//Animal cat = new Animal();
//cat.SetName("CeCe");
//cat.Sound = "Meow";


//Console.WriteLine("The cat name is {0} and says {1}", cat.GetName(), cat.Sound);

//Animal animal = new Animal("Goat", "PaePae", "Derek");

//Animal doParmin = new Dog();
//doParmin.SetName("melo");
//doParmin.Sound = "Woof Woof";
//doParmin.MakeSound();


//Console.WriteLine("Area Of Reactangle : {0}", ShapeMath.GetArea("rectangle", 5, 6));

//int? RandomNum = null;

//if (RandomNum != null)
//{
//    Console.WriteLine("RandomNum : {0}", RandomNum);
//}
//if (RandomNum == null)
//{
//    Console.WriteLine("RandomNum : {0}", RandomNum);
//}
