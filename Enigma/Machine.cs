using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    class Machine
    {

        public Facade f = new Facade();
        public Rotor r1 = new Rotor {
            Position = 0,
            PositionInitiale = 0,
            Config = new int[] { 7, 17, 23, 8, 19, 21, 4, 13, 3, 5, 18, 26, 10, 1, 20, 6, 16, 15, 2, 9, 14, 22, 12, 11, 24, 25 },
            Encoche = 3
        };
        public Rotor r2 = new Rotor
        {
            Position = 0,
            PositionInitiale = 0,
            Config = new int[] { 3, 12, 4, 26, 15, 19, 14, 22, 16, 8, 5, 9, 23, 10, 17, 18, 2, 6, 1, 7, 21, 11, 20, 24, 25, 13 },
            Encoche = 15
        };
        public Rotor r3 = new Rotor
        {
            Position = 0,
            PositionInitiale = 0,
            Config = new int[] {24, 3, 13, 14, 21, 16, 26, 5, 19, 12, 22, 4,
                     11, 17, 18, 15, 25, 20, 2, 8, 1, 7, 9, 23, 6, 10 },
            Encoche = 18,
        };
        public Reflecteur r = new Reflecteur();

        public string Encode(string input)
        {
            int[] output = new int[input.Length];
            output = f.Encode(input);
            for (int i = 0; i<output.Length; i++)
            {
                r1.Tourner();
                if (r1.Position == r1.Encoche)
                {
                    r2.Tourner();
                    if (r2.Position == r2.Encoche)
                    {
                        r3.Tourner();
                    }
                }
                output[i] = r1.Encode(output[i]);
                output[i] = r2.Encode(output[i]);
                output[i] = r3.Encode(output[i]);
                output[i] = r.Encode(output[i]);
                output[i] = r3.ReverseEncode(output[i]);
                output[i] = r2.ReverseEncode(output[i]);
                output[i] = r1.ReverseEncode(output[i]);
            }
            output = f.Encode(output);
            return Utility.ToString(output);
        }

    }
}
