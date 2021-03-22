using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA_University_project_Vysochina
{
     static public class ModPow
    {
        static public long Get(long number, long pow, long mod)
        {
            long result = 1;
            long bit =number % mod;

            while (pow > 0)
            {
                if ((pow & 1) == 1)
                {
                    result *= bit;
                    result %= mod;
                }
                bit *= bit;
                bit %= mod;
                pow >>= 1;
            }
            return result;
        }

        
    }
}
