using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    class Calculator
    {
        private int _p1;
        private int _p2;

        public Calculator(int p1, int p2)
        {
           
            _p1 = p1;
            _p2 = p2;
        }
        internal int Add(int p1, int p2)
        {
            return p1 + p2;
        }

        internal int Substract(int p1, int p2)
        {
            return p1 - p2;
        }
    }
}
