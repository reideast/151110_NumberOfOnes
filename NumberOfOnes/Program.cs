using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfOnes
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 11, end = 111, count = 0, i, place, currNum;
            for (i = (start < end ? start : end); i <= (start > end ? start : end); i++)
            {
                //Console.WriteLine("i={0}", i);
                currNum = i;
                for (place = 10; currNum != 0; currNum /= 10, place *= 10)
                {
                    //Console.WriteLine("Place={0}, currNum%10={1}", place, currNum % 10);
                    if (currNum % 10 == 1)
                        count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
