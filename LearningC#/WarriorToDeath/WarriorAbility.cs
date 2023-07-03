using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarriorToDeath;

namespace LearningC_.WarriorToDeath
{
    public class WarriorAbility : Warrior
    {
        
        int LightingStrikeChance = 0;
        LightingStrike lightingStrike = new LightingStrike();

        public WarriorAbility(string name, int health, int attackMax, int blockMax, int LightingStrikeChance) : base(name, health, attackMax, blockMax)
        {
            this.LightingStrikeChance = LightingStrikeChance;
        }

        public override int Attack()
        {
            Random random = new Random();
            int randDodge = random.Next(1, 100);

            if (randDodge < LightingStrikeChance)
            {
                Console.WriteLine($"{Name} {lightingStrike.LightingStrikes()}");
                return 75;
            }
            else
            {
                return base.Attack();
            }
        }
    }
}
