using CsvReader.Model.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvReader.Model.Criteria
{
    public class SortByStreetOutPutCriteria
    {
        public string Path { get; set; }
        public List<SortByStreetResult> Content { get; set; }
        public string source { get; set; }
    }
}
