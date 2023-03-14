using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Negocio
    {
        protected int restar = 1;
        protected static int valor;
        protected int resultado;

        public static int Valor
        {
            set { valor = value; }
            get { return valor; }
        }
        public int Resta()
        {
            resultado = valor - restar;
            return resultado;
        }

    }
}
