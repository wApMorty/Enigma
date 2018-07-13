using System;
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
            if (a == 'A')
            {
                return 1;
            }
            if (a == 'B')
            {
                return 2;
            }
            if (a == 'C')
            {
                return 3;
            }
            if (a == 'D')
            {
                return 4;
            }
            if (a == 'E')
            {
                return 5;
            }
            if (a == 'F')
            {
                return 6;
            }
            if (a == 'G')
            {
                return 7;
            }
            if (a == 'H')
            {
                return 8;
            }
            if (a == 'I')
            {
                return 9;
            }
            if (a == 'J')
            {
                return 10;
            }
            if (a == 'K')
            {
                return 11;
            }
            if (a == 'L')
            {
                return 12;
            }
            if (a == 'M')
            {
                return 13;
            }
            if (a == 'N')
            {
                return 14;
            }
            if (a == 'O')
            {
                return 15;
            }
            if (a == 'P')
            {
                return 16;
            }
            if (a == 'Q')
            {
                return 17;
            }
            if (a == 'R')
            {
                return 18;
            }
            if (a == 'S')
            {
                return 19;
            }
            if (a == 'T')
            {
                return 20;
            }
            if (a == 'U')
            {
                return 21;
            }
            if (a == 'V')
            {
                return 22;
            }
            if (a == 'W')
            {
                return 23;
            }
            if (a == 'X')
            {
                return 24;
            }
            if (a == 'Y')
            {
                return 25;
            }
            if (a == 'Z')
            {
                return 26;
            }
            return 0;
        }

        public static char ToChar(int a)
        {
            if (a == 1)
            {
                return 'A';
            }
            if (a == 2)
            {
                return 'B';
            }
            if (a == 3)
            {
                return 'C';
            }
            if (a == 4)
            {
                return 'D';
            }
            if (a == 5)
            {
                return 'E';
            }
            if (a == 6)
            {
                return 'F';
            }
            if (a == 7)
            {
                return 'G';
            }
            if (a == 8)
            {
                return 'H';
            }
            if (a == 9)
            {
                return 'I';
            }
            if (a == 10)
            {
                return 'J';
            }
            if (a == 11)
            {
                return 'K';
            }
            if (a == 12)
            {
                return 'L';
            }
            if (a == 13)
            {
                return 'M';
            }
            if (a == 14)
            {
                return 'N';
            }
            if (a == 15)
            {
                return 'O';
            }
            if (a == 16)
            {
                return 'P';
            }
            if (a == 17)
            {
                return 'Q';
            }
            if (a == 18)
            {
                return 'R';
            }
            if (a == 19)
            {
                return 'S';
            }
            if (a == 20)
            {
                return 'T';
            }
            if (a == 21)
            {
                return 'U';
            }
            if (a == 22)
            {
                return 'V';
            }
            if (a == 23)
            {
                return 'W';
            }
            if (a == 24)
            {
                return 'X';
            }
            if (a == 25)
            {
                return 'Y';
            }
            if (a == 26)
            {
                return 'Z';
            }

            return '0';
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
