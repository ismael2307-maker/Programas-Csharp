using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad9
{
    class Program
    {
        static void Main(string[] args)
        {
            double IngT, Egre, operacion;

            do
            {
                Console.WriteLine("Digite sus ingresos");
                IngT = double.Parse(Console.ReadLine());
            } while (IngT <= 0);

            do
            {
                Console.WriteLine("Digite sus Egresos");
                Egre = double.Parse(Console.ReadLine());
            } while (Egre <= 0);

            if (IngT<Egre)
            {
                Console.WriteLine("No se puede realizar la operacion");

            }
            else
            {
                operacion = IngT - Egre;



            }


        }
    }
}
