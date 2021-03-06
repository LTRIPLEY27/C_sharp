using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // FIRSTS STEPS

            /*
            int edad = 28;
            Console.WriteLine(edad);
            Console.WriteLine(8 * 96);
            Console.WriteLine(5.0 / 2.5);
            // Console.WriteLine("Edad aproximada : " + edad);
            //  INTERPOLACION DE STRINGS
            Console.WriteLine($"Edad aproximada : { edad } ");

            */


            // SECOND STEP

            int edadPersona1;
            int edadPersona2;
            int edadPersona3;
            int edadPersona4;

            // UNIFICACIÒN DE DECLARACION DE VARIABLES A UNA LÌNEA (DECLARACIÒN IMPLICITA DE VARIABLES)
            edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 23;

            Console.WriteLine(edadPersona4);
            Console.WriteLine(edadPersona3);
            Console.WriteLine(edadPersona2);
            Console.WriteLine(edadPersona1);

            //  CASTING

           // Declaraciòn explicita de variables:

            //conversiòn d eun tipo de variable a otro.

            double temperature = 33.5;
            int temperatureNormal;

            temperatureNormal = (int)temperature; //CASTING DE DOUBLE A INTEGER

            Console.WriteLine(temperatureNormal);
            Console.WriteLine(temperature);


            // Conversiòn de texto a numeral

            Console.WriteLine("Induzca el primer valor");
            int val1 = int.Parse(Console.ReadLine()); // CONVERSION DE DATOS 
            Console.WriteLine(val1);
            string val2 = "hola";
            string aux = String.Concat(Console.ReadLine(), val2);
            Console.WriteLine(aux);
            Console.WriteLine("fin");


            // CONSTANTES

            const int VALOR = 6; // CONSTANTE DECLARADA E INICIALIZADA 

            const int VALAND = 7;   

            Console.WriteLine("Valor constante :{0} {1}",VALOR, VALAND); // IMPRESIÒN DE MÙLTIPLES CONSTANTES COMO PARÀMETROS


            // EJEMPLO DE PI CON CONSTANTES

            const double PI = 3.1416;

            Console.WriteLine("Indique radio");
            double radio = double.Parse(Console.ReadLine());

            //double calculo = PI * radio * radio;
            double calculo = Math.Pow(radio, 2) * PI;
            Console.WriteLine("El valor es igual a {0}", calculo);
        }
    }
}
