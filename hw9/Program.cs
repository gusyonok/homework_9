using hw9;
using System.Collections.Generic;

List<Shape> shapes = new List<Shape>();

shapes.Add(new Circle("Mirror", 3.0));
shapes.Add(new Square("Box", 9.0));
shapes.Add(new Circle("Plate", 0.5));
shapes.Add(new Square("Bed", 20.0));
shapes.Add(new Circle("Disk", 5.0));
shapes.Add(new Square("Book", 1.0));

try
{
    string path = "F:\\gu.sy.on.ok\\SoftServe\\C#.Net Fundamentals\\hw9\\hw9\\shapes.txt";

    using StreamWriter sw = new StreamWriter(path,true);
    {
        var results = from s in shapes
                      where s.Area() >= 10 && s.Area() <= 100
                      select s.Name;

        sw.WriteLine("Shapes that have area in range [10,100]:");
        foreach (string name in results)
        {
            sw.WriteLine(name);
        }

        var results2 = from s in shapes
                       where s.Name.ToLower().Contains('a')
                       select s.Name;

        sw.WriteLine("Shapes that have 'a' in their names: ");
        foreach (string name in results2)
        {
            sw.WriteLine(name);
        }
    }

    shapes.RemoveAll(shape => shape.Perimeter() < 5);

    foreach (Shape shape in shapes)
        Console.WriteLine($"Name: {shape.Name}, area: {shape.Area()}, perimeter: {shape.Perimeter()}");

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
