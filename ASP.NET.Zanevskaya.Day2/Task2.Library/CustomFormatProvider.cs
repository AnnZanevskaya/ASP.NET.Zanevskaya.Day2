using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Task2.Library
{
    public class CustomFormatProvider : IFormatProvider, ICustomFormatter
    {
        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
                return this;
            else
                return null;
        }

        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            int baseNumber;
            byte[] bytes;
            if (!this.Equals(formatProvider))
                return null;

            if (format.ToUpper() != "H")
            {
                try
                {
                    throw new FormatException();
                }
                catch (FormatException)
                {
                    return String.Format("The format of '{0}' is invalid.", format);
                }
            }
            if (!(arg is int))
            {
                try
                {
                    throw new FormatException();
                }
                catch (FormatException)
                {
                    return String.Format("The format of '{0}' is invalid.", arg);
                }
            }
    
            baseNumber = 16;
            bytes = BitConverter.GetBytes((int)arg);             
            string numericString = String.Empty;
            int numberToConvert = 0;
            for (int ctr = 0; ctr < bytes.Length; ctr++)
            {
                int temp = 0; 
                numberToConvert = bytes[ctr];
                while (numberToConvert != 0)
                {
                    temp++;
                    int res = 0;
                    int numbHex = 0;
                    res = numberToConvert / baseNumber;
                    numbHex = numberToConvert - baseNumber * res;
                    if (numbHex >= 10)
                    {
                        string[] hexLetters = { "a", "b", "c", "d", "e", "f" };
                        int i = -10 + numbHex;
                        numericString =hexLetters[i] + numericString;
                    }
                    else numericString =  numbHex + numericString;
                    numberToConvert = numberToConvert / baseNumber;
                }
                if (temp == 1) numericString = "0" + numericString;
            }
            if (numericString == String.Empty)  numericString = "0";
            return numericString;
        }
    }
}
