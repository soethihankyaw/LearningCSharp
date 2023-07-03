using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LearningC_.Interface
{
    internal class Remote
    {
        public static IElectronicDevice getDevice()
        {
            return new Television(50, "Samsung");
        }
    }
}
