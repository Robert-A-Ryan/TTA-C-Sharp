using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Step_140_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //create list of employees
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee("Joe", "Smith", 1));
            employees.Add(new Employee("Mary", "Nam", 2));
            employees.Add(new Employee("Sarah", "Connor", 3));
            employees.Add(new Employee("Evan", "Smith", 4));
            employees.Add(new Employee("Joe", "Gorilla", 5));
            employees.Add(new Employee("Barry", "Jones", 6));
            employees.Add(new Employee("John", "Ryan", 7));
            employees.Add(new Employee("Art", "Carbuncle", 8));
            employees.Add(new Employee("Mark", "Brooks", 9));
            employees.Add(new Employee("Garth", "Shelton", 10));


            //Using foeach loop to create a new list "JoeEmp" for each "Joe" in "employees"
            List<Employee> JoeEmp = new List<Employee>();

            foreach (var data in employees)
            {
                if (data.FirstName == "Joe")
                {
                    JoeEmp.Add(data);
                }
            }

            foreach (Employee emp in JoeEmp)
            {
                Console.WriteLine("{0} {1} #{2}", emp.FirstName, emp.LastName, emp.Id);
            }



            //Using lambda function to create a new list "JoeEmp" for each "Joe" in "employees"
            List<Employee> JoeLEmp = employees.Where(j => j.FirstName == "Joe").ToList();

            foreach (Employee empL in JoeLEmp)
            {
                Console.WriteLine("{0} {1} #{2}", empL.FirstName, empL.LastName, empL.Id);
            }


            //Using lambda function to create a new list "G5Emp" for each employee with Id greater than 5 in "employees"
            List<Employee> G5Emp = employees.Where(i => i.Id > 5).ToList();

            foreach (Employee emp5 in G5Emp)
            {
                Console.WriteLine("{0} {1} #{2}", emp5.FirstName, emp5.LastName, emp5.Id);
            }



            Console.ReadLine();
        }
    }
    public class Employee
    {
        public Employee data;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        public Employee(string FirstName, string LastName, int Id)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Id = Id;
        }

        //public Employee(Employee data)
        //{
        //    this.data = data;
        //}
    }
}
