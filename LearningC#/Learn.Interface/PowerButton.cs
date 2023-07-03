using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_.Interface
{
    internal class PowerButton : ICommand
    {


        IElectronicDevice _device;

        public PowerButton(IElectronicDevice device)
        {
            _device = device;
        }

        public void Execute()
        {
            _device.On();
        }

        public void Undo()
        {
            _device.Off();
        }

        public void VolumeUp()
        {
            _device.VolumeUp();
        }

        public void VolumeDown()
        {
            _device.VolumeUp();
        }
    }
}
