using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA_University_project_Vysochina
{
    public class GCD
    {
        static public long Get (long a, long b)
        {
            if (a == 0 || b == 0) return 0;
            if (a == 1 || b == 1) return 1;
            while (b != 0)
            {
                var r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
    }
}
