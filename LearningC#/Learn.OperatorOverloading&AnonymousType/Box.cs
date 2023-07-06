
using LearningC_.Learn.OperatorOverloading;

namespace LearningC_.Learn.OperatorOverloading
{
    public class Box
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Breadth { get; set; }

        public Box() :this(1,1,1) { }

        public Box(double length, double width, double breadth)
        {
            Length = length;
            Width = width;
            Breadth = breadth;
        }   

        public static Box operator +(Box box1, Box box2)
        {
            Box box = new Box()
            {
                Length = box1.Length + box2.Length,
                Width = box1.Width + box2.Width,
                Breadth = box1.Breadth + box2.Breadth
            };
            return box;
        }

        public static Box operator -(Box box1, Box box2)
        {
            Box box = new Box()
            {
                Length = box1.Length - box2.Length,
                Width = box1.Width - box2.Width,
                Breadth = box1.Breadth - box2.Breadth
            };
            return box;
        }

        public static bool operator ==(Box box1, Box box2)
        {
            if(
              (box1.Length == box2.Length) &&
              (box1.Breadth == box2.Breadth) &&
              (box1.Width == box2.Width)
               ) { return true; }
            return false;
            
        }

        public static bool operator !=(Box box1, Box box2)
        {
            if (
              (box1.Length != box2.Length) &&
              (box1.Breadth != box2.Breadth) &&
              (box1.Width != box2.Width)
               ) { return true; }
            return false;

        }

        public override string ToString()
        {
            return String.Format("Box with height : {0} | Width : {1} | Breadth: {2}", Length , Width, Breadth);
        }

        public static explicit operator int(Box box)
        {
            return (int)(box.Length + box.Width + box.Breadth);
        }

        public static implicit operator Box(int i)
        {
            return new Box(i,i,i);
        }
    }
}

////Operator Overloading
//Box box1 = new Box(2, 3, 4);
//Box box2 = new Box(5, 6, 7);
//Box box3 = box1 + box2;

//Console.WriteLine(box3.ToString());
//Console.WriteLine($"Box3 : {box3}");
//Console.WriteLine($"Box Integer : {((int)box3)}");

//Box box4 = (Box)4;

////Annonymous Type 
//var shopkins = new { Name = "Shopkins", Price = 4.99 };
//Console.WriteLine("{0} cost ${1}", shopkins.Name, shopkins.Price);

//var toyArrays = new[] { new {
//            Name = "Yo-Kai Pack", Price = 4.99},
//            new {Name = "Kugura Pack", Price = 9.99}
//        };
//foreach (var item in toyArrays)
//{
//    Console.WriteLine("{0} cost {1}", item.Name, item.Price);
//}