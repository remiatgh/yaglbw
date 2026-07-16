using Backend;

public class ProjectParser
{

    public void ParseArgs(string[] args)
    {
        if (args[1] == "list")
        {
            ProjectsManager projectsManager = new();
            Project[] projects = projectsManager.GetProjects();
            if (projects.Length > 0)
            {
                for (int index = 0; index < projects.Length; index++)
                {
                    Console.WriteLine("+");
                    Console.WriteLine("| - Name: " + projects[index].Name);
                    Console.WriteLine("| - Path: " + projects[index].Path);
                    Console.WriteLine("| - Godot Version: " + projects[index].GodotVersion);
                    
                    //projects[index]
                }
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("It looks like you haven't added a project to YAGLBW. Do it. I'm not going to guess it.");
            }
        }
        else
        {
            Console.WriteLine("Invalid argument: " + args[1]);
        }
    }
}