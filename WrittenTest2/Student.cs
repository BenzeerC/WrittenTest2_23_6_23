using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrittenTest2
{
    //Create class Student, with roll no , name , percentage auto implemented properties.
    //Use property initialize syntax to assign the values. Print the student details
    public class Student
    {
        public int studentId { get; set; }
        public string studentname { get; set; }
        public float percentage { get; set; }

        public int total { get; set; }

        public Student(int studentId, string studentname,int total)
        {
            this.studentId = studentId;
            this.studentname = studentname;
            this.percentage = percentage;
            this.total = total;
        }
        public void GetPercentage() 
        {
            percentage = total / 5;
           // return percentage;

        }

        public string PrintDetails()
        {
            return $"\nStudent Id:{studentId}\nStudent Name:{studentname}\nPercentage:{percentage}";
        }

        public static void Main(string[] args)
        {
            Student student = new Student(21, "Rutvika", 430);
            student.GetPercentage();
            Console.WriteLine(student.PrintDetails());

            Student student1 = new Student(22, "Ridhiman", 380);
            student1.GetPercentage();
            Console.WriteLine(student1.PrintDetails());
            
        }

    }
}
