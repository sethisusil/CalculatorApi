using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApiCommon.Clients
{
    public interface ICalculator
    {
        Task<string> Calculate(string expr);
    }
}
