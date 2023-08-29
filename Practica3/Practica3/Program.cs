using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, D, Resultado,Ac,Ab,Resul;

            do
            {
              Console.WriteLine("Digite el valor de A");
              A = double.Parse(Console.ReadLine());
            } while (A<=0);

            do
            {
              Console.WriteLine("Digite el valor de C");
              C = double.Parse(Console.ReadLine());
            } while (C <= 0);

            Console.WriteLine("Digite el valor de D");
            D = double.Parse(Console.ReadLine());

            if (D == 0)
            {
                Console.WriteLine("Mordela, no se puede hacer");
            }

            Ac = A - C;
            Resultado = Math.Pow(Ac, 2)/D;

            Console.WriteLine("El resultado de la operacion es :" +Resultado);

            do
            {
              Console.WriteLine("Digite el valor de A");
              A = double.Parse(Console.ReadLine());
            } while (A <= 0);

            do
            {
              Console.WriteLine("Digite el valor de B");
             B = double.Parse(Console.ReadLine());
            } while (B <= 0);

            
              Console.WriteLine("Digite el valor de D");
              D = double.Parse(Console.ReadLine());
          

            if (D == 0)
            {
             Console.WriteLine("Mordela, no se puede hacer");
            }

            Ab = A - B;

            Resul = Math.Pow(Ab,3)/D;

            Console.WriteLine("El resultado de la operacion es: "+Resul);



            Console.ReadKey();
        }
    }
}
