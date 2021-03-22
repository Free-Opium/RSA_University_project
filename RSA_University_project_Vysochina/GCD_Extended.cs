using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA_University_project_Vysochina
{
    class GCD_Extended
    {

        static public int Gcd(int a, int b, out int x, out int y)
        {

            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }

            int gcd = Gcd(b % a, a, out x, out y);

            int newY = x;
            int newX = y - (b / a) * x;

            x = newX;
            y = newY;
            return gcd;
        }

    }
}
