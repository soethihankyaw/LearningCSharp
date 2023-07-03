using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_.Interface
{
    internal interface IDrivealble
    {
        int Wheels { get; set; }
        double Speed { get; set; }

        void Move();
        void Stop();
    }
}
