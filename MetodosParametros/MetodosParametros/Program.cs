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
            Console.WriteLine(couldBe(5, 6, 9));
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


        // PARÀMETROS OPCIONALES

        static double couldBe(double a, double b, double c = 0) => a * b + c; // LA SINTÀXIS PARA QUE UN PARÀMETRO SEA OPCIONAL SE DEBE DE INDICAR EN EL LA PROPIA RECEPCION DEL MÈTODO E INICIALIZADO EL PARÀMETRO EN '0' O VACÌO, SEGÙN APLIQUE.

        // LOS PARÀMETROS OPCIONALES SIEMPRE DEBEN DE SEGUIR A LOS OBLIGATORIOS
    }
}
