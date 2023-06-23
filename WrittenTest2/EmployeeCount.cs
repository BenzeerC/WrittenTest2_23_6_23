using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrittenTest2
{
    //Use above Employee class,
    //create a static field to auto increment the employee id & create static method to display the total object count.
    public class EmployeeCount
    {
        private int employeeId, employeeBasicSalary;
        private string employeeName;
        private double hra, ta, pf, grossSalary;
        public static int count = 0;

        public EmployeeCount( string employeeName, int employeeBasicSalary)
        {
            count++;
            employeeId = count;
            this.employeeName = employeeName;
            this.employeeBasicSalary = employeeBasicSalary;
        }

        public void CalculateSalary()
        {
            hra = employeeBasicSalary * 0.40;
            ta = employeeBasicSalary * 0.20;
            pf = employeeBasicSalary * 0.12;
            grossSalary = (employeeBasicSalary + hra + ta) - pf;
            //return  grossSalary;
        }
        public static int GetCount()
        {
            return count;
        }

        public override string ToString()
        {
            return $"\nEmployee Id:{employeeId}\nEmployee Name:{employeeName}\ngrossSalary:{grossSalary}";
        }

        public static void Main(string[] args)
        {
            EmployeeCount employee = new EmployeeCount( "Sangeeta", 55000);
            //new EmployeeCount( "Rahul", 65300);


            employee.CalculateSalary();
            Console.WriteLine(employee);
            //Console.ReadLine();

            EmployeeCount employeeCount = new EmployeeCount("Rahul", 78930);
            employeeCount.CalculateSalary();
            Console.WriteLine(employeeCount);
                //Console.WriteLine(employee.ToString());
        }
    }

}

