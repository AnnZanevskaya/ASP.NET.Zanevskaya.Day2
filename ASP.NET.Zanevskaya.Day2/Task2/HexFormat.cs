using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Library;

namespace Task2
{
    class HexFormat
    {
        static void Main(string[] args)
        {
            int intValue = 61468;
            Console.WriteLine(String.Format(new CustomFormatProvider(), "{0:G}", intValue));

        }
    }
}
