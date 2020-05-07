using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaDos
{
   public class Potencia
    {
        public int valorpote = 0;
        public int valor1pote;
        public int ValorUsuario;

        public int Pote(int valor1pote, int ValorUsuario)
        {
            int result = 0;
            result = valor1pote * ValorUsuario;
            return result;
        }
    }
}
