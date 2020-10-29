using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /* This prints 2 5 2. The x is not referenced by Five() so it is not changed. */
            var x = 2;
            Console.WriteLine(x);

            Five(x);

            Console.WriteLine(x);
        }

        static void Five(int a)
        {
            a = 5;
            Console.WriteLine(a);
        }
    }
}
