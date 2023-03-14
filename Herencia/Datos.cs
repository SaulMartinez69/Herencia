using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Datos:Negocio
    {
        protected int sumar = 1;

        public int Suma()
        {
            resultado = valor + sumar;
            return resultado;
        }
    }
}
