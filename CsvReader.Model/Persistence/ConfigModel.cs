using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvReader.Model.Persistence
{
    public class ConfigModel
    {
        public string FilePath { get; set; }
        public string FrequencyOutput { get; set; }
        public string StreetNameOutput { get; set; }
    }
}
