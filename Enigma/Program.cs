using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                Machine m1 = new Machine();
                Console.WriteLine(m1.Encode(input));
            }

        }
    }
}
