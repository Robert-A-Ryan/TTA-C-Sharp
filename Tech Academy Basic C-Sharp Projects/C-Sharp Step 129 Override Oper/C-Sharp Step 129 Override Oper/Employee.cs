using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Step_129_Override_Oper
{
    public class Employee<T> : Person, IQuitable
    {
        public override void SayName()
        {
            Console.WriteLine("\nName: {0} {1}, ID: {2}\n", FirstName, LastName, Id);
        }

        public int Id { get; set; }
        public List<T> Things { get; set; }
        public void Quit()
        {
            Console.WriteLine("{0} {1} ended their employment.\n", FirstName, LastName);
        }


        // employee id comparison by overloading the == operator
        public static bool operator ==(Employee<T> id1, Employee<T> id2)
        {
            return true;
        }
        public static bool operator !=(Employee<T> id1, Employee<T> id2)
        {
            return false;
        }
        public override bool Equals(object o)
        {
            return true;
        }
        public override int GetHashCode()
        {
            return 0;
        }

    }
}
