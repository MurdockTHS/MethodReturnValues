using System;

namespace MethodReturnValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(15,12));
            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Subtract(30, 20));
            Console.WriteLine(Divide(20,10));
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
