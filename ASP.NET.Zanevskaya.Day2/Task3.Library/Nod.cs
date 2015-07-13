using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;


namespace Task3.Library
{
    public class Nod
    {
        public static int NodEvklid(int firstN, int secondN)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            if (firstN == 0 || secondN == 0) return 0;
            if (firstN < 0 || secondN < 0)
            {
                firstN = Math.Abs(firstN);
                secondN = Math.Abs(secondN);
            }
            while (firstN != secondN)
            {
                if (firstN > secondN)
                {
                    firstN = firstN - secondN;
                }
                else
                {
                    secondN = secondN - firstN;
                }
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine(" time {0}",ts.ToString());
            return firstN;
        }

        public static int NodEvklid(int firstN, int secondN, int thirdN)
        {
            int nodOfTwo = NodEvklid(firstN, secondN);
            return NodEvklid(nodOfTwo, thirdN);
        }

        public static int NodEvklid(int firstN, int secondN, int thirdN, params int[] arr)
        {
            int nod = NodEvklid(firstN, secondN, thirdN);
            for (int i = 0; i < arr.Length; i++)
            {
               nod = NodEvklid(nod, arr[i]);
            }
            return nod;
        }


        public static int BinaryNod(int firstN, int secondN)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            if (firstN == 0 || secondN == 0) return 0;
            if (firstN < 0 || secondN < 0)
            {
                firstN = Math.Abs(firstN);
                secondN = Math.Abs(secondN);
            }
            if (firstN == secondN)
            {
                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;
                Console.WriteLine(" time {0}", ts.ToString());
                return firstN;
            }
                
                if (firstN == 0)
                {
                    stopWatch.Stop();
                    TimeSpan ts = stopWatch.Elapsed;
                    Console.WriteLine(" time {0}", ts.ToString());
                    return secondN;
                }
                
            if (secondN == 0)
            {
                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;
                Console.WriteLine(" time {0}", ts.ToString());
                return firstN;
            }
                
            if ((~firstN & 1) != 0)
            {
                if ((secondN & 1) != 0) return BinaryNod(firstN >> 1, secondN);
                else return BinaryNod(firstN >> 1, secondN >> 1) << 1;
            }
            if ((~secondN & 1) != 0) return BinaryNod(firstN, secondN >> 1);
            if (firstN > secondN) return BinaryNod((firstN - secondN) >> 1, secondN);
            return BinaryNod((secondN - firstN) >> 1, firstN);
        }

        public static int BinaryNod(int firstN, int secondN, int thirdN)
        {
            int nodOfTwo = BinaryNod(firstN, secondN);
            return BinaryNod(nodOfTwo, thirdN);
        }

        public static int BinaryNod(int firstN, int secondN, int thirdN, params int[] arr)
        {
            int nod = BinaryNod(firstN, secondN, thirdN);
            for (int i = 0; i < arr.Length; i++)
            {
                nod = BinaryNod(nod, arr[i]);
            }
            return nod;
        }
    }
}
