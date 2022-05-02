using System;
using POO_On_CSharp; // importar los namespace

namespace POO_On_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Circulo circle = new Circulo();
            Console.WriteLine(circle.PI);
            Console.WriteLine(circle.calculaArea(5));
        }
    }

    // ADICIÒN DE LAS CLASES

    
}
