using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_World
{
    class Calculator
    {
        public int Add(int left, int right)
        {
            return left + right;
        }
        public int Substract(int left, int right)
        {
            return left - right;
        }
        public int Multiply(int left, int right)
        {
            return left * right;
        }
        public int Division(int left, int right)
        {
            if (right == 0)
                return 0;
            return left / right;
        }
        public int Modulus(int left, int right)
        {
            return left % right;
        }
    }
}
