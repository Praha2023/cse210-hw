using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcomeMessage();

        string userName = PromptUserName();

        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }
     static void DisplayWElcomeMessage()
    {
        Console.WriteLine("Welcome to the programe!");
    }
     static string PromptUserName()
    {
        Console.Write("{please enter your name: }");
        String name = Console.ReadLine();

        return name;
    }
    static int PromptUserNUMber()
    {
        Console.Write("please enter your favourite number");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    static int SquareNumber(int number)
    {
        int square = number**;
        return square;
    }
    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($ "{square}, the square of your number is {square}");
    }

}