using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Step_129_Override_Oper
{
    public class Employee : Person, IQuitable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}, ID: {2}\n", firstName, lastName, Id);
        }

        public int Id { get; set; }
        public void Quit()
        {
            Console.WriteLine("{0} {1} ended their employment.\n", firstName, lastName);
        }

        // employee id comparison by overloading the == operator
        public static bool operator ==(Employee id1, Employee id2)
        {
            return true;
        }
        public static bool operator !=(Employee id1, Employee id2)
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
