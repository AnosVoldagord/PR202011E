using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anos_2
{
    class Program
    {
        
    }
    class Employee
    {
        int Id;
        string Name;
        int Age;
        double Salary;
        
        Employee(int id,string name,int age,double sal)
        {
            Console.WriteLine("Constructor For Employee Called");
            Id = id;
            Name = name;
            Age = age;
            Salary = sal;
        }
        ~Employee()
        {
            Console.WriteLine("Destructor For Employee Called");
        }

        static void Main(string[] args)
        {
            Employee objEmp = new Employee(1, "Anos", 45, 3500);
            Console.WriteLine("Employee Id " + objEmp.Id);
            Console.WriteLine("Employee Name "+objEmp.Name);
            Console.WriteLine("Employee Age "+objEmp.Age);
            Console.WriteLine("Employee Salary "+objEmp.Salary);
        }
    }
}
