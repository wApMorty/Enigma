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
        public Rotor1 r1 = new Rotor1(0);
        public Rotor2 r2 = new Rotor2(0);
        public Rotor3 r3 = new Rotor3(0);
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
