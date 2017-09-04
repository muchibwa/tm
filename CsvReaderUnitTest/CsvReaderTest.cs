using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsvReader.Implementation;
using CsvReader.Reader;

namespace CsvReaderUnitTest
{
    [TestClass]
    public class CsvReaderTest
    {
        [TestMethod]
        public void FileReader()
        {
            var filepath = "data.csv";
            Reader reader = new Reader();
            reader.ReadCsv(new CsvReader.Model.Criteria.ReaderCriteria { FileLocation = filepath });
        }

        [TestMethod]
        public void FrequentSort()
        {
            var filepath = "data.csv";
            Sort sort = new Sort(filepath);
        }

        [TestMethod]
        public void StreetSort()
        {
            var filepath = "data.csv";
            Sort sort = new Sort(filepath);
        }
    }
}
