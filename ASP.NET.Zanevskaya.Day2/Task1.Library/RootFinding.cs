using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Library
{
   public class RootFinding
    {
        public static double NewtonRoot(int number, int power, int guess, double e)
        {
            double x = 0;
            double xprev = 0;
            double df = 0;

            x = guess;
            while(true)
            {
                df = -(Math.Pow(x, power) - number) / (power * Math.Pow(x, power - 1));
                if(Math.Abs(x - xprev) < e) break;
                xprev = x;
                x = x + df;  
            }
            return x;
        }
    }
}
