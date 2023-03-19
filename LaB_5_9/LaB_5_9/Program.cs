using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaB_5_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            for (x=0; x<4; x+=0.25)
            {
                if (x < 1)
                {
                    y = (2 - x);
                }
                else
                {
                    y = 2 + (Math.Sqrt(2 * 2 - (x - 2) * (x - 2)));
                }
                Console.WriteLine(y);
            }
            Console.ReadLine();
        }
    }
}
