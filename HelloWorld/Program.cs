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
                newStudent.name = Util.Console.Ask("Student Name: ");

                newStudent.grade = (int.Parse(Util.Console.Ask("Student Grade: ")));

                newStudent.birthday = Util.Console.Ask("Student Birthday: ");

                newStudent.address = Util.Console.Ask("Student Addresss: ");

                newStudent.Phone = (int.Parse(Util.Console.Ask("Student Phone: ")));

                students.Add(newStudent);
                Student.count++;
                Console.WriteLine("Student Count: {0}", Student.count);

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
        static public int count = 0;

        /* These are known as fields in C# */
        public string name;
        public int grade;
        public string birthday;
        public string address;
        private int phone;

        /* This is a property. The setter inside acts like a function and you can add logic to it */
        public int Phone
        {
            set { phone = value; }
        }

        public void setPhone(int number)
        {
            phone = number;
        }
    }
}
