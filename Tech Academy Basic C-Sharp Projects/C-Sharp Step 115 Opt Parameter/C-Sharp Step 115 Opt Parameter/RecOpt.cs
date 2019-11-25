using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Step_115_Opt_Parameter
{
    public class RecOpt
    {
        public int RAdd(int num1, int num2 = 0)
        {
            //int prod1 = 52 + num1 + num2;
            return 52 + num1 + num2;
        }
        
    }
}

