using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Step_106_Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> lNumbers = new List<decimal>() { 4, 6, 10, 12, 24, 62, 10005 };

            

            try
            {
                Console.WriteLine("Please choose a number.");
                decimal uNumber = Convert.ToDecimal(Console.ReadLine());

                foreach (decimal number in lNumbers)
                {
                    decimal dNumber = number / uNumber;
                    Console.WriteLine(number + " divided by your number " + uNumber + " equals " + dNumber);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Unable to divide by 0.");
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("Unable to divide by non number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
