using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvReader.Model.Result
{
    [Serializable]
    public class FrequencyResult
    {
        public string NameSurname { get; set; }
        public int Frequency { get; set; }
    }
}
