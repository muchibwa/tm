
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvReader.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("---------------------- Hello -------------------" + Environment.NewLine);
            System.Console.WriteLine("---------------------- We are collecting all the required information -------------------" + Environment.NewLine);
            System.Console.WriteLine("---------------------- Please wait-------------------" + Environment.NewLine);

            CsvReader.Run.Run run = new Run.Run();
            var result = run.All();
            if (result == true)
            {
                System.Console.WriteLine("---------------------- Process completed -------------------" + Environment.NewLine);
                System.Console.WriteLine("---------------------- Output requirement are written in the output folder under the bin directory -------------------" + Environment.NewLine);
            }

            System.Console.WriteLine("---------------------- Bye Bye -------------------" + Environment.NewLine);
            System.Console.ReadKey();

        }
    }
}
