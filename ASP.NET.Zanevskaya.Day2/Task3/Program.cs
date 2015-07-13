using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Library;
using System.Diagnostics;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
           // int firstN = 1071;
            int firstN = 1071;
            int secondN = 81;
            int thirdN = 9;
            int fourth = 3;
            int more = 0;
            int expected = 0;

            int nod = Nod.NodEvklid(firstN, secondN);
            int binaryNod = Nod.BinaryNod(firstN, secondN);
            Console.WriteLine("first number {0}, second number {1}, third {2},  nod {3} ", firstN, secondN,thirdN, nod);
            Console.WriteLine("first number {0}, second number {1},  Nod {2}, {3}, {4}", firstN, secondN,thirdN,more, binaryNod);
        }
    }
}
