using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Study
{
    public class Aula03
    {
        public int Sum(int maxInt, int n)
        {
            int result = 0;
            int i = 0;

            if (n < 0)
                n = -n;

            while ((i < n) && (result <= maxInt))
            {
                i += 1;
                result += i;
            }

            if (result <= maxInt)
                return result;
            else
                throw new Exception("tool large");
        }
    }
}
