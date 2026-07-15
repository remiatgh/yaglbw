using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.Json;
using System.Collections;

namespace Backend;

public class ConfigManager
{
    string userDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),"YAGLBW");
    public YaglbwConfig GetConfig(string configName)
    {
        string json = File.ReadAllText(userDataPath + "/config.json");

        Console.WriteLine(userDataPath);
        YaglbwConfig YaglbwConfig = new();
        return YaglbwConfig;
    }
}

public class YaglbwConfig
{
    public string GodotProjectCFGPath {get;set;} = "";
}