using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Step_111_Create_Class
{
    public class AddSubtractMultiply
    {
        public int num1;
        public int Add(int num1)
        {
            return num1 + 150;
            //Console.WriteLine("150 added to your number = " + num1);
            //return num1;
        }

        public int Subtract(int num1)
        {
            return num1 - 24;
        }

        public int Multiply(int num1)
        {
            return num1 * 55;
        }
    }
}
