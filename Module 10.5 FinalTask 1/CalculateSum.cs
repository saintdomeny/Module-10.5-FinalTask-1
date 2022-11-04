using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10._5_FinalTask_1
{
    public class CalculateSum : ISum
    {
        ILogger Logger { get; }

        public CalculateSum(ILogger logger)
        {
            Logger = logger;
        }

        int ISum.Sum(int one, int two)
        {
            Logger.Event("Calculating sum");//Событие синим цветом
            return one + two;
        }
    }
}
