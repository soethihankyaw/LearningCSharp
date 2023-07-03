using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_.Interface
{
    internal class Television : IElectronicDevice
    {
        public Television(int volume, string deviceName)
        {
            DeviceName = deviceName;
            Volume = volume;
        }

        public string DeviceName { get; set; } = "";
        public int Volume { get; set; }


        public void Off()
        {
            Console.WriteLine("The {0} is Off", DeviceName);
        }

        public void On()
        {
            Console.WriteLine("The {0} is On", DeviceName);
        }

        public void VolumeUp()
        {
            if (Volume != 0)
            {
                Volume--;
            }
            Console.WriteLine("The {0} volume at {1}", DeviceName, Volume);
        }

        public void VolumeDown()
        {
            if (Volume != 99)
            {
                Volume++;
            }
            Console.WriteLine("The {0} volume at {1}", DeviceName, Volume);
        }
    }
}
