
using LearningC_.Learn.Delegates;
using LearningC_.Learn.Generics;
using LearningC_.WarriorToDeath;
using System.Collections;
using WarriorToDeath;
using static LearningC_.Learn.Generics.Animal;

class Program
{
    static void Main(string[] args)
    {
        Arimathic add, sub, addSub;

        add = new Arimathic(Add);
        sub = new Arimathic(Substract);
        addSub = add + sub;

        Console.WriteLine($"Add {6} & {4}");
        add(6, 4);
        Console.WriteLine($"Substract {6} & {4}");
        sub(5, 5);
    }

    public delegate void Arimathic(double num1, double num2);
    public static void Add(double num1, double num2)
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }
        public static void Substract(double num1, double num2)
        {
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }

}