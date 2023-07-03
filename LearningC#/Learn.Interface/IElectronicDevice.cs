using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_.Interface
{
    internal interface IElectronicDevice
    {
        void On();
        void Off();
        void VolumeUp();
        void VolumeDown();
    }
}

// Can test on program.cs and testing for complex Interface using
//IElectronicDevice TV = Remote.getDevice();

//PowerButton powBut = new PowerButton(TV);

//powBut.Execute();
//powBut.Undo();
//powBut.VolumeUp();
//powBut.VolumeDown();