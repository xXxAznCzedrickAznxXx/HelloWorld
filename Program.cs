using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            float number1 = float.Parse(Console.ReadLine());
            float number2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Select an option:\n1.-Add\n2.-Subtract\n3.-Multiply\n4.-Divide\n5.Exit");

            int option = int.Parse(Console.ReadLine())
        }

        public static float AddTwoNumbers(float n1, float n2)
        {
            float result = n1 + n2;

            return result;
        }

    }
}
