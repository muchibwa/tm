using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvReader.Model.Result
{
    [Serializable]
    public class SortByStreetResult
    {
        public string Address { get; set; }
        public string StreetName { get; set; }
    }
}
