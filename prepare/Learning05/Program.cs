using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square s = new Square("Green", 13);
        shapes.Add(s);
        Rectangle r = new Rectangle("Blue", 13,10);
        shapes.Add(r);
        Circle c = new Circle("Yellow", 20);
        shapes.Add(c);

        foreach(Shape sh in shapes){
            Console.WriteLine(sh.GetColor());
            Console.WriteLine(sh.GetArea());
        }
    }
}