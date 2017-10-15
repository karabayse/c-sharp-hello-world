// A Hello, World! program in C#.
using System;
namespace HelloWorld
{
    class Hello
    {
        // A C# console application must contain a Main method, in which control starts and ends.
        // The Main method is where you create objects and execute other methods.
        // The Main method is a static method that resides inside a class or a struct. 
        static void Main()
        {
            Console.WriteLine("Hello, World!");

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
