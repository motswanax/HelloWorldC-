using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            var adding = true;

            while (adding)
            {
                var newStudent = new Student();
                Console.Write("Student Name: ");
                newStudent.name = Console.ReadLine();

                Console.Write("Student Grade: ");
                newStudent.grade = (int.Parse(Console.ReadLine()));

                Console.Write("Student Birthday: ");
                newStudent.birthday = Console.ReadLine();

                Console.Write("Student Address: ");
                newStudent.address = Console.ReadLine();

                Console.Write("Student Phone Number: ");
                newStudent.setPhone(int.Parse(Console.ReadLine()));

                students.Add(newStudent);

                Console.WriteLine("Add another? y/n");

                if (Console.ReadLine() != "y")
                    adding = false;
            }

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", student.name, student.grade);
            }
        }
    }

    class Student
    {
        public string name;
        public int grade;
        public string birthday;
        public string address;
        private int phone;

        public void setPhone(int number)
        {
            phone = number;
        }
    }
}
