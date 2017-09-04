using CsvReader.Model;
using CsvReader.Model.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvReader.Interface
{
   public  interface ISort
    {
        List<FrequencyResult> FrequencyByFistNameLastName();
        List<SortByStreetResult> SortByStreet();
    }
}
