using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_And_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Emp = new Employee();
            Emp.Burn();
            Console.WriteLine(Emp.Show());
        }
    }
    class Employee
    {
        string Name;
        int Salary;
       public void Burn()
        {
            Console.WriteLine("Enter Your Employee Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Your Employee Salary");
            Salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Name Of Employee:" + Name);
            Console.WriteLine("Salary Of Employee:" + Salary);
        }
        public String Show()
        {
            return "Welcome to Our Company";
        }
        
            
        
    }      
}
