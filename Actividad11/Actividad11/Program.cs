using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad11
{
    class Program
    {
        static void Main(string[] args)
        {
            double AreaC,CircunC,Radio;
            const double PI= 3.1416;

            do
            {
                Console.WriteLine("Digite el radio");
                Radio = Double.Parse(Console.ReadLine());
            } while (Radio<=0);

            AreaC = PI * Math.Pow(Radio, 2);
            CircunC = 2 * PI * Radio;

            Console.WriteLine("El area del del ciruclo es: "+AreaC+" Centimetros cuadrados");
            Console.WriteLine("La circunferencia del circulo es :" +CircunC+ " Centimetros");

            Console.ReadKey();
        }
    }
}