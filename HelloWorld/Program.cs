using System;
using System.Collections.Generic;

namespace HelloWorld
{
    enum School
    {
        MaterSpei,
        StJosephs,
        Swaneng
    }

    class Program
    {
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            PayRoll payroll = new PayRoll();
            payroll.PayAll();

            var adding = true;

            while (adding)
            {
                try
                {
                    var newStudent = new Student();
                    newStudent.Name = Util.Console.Ask("Student Name: ");

                    newStudent.Grade = Util.Console.askInt("Student Grade: ");

                    newStudent.School = (School) Util.Console.askInt("School Name (type the corresponding number): \n0: Mater Spei \n1: St. Joseph's \n2: Swaneng\n");

                    newStudent.Birthday = Util.Console.Ask("Student Birthday: ");

                    newStudent.Address = Util.Console.Ask("Student Addresss: ");

                    newStudent.Phone = Util.Console.askInt("Student Phone: ");

                    students.Add(newStudent);
                    Student.Count++;
                    Console.WriteLine("Student Count: {0}", Student.Count);

                    Console.WriteLine("Add another? y/n");

                    if (Console.ReadLine() != "y")
                        adding = false;
                }
                catch (FormatException msg)
                {
                    /* Specific catch is always before the general catch */
                    Console.WriteLine(msg.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("Error adding student. Please try again.");
                }
                
            }

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
            }
            Export();
        }

        static void import()
        {
            var importedStudent = new Student("Bad", 75, "December", "address", 123456);
            Console.WriteLine(importedStudent.Name);
        }
        
        static void Export()
        {
            foreach (var student in students)
            {
                switch(student.School)
                {
                    case School.MaterSpei:
                        Console.WriteLine("Exporting to Mater Spei");
                        break;
                    case School.StJosephs:
                        Console.WriteLine("Exporting to St. Joseph's");
                        break;
                    case School.Swaneng:
                        Console.WriteLine("Exporting to Swaneng");
                        break;
                }
            }
        }
    }

    class Member
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
    }

    class Student : Member
    {
        static public int Count { get; set; } = 0;

        /* These are known as fields in C# */
        public int Grade { get; set; }
        public string Birthday { get; set; }
        public School School { get; set; }

        public Student()
        {

        }

        public Student(string name, int grade, string birthday, string address, int phone)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address = address;
            Phone = phone;
        }

        public void setPhone(int number)
        {
            Phone = number;
        }
    }
}
