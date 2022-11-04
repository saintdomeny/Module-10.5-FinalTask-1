using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10._5_FinalTask_1
{
    public class CalculateSum : ISum
    {
        int ISum.Sum(int one, int two)
        {
            return one + two;
        }
    }
}
