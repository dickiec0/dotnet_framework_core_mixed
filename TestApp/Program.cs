using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLib;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = 1;
            int two = 2;

            int res = Addition.add(one, two);
            Console.Write(res);
        }
    }
}
