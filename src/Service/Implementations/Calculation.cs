using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementations
{
    public class Calculation: ICalculation
    {
        public int Sum(int x, int y) => x + y;
    }
}
