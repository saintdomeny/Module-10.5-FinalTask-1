using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10._5_FinalTask_1
{
    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }
}
