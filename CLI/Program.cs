using Backend;

class Program
{
    static void Main(string[] args)
    {
        if (args[0] == "projects")
        {
            ProjectParser projectParser = new();
            projectParser.ParseArgs(args);
            //File.WriteAllText
        }
    }
}
