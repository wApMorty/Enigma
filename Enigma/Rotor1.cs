using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    class Rotor1 : Rotor
    {

        public Rotor1(int offset)
        {
            Position = offset;
            PositionInitiale = offset;
            Config = new int[] { 7, 17, 23, 8, 19, 21, 4, 13, 3, 5, 18, 26, 10, 1, 20, 6, 16, 15, 2, 9, 14, 22, 12, 11, 24, 25 };
            Encoche = 3;
        }
    }
}
