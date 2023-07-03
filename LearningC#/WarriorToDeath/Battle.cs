using LearningC_.WarriorToDeath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarriorToDeath;

namespace WarriorToDeath
{
    internal class Battle
    {
        public static void  StartFight(Warrior warrior1, Warrior warrior2)
        {
            while (true)
            {
                if (GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Battle Finished");
                    break;
                }
                if (GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Battle Finished");
                    break;
                }
            }
            
        }

        public static string GetAttackResult(Warrior warrior1, Warrior warrior2)
        {
            int war1Att = warrior1.Attack();
            //int war1Blc = warrior1.Block();

            //int war2Att = warrior2.Attack();
            int war2Blc = warrior2.Block();

            int dmgToWar2 = war1Att - war2Blc;

            if(dmgToWar2 > 0)
            {
                warrior2.Health -= dmgToWar2;
                Console.WriteLine("{0} attack {1} and Deals {2} Damage!!!",
                    warrior1.Name, warrior2.Name, dmgToWar2);
                Console.WriteLine("{0} has {1} Health \n", warrior2.Name, warrior2.Health);
            } else if(dmgToWar2 <= 0) 
            {
                Console.WriteLine("{0} block {1}'s attack!!!",warrior2.Name, warrior1.Name);
                Console.WriteLine("You can't hurt me\n");
            }

            

            if(warrior2.Health <= 0)
            {
                Console.WriteLine("{0} has died and {1} Victory", warrior2.Name, warrior1.Name);

                return "Game Over";
            } else
            {
                return "Fight Again";
            }

        }

    }
}

    //WarriorAbility thor = new WarriorAbility("Thor", 100, 38, 24, 55);
    //Warrior hulk = new Warrior("Hulk", 100, 32, 25);
    //Warrior doctorStrange = new Warrior("Doctor Strange", 100, 45, 20);
    //Warrior ironMan = new Warrior("IronMan", 100, 30, 23);
    //Warrior thanos = new Warrior("Thanos", 100, 35, 25);
    //Warrior capAmerica = new Warrior("Cap America", 100, 35, 25);
    //MagicWarrior loki = new MagicWarrior("Loki", 100, 28, 30, 50);

    //Battle.StartFight(thor, loki);

    //Console.WriteLine();
