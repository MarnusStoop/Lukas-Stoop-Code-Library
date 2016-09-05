using System;
using LSGCL.DataHandlers;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSGCL.Misc
{
    /// <summary>
    /// A static class to parse and create .ini files
    /// </summary>
    public static class iniFileHandler
    {

        public static Dictionary<string, string> ParseFile(string filePath = "settings.ini", char delimiter = ':')
        {

            if(!Util.CheckIfPathIsValid(filePath, "ini"))
            {
                return null;
            }

            List<string> lines = FileHandler.Read(filePath);

            Dictionary<string, string> settings = new Dictionary<string, string>();

            foreach(string line in lines)
            {
                if(line.Contains(delimiter))
                {
                    //Format is name:value
                    string[] contents = line.Split(delimiter);
                    string settingName = contents[0];
                    string settingValue = contents[1];

                    settings.Add(settingName, settingValue);
                }
            }

            return settings;
        }

        public static bool WriteFile(Dictionary<string, string> settings, char delimiter = ':', string filePath = "settings.ini")
        {
            if(settings == null)
            {
                return false;
            }

            if(!Util.CheckIfPathIsValid(filePath, "ini"))
            {
                return false;
            }

            List<string> formattedSettings = new List<string>();

            foreach(var setting in settings)
            {
                string formattedSetting = FormatSetting(setting.Key, setting.Value, delimiter);
                formattedSettings.Add(formattedSetting);
            }

            FileHandler.Write(formattedSettings, filePath);

            return true;
        }

        private static string FormatSetting(string settingName, string settingValue, char delimiter = ':')
        {
            return string.Format("{0}{1}{2}", settingName, delimiter, settingValue);
        }

    }
}