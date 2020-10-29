using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /* This prints 2 4 4 because of 'ref'. The x is referenced by Five() so it is changed. */
            var x = 2;
            Console.WriteLine(x);

            /* ref lets us reference the value that is passed in. */
            Double(ref x);

            Console.WriteLine(x);
        }

        /* Out lets us reference the value that is passed in. */
        static void Five(ref int a)
        {
            a = 5;
            Console.WriteLine(a);
        }

        static void Double(ref int a)
        {
            a = a * 2;
            Console.WriteLine(a);
        }
    }
}
