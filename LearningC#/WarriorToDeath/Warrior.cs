using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorToDeath
{
    public class Warrior
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackMax { get; set; }
        public int BlockMax { get; set; }

        Random random = new Random();

        public Warrior(string name, int health, int attackMax, int blockMax)
        {
            Name = name;
            Health = health;
            AttackMax = attackMax;
            BlockMax = blockMax;
        }

        public virtual int Attack()
        {
            return random.Next(1, AttackMax);
        }

        public virtual int Block()
        {
            return random.Next(1, BlockMax);
        }


    }
}
