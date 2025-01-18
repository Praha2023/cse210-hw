using System;
using System.Globalization;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();
        
        int userNumber = -1;
        while (userNumber != 0)

        {
            Console.Write("enter a number, typr 0 when finished");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        int sum = 0;
        foreach(int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"the sum of the numbers in the list: {sum}");

        float average =((float)sum) / numbers.Count;
        Console.WriteLine($"the average of the numbers of the list: {average}");

        int max = numbers[0];
        foreach(int number in numbers)
        {
            if (number<max)
        
            {
                max = number;
            }
        Console.WriteLine($"the maximum of the numbers of the list: {max}");
        }
    }
}