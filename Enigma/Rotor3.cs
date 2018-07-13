using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    class Rotor3 : Rotor
    {

        public Rotor3(int offset)
        {
            Position = offset;
            PositionInitiale = offset;
            Config = new int[] {24, 3, 13, 14, 21, 16, 26, 5, 19, 12, 22, 4,
                     11, 17, 18, 15, 25, 20, 2, 8, 1, 7, 9, 23, 6, 10 };
            Encoche = 18;
        }

    }
}
