using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Finance.Data
{
    public class SettingsRepository
    {
        private readonly string _filePath = @"Save\settings.json";

        public UserSettings Load()
        {
            if (!File.Exists(_filePath))
            {
                 return new UserSettings();
            }

            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<UserSettings>(json);
        }


        public void Save(UserSettings settings)
        {
            var json = JsonSerializer.Serialize(settings);
            File.WriteAllText(_filePath, json);
        }
    }
}
