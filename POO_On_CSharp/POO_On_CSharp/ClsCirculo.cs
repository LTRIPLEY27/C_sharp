using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_On_CSharp
{
    class Circulo
    {
        public double PI = Math.PI;

        public double calculaArea(int radio)
        {
            return PI * radio * radio;
        }
    }
}
