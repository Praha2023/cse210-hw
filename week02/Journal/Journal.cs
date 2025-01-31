using System.IO;
using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public List<Entry>_entries = new List<Entry>();


    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        Console.WriteLine($"{_entries}");
         foreach (Entry entry in _entries)
         {
            entry.Display();
         }
    }

    public void SaveToFile (string file)

    { 
        Console.WriteLine("please enter the file name in which you want to save");
        //name = Console.ReadLine();

        string filename = Console.ReadLine();
        
        
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                writer.WriteLine($"{e._date}");
                writer.WriteLine($"{e._promptText}");
                writer.WriteLine($"{e._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
     {
        
     }
}