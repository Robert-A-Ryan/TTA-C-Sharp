using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Step_114_More_Class_Method
{
    class SomeMath
    {
        public int MathSome (int num1)
        {
            num1 = num1 * 50;
            return num1;
        }

        public decimal MathSome(decimal num2)
        {
            num2 = num2 + 1.56m;
            return num2;
        }

        public int MathSome(string num3)
        {
            int result = Convert.ToInt32(num3) + 92;
            return result;
        }
    }
}
