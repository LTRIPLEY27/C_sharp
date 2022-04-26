using System;

namespace CondicionalesIF
{
    class Program
    {
        static void Main(string[] args)
        {
            //  bool isCold = false;

            //Console.WriteLine(!isCold);
            int age = 21;
            Console.WriteLine("Age evaluator ");
            Console.WriteLine("Give me your age, please");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine(ageEvaluator(age));

        }

        static String ageEvaluator(int age) => age < 18 ? "Eres menor de edad " : "Eres mayor de edad ";
    }
}
