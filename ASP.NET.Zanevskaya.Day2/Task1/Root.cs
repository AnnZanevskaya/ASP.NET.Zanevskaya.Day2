using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Library;

namespace Task1
{
    class Root
    {
        static void Main()
        {
            double root;
            int number; 
            int power;
            int guess;
            const double e = 1e-8;

            number = 278;
            power = 4;
            guess = 10;
            root = RootFinding.NewtonRoot(number, power, guess, e);

            Console.WriteLine("Newton Root {0}, System Root {1}", root, Math.Pow(number, 1.0 / power));
        }
    }
}
