using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    class Reflecteur
    {

        public static readonly int[] Config = { 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26,
                                                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

        public int Encode (int a)
        {
            return Config[a - 1];
        }

    }
}
