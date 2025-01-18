public class Resume
{
    public string _name;
    public List<Job> _job = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"name: {_name}");
        Console.WriteLine($"job:");

        foreach(Job job in _job)
        {
            job.Display();
        }
    }
    
}