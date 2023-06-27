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

    public enum Dept { HR,Admin,Sales,Development,Testing};//Enum
    public enum Designation { Admin,Employee,Manager};
    public enum Task { New,Open,Closed,Reopen,Test,Bugs};
    public class Employee
    {
        private int employeeId, employeeBasicSalary;
        private string employeeName;
        private double hra, ta, pf,grossSalary;
        private Dept dept;

        public Employee(int employeeId,string employeeName,int employeeBasicSalary,Dept dept)
        {
            this.employeeId = employeeId;
            this.employeeName = employeeName;
            this.employeeBasicSalary = employeeBasicSalary;
            this.dept = dept;
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
            return $"Employee Id:{employeeId}\nEmployee Name:{employeeName}\ngrossSalary:{grossSalary}\nDept:{dept}";
        }

        public static void Main(string[] args)
        {
            Employee employee = new Employee(245, "Sangeeta", 55000,Dept.HR);
            employee.CalculateSalary();
            Console.WriteLine(employee.ToString());

            Employee employee1 = new Employee(651,"Dinesh",69800,Dept.Development);
            employee1.CalculateSalary();
            Console.WriteLine(employee1.ToString());
        }
    }
}
