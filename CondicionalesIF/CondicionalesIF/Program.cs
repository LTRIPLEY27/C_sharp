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

            // SWITCH

            Console.WriteLine("Elige un medio de transporte");
            string aux = Console.ReadLine();
            transporterApp(aux);
        }

        static String ageEvaluator(int age) => age < 18 ? "Eres menor de edad " : "Eres mayor de edad ";

        // ELSE IF CON TERNARIO
        static String healthAge(int age) => age < 18 ? "Eres un niño" : (age > 18 && age < 25 ? "Eres joven" : "Eres un adulto");


        //MÈTODO SWITCH

        static void transporterApp(string aux)
        {
            switch(aux)
            {
                case "carro":
                    Console.WriteLine("Dispone de un medio cada 30 min");
                    break;
                case "bici":
                    Console.WriteLine("Ayuda a disminuir la emisiòn de gases tòxicos");
                    break;
                case "autobùs":
                    Console.WriteLine("Consulte los horarios pues varìa segùn la temporada");
                    break;
                default:
                    Console.WriteLine("Debe de elegir una opciòn");
                    break;
            }
        }

    }
}
