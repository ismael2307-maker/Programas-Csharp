using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steven1
{
    class Program
    {
        static void Main(string[] args)
        {
            double ingresos, egresos, utilidad,operacion;

            do
            {
              Console.WriteLine("Digite los Ingresos");
              ingresos = double.Parse(Console.ReadLine());
            } while (ingresos<=0 || ingresos>500000);

            do
            {
              Console.WriteLine("Digite los Ingresos");
              egresos = double.Parse(Console.ReadLine());
            } while (egresos <= 0 || egresos > 500000);


            if (ingresos < egresos)
            {
                Console.WriteLine("No se puede realizar la operacion");
            }
            else
            {
                utilidad= ingresos - egresos;
                Console.WriteLine("La utilidad es de: "+utilidad+ " Cordobas");

                operacion = ingresos * 0.2;

                if (ingresos > operacion)
                {
                    Console.WriteLine("usted esta sujeto a credito");
                }
                else
                {
                    Console.WriteLine("usted no esta sujeto a credito");
                }



            }


            Console.ReadKey();
        }

    }
}
