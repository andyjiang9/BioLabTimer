using BioLabTimerInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BioLabTimerServices
{
    public class SettingsService
    {
        public bool SaveFilePath(Settings settings)
        {
            if (settings == null) return false;

            var savePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            Console.WriteLine(savePath);

            string fileName = "settings.json";
            string jsonString = JsonSerializer.Serialize(settings);
            File.WriteAllText($"{savePath}\\{fileName}", jsonString);

            return true;
        }
    }
}
