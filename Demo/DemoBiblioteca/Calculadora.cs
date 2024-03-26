using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBiblioteca
{
    public class Calculadora
    {
        public static int sumar(int n1, int n2)
        {
            return n1 + n2;
        }

        public static int restar(int n1, int n2) => n1 - n2;
        
        public static Func<int, int, int> multiplicar = (n1, n2) => n1 * n2;

        public static decimal dividir(int n1, int n2) => n1 / n2;
        public static int modulo(int n1, int n2) => n1 % n2;
    }
}
