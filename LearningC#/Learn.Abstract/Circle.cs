using LearningC_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_.Learn.Abstract
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Name = "Circle";
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2.0);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("It has a {0} radius.", Radius);
        }
    }
}


//Testing Abstract class and if u want to run, put on main 
//Shape[] shapes = { new Circle(5), new Rectangle(4, 5), new Square(4.0) };

//foreach (Shape s in shapes)
//{
//    s.GetInfo();
//    Console.WriteLine("{0} Area : {1:F2}", s.Name, s.Area());

//    Circle testCircl = s as Circle;
//    if (testCircl == null)
//    {
//        Console.WriteLine("This isn't a Circle");
//    }
//    if (s is Circle)
//    {
//        Console.WriteLine("This isn't a Rectangle");
//    }
//    Console.WriteLine();

//}

//object circ1 = new Circle(5);
//Circle circ2 = (Circle)circ1;
//Console.WriteLine("The {0} of Area is {1} \n", circ2.Name, circ2.Area());

//object rect1 = new Rectangle(5, 5);
//Rectangle rect2 = (Rectangle)rect1;
//Console.WriteLine("The {0} of Area is {1} \n", rect2.Name, rect2.Area());

//object square1 = new Square(3);
//Square square2 = (Square)square1;
//Console.WriteLine("The {0} of Area is {1}", square2.Name, square2.Area());


