using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_.Learn.Others
{
    public class LearnEnum
    {
        internal void paintColor(CarColor color)
        {
            Console.WriteLine("The car is painted with {0} and color of code is {1}", color, (int)color);
        }


    }

    enum CarColor : byte
    {
        Orange = 1,
        Yellow,
        Red,
        Green,
        Blue
    }

    //For testing must be run on Program.Main
    //LearnEnum learnEnum = new LearnEnum();
    //learnEnum.paintColor(CarColor.Blue);
}
