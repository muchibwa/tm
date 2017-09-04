using CsvReader.Interface;
using CsvReader.Model.Criteria;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CsvReader.Write.Output
{
    public class Output : IDisposable, IOutput
    {
        ~Output()
        {
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
               
            }
        }
        public bool WriteFrequence(FrequenceOutputCriteria criteria)
        {
            try
            {
                var outputpath = string.Format("{0}\\{1}\\"
                                , criteria.Path
                                , DateTime.Now.ToString("ddMMyyyy")
                                );

                if (!Directory.Exists(outputpath))
                {
                    Directory.CreateDirectory(outputpath);
                }

                var outputFullPath = string.Format("{0}{1}.csv", outputpath, DateTime.Now.ToString("HH mm ss"));
                using (StreamWriter outputFile = new StreamWriter(outputFullPath, true))
                {
                    criteria.Content.ForEach(x =>
                    {
                        outputFile.WriteLine(string.Format("{0},{1}", x.NameSurname, x.Frequency));
                    });

                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool WriteSortByStreet(SortByStreetOutPutCriteria criteria)
        {
            try
            {
                var outputpath = string.Format("{0}\\{1}\\"
                                , criteria.Path
                                , DateTime.Now.ToString("ddMMyyyy")
                                );

                if (!Directory.Exists(outputpath))
                {
                    Directory.CreateDirectory(outputpath);
                }

                var outputFullPath = string.Format("{0}{1}.csv", outputpath, DateTime.Now.ToString("HH mm ss"));
                using (StreamWriter outputFile = new StreamWriter(outputFullPath, true))
                {
                    criteria.Content.ForEach(x =>
                    {
                        outputFile.WriteLine(string.Format("{0}", x.Address));
                    });

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
