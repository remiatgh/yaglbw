using System;
using System.IO;
using System.Threading.Tasks;

namespace Backend;

public class ConfigManager
{
    string userDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),"YAGLBW");
    public YagblwConfig GetConfig()
    {
        YagblwConfig yagblwConfig = new();
        return yagblwConfig;
    }
}

public class YagblwConfig
{
    public string GodotProjectCFGPath {get;set;} = "";
}