using System;
using System.Collections;
using System.IO;
using System.Text.Json;

namespace Backend;

public class ProjectsManager
{
    string projectsSavedPath = BackendConsts.YaglbwDataFolderPath + "/projects.json";
    public Project[] GetProjects()
    {
        if (File.Exists(projectsSavedPath))
        {
            string projectsSavedJson = File.ReadAllText(projectsSavedPath);
            List<Project> projectsList = JsonSerializer.Deserialize<List<Project>>(projectsSavedJson);
            Project[] projects = new Project[projectsList.Count];
            
            for (int index = 0; index < projectsList.Count; index++)
            {
                //Console.WriteLine(projectsList[index]);
                projects[index] = projectsList[index];
            }
            return projects;
        }
        else
        {
            Project[] a = Array.Empty<Project>();
            return a;
        }
    }


}

public class Project
{
    public DictionaryBase[] Omg = [];
    public string Name {get; set;} = "";
    public string Path {get; set;} = "";
    public string GodotVersion {get; set;} = "";
}