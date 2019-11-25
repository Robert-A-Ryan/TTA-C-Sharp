using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Step_117_Class_Method
{
    public class DivBy2
    {
        public DivBy2()  //Steps 1-3
        {
        }

        public void DivMath(int num1)
        {
            int quot1 = num1 / 2;
            Console.WriteLine("{0} divided by 2 = {1}", num1, quot1);
            Console.ReadLine();
        }
    }
}
