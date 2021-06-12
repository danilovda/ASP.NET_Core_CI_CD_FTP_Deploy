using Service.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ServiceTests
{
    public class CalculationTests
    {
        [Fact]
        public void Sum5and7_12returns()
        {
            int expected = 12;
            Calculation calculation = new Calculation();
            int actual = calculation.Sum(5, 7);

            Assert.Equal(expected, actual);
        }

    }
}
