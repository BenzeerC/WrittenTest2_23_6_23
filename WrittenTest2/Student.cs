﻿using System;
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
        // Auto-implimented Properties  
        public int studentId { get; set; }
        public string studentname { get; set; }
        public float percentage { get; set; }

        public int total { get; set; }

        public void GetPercentage() 
        {
            percentage = total / 5;
           // return percentage;

        }
        public static void Main(string[] args)
        {
            // Setting properties  
            Student student = new Student()
            {
                studentId = 1,
                studentname = "Rajashree",
                total = 450
            };

            student.GetPercentage();
            // Getting properties  
            Console.WriteLine("Student Id:"+student.studentId);
            Console.WriteLine("Student Name:"+student.studentname);
            Console.WriteLine("Percentage:"+student.percentage);
           
            
           
        }

    }
}
