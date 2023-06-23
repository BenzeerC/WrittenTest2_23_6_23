using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrittenTest2
{
    //Create class Employee. Add fields like id, name, basic salary, HRA, TA, PF. Accept the value of id, name & basic salary from constructor.
    //Calculate the employee gross salary  & display employee details using ToString() method
    //HRA- 40% of basic salary
    // TA – 20% of basic salary
    //PF -12 % of basic salary
    public class Employee
    {
        private int employeeId, employeeBasicSalary;
        private string employeeName;
        private double hra, ta, pf,grossSalary;

        public Employee(int employeeId,string employeeName,int employeeBasicSalary)
        {
            this.employeeId = employeeId;
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

        public override string ToString()
        {
            return $"Employee Id:{employeeId}\nEmployee Name:{employeeName}\ngrossSalary:{grossSalary}";
        }

        public static void Main(string[] args)
        {
            Employee employee = new Employee(245, "Sangeeta", 55000);
            employee.CalculateSalary();
            Console.WriteLine(employee.ToString());
        }
    }
}
