using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sendToThings3
{
    class Storage
    {

        private static Dictionary<string,string> _settingsDictionary = new Dictionary<string, string>();

        private static bool _settingsLoaded = false;


        public static void SetSetting(string key, string value)
        {
            if (!_settingsLoaded)
            {
                LoadSettings();
            }

            if (!HasSetting(key))
            {
                _settingsDictionary.Add(key,value);
                SaveSettings();
                return;
            }

            _settingsDictionary[key] = value;
            SaveSettings();
        }


        public static string GetSetting(string key, string fallback = null)
        {
            if (!_settingsLoaded)
            {
                LoadSettings();
            }

            if (_settingsDictionary.TryGetValue(key, out var value))
            {
                return value;
            }

            return fallback;
        }



        private static void LoadSettings()
        {

            if (!File.Exists(GetAppPath() + "settings"))
            {
                _settingsLoaded = true;
                return;
            }

            try
            {
                _settingsDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(
                    File.ReadAllText(GetAppPath())
                );
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private static void SaveSettings()
        {
            if (!Directory.Exists(GetAppPath()))
            {
                Directory.CreateDirectory(GetAppPath());
            }

            try
            {
                File.WriteAllText(GetAppPath() + "settings", JsonConvert.SerializeObject(_settingsDictionary));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("Could not save settings");
            }

        }

        public static bool HasSetting(string key)
        {
            if (!_settingsLoaded)
            {
                LoadSettings();
            }

            return _settingsDictionary.ContainsKey(key);
        }

        public static string GetAppPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\sendToThings3\\"; ;
        }
    }
}
