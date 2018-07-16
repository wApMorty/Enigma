﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    class Utility
    {

        public static int ToInt(Char a)
        {
            switch (a)
            {
                case 'A': return 1;
                case 'B': return 2;
                case 'C': return 3;
                case 'D': return 4;
                case 'E': return 5;
                case 'F': return 6;
                case 'G': return 7;
                case 'H': return 8;
                case 'I': return 9;
                case 'J': return 10;
                case 'K': return 11;
                case 'L': return 12;
                case 'M': return 13;
                case 'N': return 14;
                case 'O': return 15;
                case 'P': return 16;
                case 'Q': return 17;
                case 'R': return 18;
                case 'S': return 19;
                case 'T': return 20;
                case 'U': return 21;
                case 'V': return 22;
                case 'W': return 23;
                case 'X': return 24;
                case 'Y': return 25;
                case 'Z': return 26;
                default: return 0;
            }
        }

        public static char ToChar(int a)
        {
            switch (a)
            {
                case 1: return 'A';
                case 2: return 'B';
                case 3: return 'C';
                case 4: return 'D';
                case 5: return 'E';
                case 6: return 'F';
                case 7: return 'G';
                case 8: return 'H';
                case 9: return 'I';
                case 10: return 'J';
                case 11: return 'K';
                case 12: return 'L';
                case 13: return 'M';
                case 14: return 'N';
                case 15: return 'O';
                case 16: return 'P';
                case 17: return 'Q';
                case 18: return 'R';
                case 19: return 'S';
                case 20: return 'T';
                case 21: return 'U';
                case 22: return 'V';
                case 23: return 'W';
                case 24: return 'X';
                case 25: return 'Y';
                case 26: return 'Z';
                default: return '0';
            }
        }

        public static string ToString(int[] a)
        {
            char[] output = new char[a.Length];
            for (int i = 0; i<output.Length; i++)
            {
                output[i] = ToChar(a[i]);
            }
            return new string(output);
        }
    }
}
