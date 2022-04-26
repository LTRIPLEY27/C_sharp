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

            // ELSE IF
            Console.WriteLine(healthAge(age));

        }

        static String ageEvaluator(int age) => age < 18 ? "Eres menor de edad " : "Eres mayor de edad ";

        // ELSE IF CON TERNARIO
        static String healthAge(int age) => age < 18 ? "Eres un niño" : (age > 18 && age < 25 ? "Eres joven" : "Eres un adulto");

    }
}
