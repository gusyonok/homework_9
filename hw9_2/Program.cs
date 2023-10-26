using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;

string path = "F:\\gu.sy.on.ok\\SoftServe\\C#.Net Fundamentals\\hw9\\hw9_2\\analysis.txt";

try
{
    string[] strings = File.ReadAllLines(path);

    foreach (string s in strings)
    {
        Console.Write(s.Length + ", ");
    }
    Console.WriteLine('\n');

    string shortest = strings.OrderBy(line => line.Length).First();
    string longest = strings.OrderBy(strings => strings.Length).Last();
    Console.WriteLine($"The shortest string: {shortest}.");
    Console.WriteLine($"The longest string: {longest}.");
    Console.WriteLine("\nLines that contains word 'var':\n ");

    bool isExist = false;
    for (int i = 0; i < strings.Length; i++)
    {
        Regex regex = new Regex(@"var");
        if (regex.IsMatch(strings[i]))
        {
            Console.WriteLine(strings[i]);
            isExist = true;
        }
    }

    if (!isExist)
        Console.WriteLine("Lines that contains word 'var' don't exist.");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
