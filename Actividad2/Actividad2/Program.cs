using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2
{
    class Program
    {
        static void Main(string[] args)
        {
            double Ing, Egresos, util;

            do
            {
              Console.WriteLine("Digite sus ingresos");
              Ing = double.Parse(Console.ReadLine());
            } while (Ing <= 4800 || Ing > 500000);

            do
            {
              Console.WriteLine("Digite sus egresos");
              Egresos = double.Parse(Console.ReadLine());
            } while (Egresos>Ing || Egresos<=0);

            util = Ing - Egresos;

            Console.WriteLine("La utilidad es de: "+util);

            Console.ReadKey();
        }
    }
}
