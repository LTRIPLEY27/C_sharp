using System;

namespace MetodosParametros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //firtsMethod(5,6);
            Console.WriteLine(firtsMethod(5, 6));
            Console.WriteLine(sumaValor(5, 6));
            Console.WriteLine(sumaValor(5, 6, 32));
        }

        /*        static void firtsMethod(int a, int b)
                {
                    Console.WriteLine("instancia1" + a * b);
                }*/
        static int firtsMethod(int a, int b)
        {
            return a * b;
        }

        // SOBRECARGA D EMÈTODOS

        static int sumaValor(int a1, int a2) => a1 * a2; //SÌNTESIS DE MÈTODOS

        static int sumaValor(int a1, int a2, int a3) => a1 * a2 + a3; //SÌNTESIS DE MÈTODOS
    }
}
