using CsvReader.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvReader.Run
{
    public class Run : IRun
    {
        private CsvReader.Config.Reader config;
        public Run()
        {
            config = new Config.Reader();
        }

        public bool All()
        {
            try
            {
                using (CsvReader.Implementation.Sort sort = new Implementation.Sort(config.Read.FilePath))
                {
                    using (CsvReader.Write.Output.Output output = new Write.Output.Output())
                    {
                        output.WriteFrequence(new Model.Criteria.FrequenceOutputCriteria
                        {
                            Content = sort.FrequencyByFistNameLastName(),
                            Path = config.Read.FrequencyOutput,
                            source = "FrequencyOutput"
                        });

                        output.WriteSortByStreet(new Model.Criteria.SortByStreetOutPutCriteria
                        {
                            Content = sort.SortByStreet(),
                            Path = config.Read.StreetNameOutput,
                            source = "StreetNameOutput"
                        });

                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
