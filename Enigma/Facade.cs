using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    class Facade
    {

        private static readonly string[] Paires = {"AH", "JF", "UC", "LG" };
        private static int[,] IntPaires;
        
        public Facade()
        {
            IntPaires = new int[Paires.Length, 2];
            for (int i = 0; i<Paires.Length; i++)
            {
                IntPaires[i,0] = Utility.ToInt(Paires[i][0]);
                IntPaires[i,1] = Utility.ToInt(Paires[i][1]);
            }
        }

        public int[] Encode (int[] input)
        {
            int[] output = new int[input.Length];
            for (int i = 0; i<output.Length; i++)
            {
                bool converti = false;
                for (int k = 0; k<IntPaires.Length/2; k++)
                {
                    if (input[i] == IntPaires[k,0])
                    {
                        output[i] = IntPaires[k,1];
                        converti = true;
                    }
                    if (input[i] == IntPaires[k,1])
                    {
                        output[i] = IntPaires[k,0];
                        converti = true;
                    }
                }
                if (!converti)
                {
                    output[i] = input[i];
                }
            }
            return output;
        }

        public int[] Encode (string input)
        {
            int[] mediumOutput = new int[input.Length];
            for (int i = 0; i<mediumOutput.Length; i++)
            {
                mediumOutput[i] = Utility.ToInt(input[i]);
            }
            return Encode(mediumOutput);
        }

    }
}
