using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
  
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("what is your guess ?");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("heigher");
            }
    
            else if (magicNumber < guess)
            {
                Console.WriteLine("lower");
            }

            else 
            {
                Console.WriteLine("you guessed!");
            }
        }
    }
}