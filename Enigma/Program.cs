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

            Machine m1 = new Machine();
            Machine m2 = new Machine();
            Machine m3 = new Machine();
            Machine m4 = new Machine();
            Console.WriteLine(m1.Encode("WBYHFHLBLLYCZIRSJERGUNM"));
            Console.WriteLine(m2.Encode("NBYTRTQASOYPE"));
            Console.WriteLine(m3.Encode("OZUPEFQURMUZOYTMANGVPLYD"));
            Console.WriteLine(m4.Encode("XSWEYPXVOQPCYHTNGNJ"));

        }
    }
}
