using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_.Interface
{
    internal interface ICommand
    {
        void Execute();
        void Undo();
        void VolumeUp();
        void VolumeDown();
    }
}
