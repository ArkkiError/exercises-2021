using System;

namespace exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Pekka";
            Console.WriteLine(name);

            int age = 33;
            Console.WriteLine(age);

            double nuMBR = 3.14;
            Console.WriteLine(nuMBR);

            FunctionExecuted();
            int multiplied = Multiplied(16);
            Console.WriteLine(multiplied);
        }
        static void FunctionExecuted()
        {
            Console.WriteLine("Function Executed!");
        }
        static int Multiplied(int b)
        {
            return b * 2;
        }
    }
}
