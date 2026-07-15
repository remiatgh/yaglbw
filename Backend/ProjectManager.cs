using System;
using System.IO;
using System.Threading.Tasks;

namespace Backend;

public class ProjectManager
{
    public async Task ListProjects()
    {
        ConfigManager configManager = new();
        var config = configManager.GetConfig();
        Console.WriteLine(config.GodotProjectCFGPath);
        // Gets the user's YAGLBW data folder
        
    }
}