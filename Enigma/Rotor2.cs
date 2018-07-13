using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    class Rotor2 : Rotor
    {
        public Rotor2(int offset)
        {
            Position = offset;
            PositionInitiale = offset;
            Config = new int[] { 3, 12, 4, 26, 15, 19, 14, 22, 16, 8, 5, 9, 23, 10, 17, 18, 2, 6, 1, 7, 21, 11, 20, 24, 25, 13 };
            Encoche = 15;
        }

    }
}
