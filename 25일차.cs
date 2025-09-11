using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250806
{
    class Program
    {
        static void Main()
        {
            int x = 10;
            int y = 20;
            Swap(ref x, ref y);

            Console.WriteLine(x);
            Console.WriteLine(y);
        }
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
