using LearningC_.Learn.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LearningC_.Learn.Generics.Animal;

namespace LearningC_.Learn.Generics
{
    class Animal
    {
        public string Name { get; set; }

        public Animal() { }
        public Animal(string name) { Name = name; }

        //generic method
        public static void sum<T>(ref int x,ref int y)
        {
            double dblX = Convert.ToDouble(x);
            double dblY = Convert.ToDouble(y);

            Console.WriteLine($"{dblX} + {dblY} = {dblX + dblY}");
        }
        
        public struct Rectangle<T>
        {
            //generic variable
            private T width;
            private T height;

            //generic constructor
            public Rectangle(T width, T height)
            {
                this.width = width;
                this.height = height;
            }

            public T Width { get => width; set => width = value; }
            public T Height { get => height; set => height = value; }

            public string GetArea()
            {
                double dblWidth = Convert.ToDouble(Width);
                double dblHeight = Convert.ToDouble(Height);

                return string.Format($"{Width} * {Height} = {dblWidth * dblHeight} ");
            }
        }
    }
}

// If U want to run Pass to run method
//List<Animal> animalList = new List<Animal>();

//List<int> numList = new List<int>();
//numList.Add(24);

//animalList.Add(new Animal("Lion"));
//animalList.Add(new Animal("Tiger"));
//animalList.Add(new Animal("Whale"));

//animalList.Add(new Animal("Monkey"));

////Remove from list exact list, removing tiger
//animalList.RemoveAt(1);
////Count() used for counting
//Console.WriteLine(animalList.Count);
//foreach (var a in animalList)
//{
//    Console.WriteLine(a.Name);
//}

//int x = 3, y = 8;
//Animal.sum<int>(ref x, ref y);
////string strX = "5", strY = "3";
////Animal.sum<string>(ref strX, ref strY);


//Rectangle<int> rectangle = new Rectangle<int>(3, 6);
//rectangle.Width = 3;
//rectangle.Height = 7;
//Console.WriteLine(rectangle.GetArea());