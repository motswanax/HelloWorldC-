using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /* This prints 2 5 5 because of 'out'. The x is not referenced by Five() so it is not changed. */
            var x = 2;
            Console.WriteLine(x);

            /* Out lets us reference the value that is passed in. */
            Five(out x);

            Console.WriteLine(x);
        }

        /* Out lets us reference the value that is passed in. */
        static void Five(out int a)
        {
            a = 5;
            Console.WriteLine(a);
        }
    }
}
