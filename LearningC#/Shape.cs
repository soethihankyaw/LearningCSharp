﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Abstract
{
    abstract class Shape
    {
        public string Name { get; set; }    

        public virtual void GetInfo()
        {
            Console.WriteLine($"My name is {Name}");
        }

        public abstract double Area();
    }
}
