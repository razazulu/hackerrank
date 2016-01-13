using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Serialization;

namespace CSharpTestBed
{
    class Program
    {
        class Solution
        {
            static void Main(String[] args)
            {
                String firstName = Console.ReadLine();
                String lastName = Console.ReadLine();
                int phone = Int32.Parse(Console.ReadLine());
                int score = Int32.Parse(Console.ReadLine());
                Student stu = new Grade(firstName, lastName, phone, score);
                stu.display();
                Grade g = (Grade)stu;
                Console.WriteLine("Grade: " + g.calculate());
            }
        }
    }

    class Grade : Student
    {
        private int score;

        public Grade(String fname, string lname, int p, int s) : base(fname, lname, p)
        {
            score = s;
        }

        public char calculate()
        {
            if (score < 40) return 'D';
            if (score >= 40 && score < 60) return 'B';
            if (score >= 60 && score < 75) return 'A';
            if (score >= 75 && score < 90) return 'E';
            if (score >= 90 && score < 100) return 'O';
            return '';
        }
    }

    internal class Student
    {
        protected String firstName;
        protected String lastName;
        private int phone;

        public Student(String fname, String lname, int p)
        {
            firstName = fname;
            lastName = lname;
            phone = p;

        }

        public void display()
        {
            // display the details of the student
            Console.WriteLine("First Name: " + firstName + "\nLast Name: " + lastName + "\nPhone: " + phone);
        }

    }


}
