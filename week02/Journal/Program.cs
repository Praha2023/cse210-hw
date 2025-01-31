using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
    
        Console.WriteLine("Hello World! This is the Journal Project.");

        Console.WriteLine("please select one of the followong...");
        Console.WriteLine("1.Add entry");
        Console.WriteLine("2.Display");
        Console.WriteLine("3.Load");
        Console.WriteLine("4.Save.");
        Console.WriteLine("5.quit");
        



        Entry e1 = new Entry();
        e1._date = DateTime.Now.ToShortDateString();
        e1._promptText = "how can i help you today..? ";
        Console.WriteLine(e1._promptText);
        e1._entryText =Console.ReadLine();
        

        Entry e2 = new Entry();
        e2._date = "DateTime.Now";
        e2._promptText = "did you felt the spirit guidence today..?";
        Console.WriteLine(e2._promptText);
        e2._entryText  = Console.ReadLine();

        Entry e3 = new Entry();
        e3._date = "DateTime.Now";
        e3._promptText ="what made you happy today..?";
        Console.WriteLine(e3._promptText);
        e3._entryText = Console.ReadLine();

        Entry e4 = new Entry();
        e4._date ="DateTime.Now";
        e4._promptText = "are you up to date to all your assignments..?";
        Console.WriteLine(e4._promptText);
        e4._entryText =Console.ReadLine();

        Entry e5 = new Entry();
        e5._date = "DateTime.Now";
        e5._promptText = "what sacrifices you have to made to get succes in your degree..?";
        Console.WriteLine(e5._promptText);
        e5._entryText = Console.ReadLine();


        Journal myJournal = new Journal();

        myJournal.AddEntry(e1);
        myJournal.AddEntry(e2);
        myJournal.AddEntry(e3);
        myJournal.AddEntry(e4);
        myJournal.AddEntry(e5);


        myJournal.DisplayAll();


    }

}
      

