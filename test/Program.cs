using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int res_i= 110, res_j =119;
            for (int i = 0; i < 10; i++)
            {
                res_i = i;
                for (int j = 0; j < 2; j++)
                {
                    res_j = j;
                    continue;
                }
            }

            Console.WriteLine("i={0},j={1}", res_i, res_j);
        }
    }
}
