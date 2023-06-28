using Learn.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_
{
    class Square : Shape
    {   

        public double Lenght {  get; set; }

        public Square(double length) {
            Name = "Square";
            Lenght = length;
        }

        public override double Area()
        {
            return Math.Pow(Lenght,2.0);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("It has a pair of {0}",Lenght);
        }
    }
}
