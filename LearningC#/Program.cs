using Learn.Class.Static.This.NullableTypes;
using Learn.Date.And.Time;
using Learn.Enum;
using Learn.Struts;

class Program
{
    static void Main(string[] args)
    {
        Animal cat = new Animal();
        cat.SetName("CeCe");
        cat.Sound = "Meow";
        
       

        Animal animal = new Animal("Goat","PaePae");

        Console.WriteLine("The number of animal {0}", Animal.getNumAnimals());

        Console.WriteLine("Area Of Reactangle : {0}", ShapeMath.GetArea("rectangle", 5, 6));

        int? RandomNum = null;

        if(RandomNum != null)
        {
            Console.WriteLine("RandomNum : {0}", RandomNum);
        }
        if(RandomNum == null)
        {
            Console.WriteLine("RandomNum : {0}", RandomNum);
        }


    }

   
}