using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarriorToDeath;

namespace LearningC_.WarriorToDeath
{
    public class MagicWarrior : Warrior
    {
        int teleportChance = 0;
        CanTeleport teleportType = new CanTeleport();

        public MagicWarrior(string name, int health, int attackMax, int blockMax, int teleportChance) : base(name, health, attackMax, blockMax)
        {
            this.teleportChance = teleportChance;
        }

        public override int Block()
        {
            Random random = new Random();
            int randDodge = random.Next(1, 100);

            if(randDodge < teleportChance)
            {
                Console.WriteLine($"{Name} {teleportType.teleport()}");
                return 100;
            }
            else
            {
               return base.Block();
            }
        }

    }
}
