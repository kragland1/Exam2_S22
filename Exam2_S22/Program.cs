
//Grading ID: R2226
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2_S22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] years = { 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020 };

            double[] inflationRates = { .0164, .0316, .0207, .0146, .0162, .0012, .0126, .0213, .0244, .0181, .0123 };

            double[] annualChanges = { .02, .0152, -.0109, -.0060, .0016, -.0150, .0144, .0087, .0031, -.0063, -.0058 };

            int year;
            bool valid = false;
            double inflation = 0;
            double annual = 0;
            System.Console.Write("Enter year: ");
            year = int.Parse(System.Console.ReadLine());
            for (int x = 0; x < years.Length && !valid; ++x)
            {
                if(year == years[x])
                {
                    valid = true;
                    inflation = inflationRates[x];
                    annual = annualChanges[x];
                }
            }
            if(valid)
            {
                System.Console.WriteLine($"In the year {year} the inflation rate was {inflation:P2} with an annual change of {annual:P2} from the previous year");
            }
            else
            {
                System.Console.WriteLine("Sorry no data for {0}", year);
            }


        }
    }
}
