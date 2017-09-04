using CsvReader.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvReader.Model;
using System.IO;
using CsvReader.Model.Result;
using CsvReader.Model.Criteria;

namespace CsvReader.Reader
{
    public class Reader : IReader
    {
        public List<ReaderResult> ReadCsv(ReaderCriteria criteria)
        {
            if(!File.Exists(criteria.FileLocation))
            {
                throw new Exception("CSV file does not exist in the provided directory");
            }

            try
            {
                var results = from line in File.ReadAllLines(criteria.FileLocation).Skip(1)
                              let columns = line.Split(',')
                              select new ReaderResult
                              {
                                  FirstName = columns[0],
                                  LastName = columns[1],
                                  Address = columns[2],
                                  PhoneNumber = (!string.IsNullOrEmpty(columns[3]))
                                                      ? int.Parse(columns[3])
                                                      : 0
                              };


                return results.ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
