using CsvReader.Model;
using CsvReader.Model.Criteria;
using CsvReader.Model.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvReader.Interface
{
    public interface IReader
    {
        List<ReaderResult> ReadCsv(ReaderCriteria criteria);

    }
}
