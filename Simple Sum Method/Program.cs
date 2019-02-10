using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Sum_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            int z = Sum(x, y);
            Console.WriteLine(z);
            Console.Read();
        }
          static int Sum(int x, int y)
            {
                return x + y;
            }
    }
}
