using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    public class Rotor
    {
        public int Position { get; set; }
        public int PositionInitiale { get; set; }
        public int[] Config { get; set; }
        public int Encoche { get; set; }

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
            while (resultat <= 0)
            {
                resultat += 26;
            }
            return resultat;
        }

    }
}
