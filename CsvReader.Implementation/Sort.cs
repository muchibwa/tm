
using CsvReader.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvReader.Model;
using CsvReader.Model.Result;
using CsvReader.Model.Criteria;

namespace CsvReader.Implementation
{
    
    public class Sort : IDisposable, ISort
    {
        private CsvReader.Reader.Reader reader;
        private List<ReaderResult> content;
        

        public Sort(string path)
        {
            
            reader = new Reader.Reader();
            content = reader.ReadCsv(
                new ReaderCriteria { FileLocation = path }
                );
        }
        ~Sort()
        {
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public List<FrequencyResult> FrequencyByFistNameLastName()
        {
            try
            {
                var frequency = content.GroupBy(name => name.FirstName)
                                .Select(group => new FrequencyResult
                                {
                                    NameSurname = group.Key,
                                    Frequency = group.Count()
                                })
                                .OrderByDescending(group => group.Frequency)
                       .Concat(content.GroupBy(lastName => lastName.LastName)
                                .Select(group => new FrequencyResult
                                {
                                    NameSurname = group.Key,
                                    Frequency = group.Count()
                                })
                                .OrderByDescending(group => group.Frequency))
                        .OrderBy(name => name.NameSurname)
                        .OrderByDescending(freq => freq.Frequency).ToList();



                return frequency;
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
        public List<SortByStreetResult> SortByStreet()
        {
            try
            {
                return content
                        .Select(w => new SortByStreetResult
                        {
                            StreetName = String.Join("", w.Address
                                                            .Where(x => !Char.IsDigit(x))
                                                            .ToArray())
                                                            .Trim(),
                            Address = w.Address
                        }).OrderBy(r => r.StreetName)
                          .ToList();

                
            }
            catch (Exception ex)
            {
                throw ex;   
            }
        }
        protected virtual void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                if (reader != null)
                {
                    reader = null;
                }

                if(content.Count() > 0)
                {
                    content = null;
                }
            }
        }
    }
}
