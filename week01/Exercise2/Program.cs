using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
    }

    {
        Console.Write("what is your grade percentage ?");
        string answer = Console.ReadLine;
        int percent = int.Phrase(answer);

        string letter = "";

        if (percent >=90)
        {
            letter = "A";
        }

        else if (percent >=80)
        {
            letter = "B";
        }

        else if (percent >=70)
        {
            letter "C";
        }

        else if (percent >=60)
        {
            letter "D";
        }

        else 
        {
            letter "f";
        }

        Console.WriteLine($ "your grade: {letter}");

    }

    {
        if (percent >= 70)
        {
            Console.WriteLine(congratulation. you passed);
        }

        else 
        {
            Console.WriteLine(Dont get discouraged, give your best next time);
        }
    }
}
