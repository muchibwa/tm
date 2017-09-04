using CsvReader.Model.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvReader.Config
{
    public class Reader
    {
        public ConfigModel Read { get; set; }
        public Reader()
        {
            Read = new ConfigModel
            {
                FilePath = read<string>("CsvFile", ""),
                FrequencyOutput = read<string>("FrequencyOutput", ""),
                StreetNameOutput = read<string>("StreetNameOutput", "")
            };
        }

        private T read<T>(string key, T defaultValue)
        {
            try
            {
                var keyvalue = System.Configuration.ConfigurationManager.AppSettings[key];
                return (T)Convert.ChangeType(keyvalue, typeof(T));
            }
            catch
            {
                return defaultValue;
            }
        }
    }
}
