using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA_University_project_Vysochina
{
    static public class Ferma
    {
        static public long number;

        static public bool Check(long number)
        {
            int count = 10; //количесвто проверок -тогда вероятность что проверяемое число простое  = 1 - (0.5)^10
            
            bool flag = true;
            long a, p, x;
            p = number - 1;
            RandomGenerator.GenerateSeedFromTimestamp();
            do
            {
                a = RandomGenerator.GenerateNext(0,p)+1;
                x = ModPow.Get(a, p, number);

                if (x != 1)
                {
                    flag = false; //если хотя бы для одного а, х != 1, то число не простое
                }
                count--;

            } while ((count == 0) && (!flag));

            return flag;
        }
    }
}
