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
                    newStudent.name = Util.Console.Ask("Student Name: ");

                    newStudent.grade = Util.Console.askInt("Student Grade: ");

                    newStudent.school = (School) Util.Console.askInt("School Name (type the corresponding number): \n0: Mater Spei \n1: St. Joseph's \n2: Swaneng\n");

                    newStudent.birthday = Util.Console.Ask("Student Birthday: ");

                    newStudent.address = Util.Console.Ask("Student Addresss: ");

                    newStudent.Phone = Util.Console.askInt("Student Phone: ");

                    students.Add(newStudent);
                    Student.count++;
                    Console.WriteLine("Student Count: {0}", Student.count);

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
                Console.WriteLine("Name: {0}, Grade: {1}", student.name, student.grade);
            }
            Export();
        }

        static void import()
        {
            var importedStudent = new Student("Bad", 75, "December", "address", 123456);
            Console.WriteLine(importedStudent.name);
        }
        
        static void Export()
        {
            foreach (var student in students)
            {
                switch(student.school)
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
        public string name;
        public string address;
        protected int phone;

        public int Phone
        {
            set { phone = value; }
        }
    }

    class Student : Member
    {
        static public int count = 0;

        /* These are known as fields in C# */
        public int grade;
        public string birthday;
        public School school;

        public Student()
        {

        }

        public Student(string name, int grade, string birthday, string address, int phone)
        {
            this.name = name;
            this.grade = grade;
            this.birthday = birthday;
            this.address = address;
            this.phone = phone;
        }

        public void setPhone(int number)
        {
            phone = number;
        }
    }
}
