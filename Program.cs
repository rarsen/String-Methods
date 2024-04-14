using System.ComponentModel;

class task8
{
    static void Main(string[] args)
    {
        Console.WriteLine("--------------------Task 1--------------------");
        Console.WriteLine("Write a string: ");
        string s = Console.ReadLine();

        Console.WriteLine("Enter a substring to be found in the string: ");

        string theword = Console.ReadLine();

        if (s.Contains(theword))
        {
            Console.WriteLine("Your word is found at position " + s.IndexOf(theword));
        }
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine();
        task2();
    }
    static void task2()
    {
        Console.WriteLine("--------------------Task 2--------------------");
        Console.WriteLine("Write a string: ");
        string s1 = Console.ReadLine();

        foreach (var x in s1)
        {
            Console.Write(x+" ");
        }
        Console.WriteLine();
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine();
        task3();
    }
    static void task3()
    {
        Console.WriteLine("--------------------Task 3--------------------");
        Console.WriteLine("Write a string: ");
        string s = Console.ReadLine();
        Console.WriteLine("New text: " + s.Replace(s, "GoodBye, GoodBye"));
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine();
    }
}