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
            int start = 11, end = 111, count = 0, num, place, currNum;
            for (num = (start < end ? start : end); num <= (start > end ? start : end); num++)
            {
                //Console.WriteLine("i={0}", i);
                for (place = 10, currNum = num; currNum != 0; currNum /= 10, place *= 10)
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
