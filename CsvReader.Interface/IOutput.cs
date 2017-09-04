using CsvReader.Model.Criteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvReader.Interface
{
    public interface IOutput
    {
        bool WriteFrequence(FrequenceOutputCriteria criteria);
        bool WriteSortByStreet(SortByStreetOutPutCriteria criteria);
    }
}
