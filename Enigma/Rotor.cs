using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    public abstract class Rotor
    {
        public int Position;
        public int PositionInitiale;
        public int[] Config;
        public int Encoche;

        public void Tourner()
        {
            Position = (Position+1)%26;
        }

        public int Encode(int input)
        {
            return Config[(input - 1 + Position)%26];
        }

        public int ReverseEncode(int input)
        {
            int resultat = (Array.IndexOf(Config, input) + 1 - Position) % 26;
            while (resultat < 0)
            {
                resultat += 26;
            }
            return resultat;
        }

    }
}
