using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdUTest00
{
    internal class Calculator
    {
        public int Add(int n1, int n2) { return n1 + n2; }
        public int Substract(int n1, int n2) { return n1 - n2; }
        public int Multiply(int n1, int n2) { return n1 * n2; }
        public double Divide(int n1, int n2) { return (double)n1 / n2; }
    }
}
