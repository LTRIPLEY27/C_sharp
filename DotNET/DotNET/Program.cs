using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET
{
    class Program
    {
        static void Main(string[] args)
        {
            //NOTACIONES DEL FRAMEWORK ESPECÌFICO CON CONDICIONALES
#if DNX451
            Console.WriteLine(System.Reflection.Assembly.GetExecutingAssembly().FullName);
#endif
            Console.WriteLine("hello");

#if DNXCORE50
           Console.WriteLine("versiòn core");
#endif
            Console.WriteLine("hello");
        }
    }
}
