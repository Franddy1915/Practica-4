using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3__Clase_llamada_aritmetica
{
   public class Aritmetica//clase.atributo
    {
        public static int Sumar(int x, int y)
        {
            return x + y;
        }
        public static int sumar(int x, int y, int j, int k)//sobre carga de datos 
        {
            return x + y + j + k;
        }

        public static int resta(int x, int y)
        {
            return x - y;
        }
        public static int resta(int x, int y, int j, int k)//sobre carga de datos
        {
            return x - y - j - k;
        }
        public static int multiplicacion(int x, int y)
        {
            return x * y;
        }
        public static int division(int x, int y)
        {
            return x / y;
        }
    }
}
