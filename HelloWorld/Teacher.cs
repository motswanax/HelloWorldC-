using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Teacher : Member, IPayee
    {
        public string subject;

        public void Pay()
        {
            Console.WriteLine("Paying teacher");
        }
    }
}
