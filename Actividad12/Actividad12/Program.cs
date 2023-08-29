using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad12
{
    class Program
    {
        static void Main(string[] args)
        {
            double Radio,AreaEsf,Volum;
            const double PI = 3.1416;

            do
            {
             Console.WriteLine("Digite el radio de la esfera");
             Radio = double.Parse(Console.ReadLine());
            } while (Radio<=0);

            AreaEsf = 4 * PI * Math.Pow(Radio, 2);
            Volum = 4 / 3 * Radio * Math.Pow(Radio, 3);

            Console.WriteLine("El area de la circunferencia es: "+AreaEsf+ " Centimetros");
            Console.WriteLine("El Volumen de la circunferencia es: " +Volum + " Centimetros");
            Console.ReadKey();
        }
    }
}
