using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6___Carro
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 9;
            var encender = 0;

           
            while (x < 10)
            {
                if (encender < 10)
                {
                    Console.WriteLine("El Carro esta lleno");
                }
                
                x--;
                break;
            }
            Console.ReadKey();
            

        }
    }
}
