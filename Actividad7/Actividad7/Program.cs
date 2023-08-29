using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad7
{
    class Program
    {
        static void Main(string[] args)
        {
            double IngT, InssL, operacion, Ao, porcentaje, pene;


            do 
            {
               Console.WriteLine("Digite sus ingresos mensuales");
               IngT = Double.Parse(Console.ReadLine());
            } while (IngT<=4800 || IngT > 500000);

            InssL = IngT * 0.07;
            operacion = IngT - InssL;
            Ao = operacion * 12;

            Console.WriteLine("El valor obtenido al año es de: " + Ao);
            pene = Ao;

            if (Ao >= 100000 && Ao <= 200000)
            {
                porcentaje = pene * 0.1;
                Console.WriteLine("El 10 porciento del valor obtenido al Año es de: " + porcentaje + " Cordobas");

            }
            else if (Ao >= 200001 && Ao <= 300000)
            {
                porcentaje = pene * 0.15;
                Console.WriteLine("El 15 porciento del valor obtenido al Año es de: " + porcentaje + " Cordobas");

            }
            else
            {
                porcentaje = pene * 0.2;
                Console.WriteLine("El 20 porciento del valor obtenido al Año es de: " + porcentaje + " Cordobas");

            }

            Console.ReadKey();
        }
    }
}
