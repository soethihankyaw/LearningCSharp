
using LearningC_.WarriorToDeath;
using WarriorToDeath;

class Program
{
    static void Main(string[] args)
    {
        WarriorAbility thor = new WarriorAbility("Thor", 100, 38, 24, 55);
        Warrior hulk = new Warrior("Hulk", 100, 32, 25);
        Warrior doctorStrange = new Warrior("Doctor Strange", 100, 45, 20);
        Warrior ironMan = new Warrior("IronMan", 100, 30, 23);
        Warrior thanos = new Warrior("Thanos", 100, 35, 25);
        Warrior capAmerica = new Warrior("Cap America", 100, 35, 25);
        MagicWarrior loki = new MagicWarrior("Loki", 100, 28, 30, 50);

        Battle.StartFight(thor, loki);

        Console.WriteLine();
        
    }

   
}