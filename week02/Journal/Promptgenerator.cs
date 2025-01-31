using System.Security.Cryptography;

public class Promptgenerator
{

    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        return " {_prompts}";
    }
}