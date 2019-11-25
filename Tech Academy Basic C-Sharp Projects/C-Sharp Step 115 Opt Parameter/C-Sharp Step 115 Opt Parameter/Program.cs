using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Step_115_Opt_Parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            RecOpt ro = new RecOpt();

            try
            {
                int prod1;
                int num2;
                Console.WriteLine("Pick a number.");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick an optional number, leave blank if wanted.");
                string sNum2 = (Console.ReadLine());
                
                if (sNum2 != "")
                {
                    num2 = Convert.ToInt32(sNum2);
                }
                else
                {
                    num2 = 0;
                }


                prod1 = ro.RAdd(num1, num2);
                Console.WriteLine("52 + {0} + {1} = " + prod1, num1, num2);
                Console.ReadLine();
            }
            catch (UriFormatException)
            {
                Console.WriteLine("Please type a number.");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
