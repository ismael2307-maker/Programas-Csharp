using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad8
{
    class Program
    {
        static void Main(string[] args)
        {
            double MontoF, operacion, porcentaje;
            int pene = 0;

            while (pene == 0)
            {

                do
                {
                   Console.WriteLine("Digite el monto de la factura");
                   MontoF = double.Parse(Console.ReadLine());
                } while (MontoF <= 0);


                if (MontoF > 5000)
                {
                    operacion = MontoF * 0.1;
                    porcentaje = MontoF - operacion;
                    Console.WriteLine("El descuento del 10 por ciento es de: " + operacion + " Cordobas");
                    Console.WriteLine("El total es : " + porcentaje + " Cordobas");

                }
                else if (MontoF >= 2500 && MontoF <= 4999)
                {
                    operacion = MontoF * 0.05;
                    porcentaje = MontoF - operacion;
                    Console.WriteLine("El descuento del 5 por ciento es de: " + operacion + " Cordobas");
                    Console.WriteLine("El total es : " + porcentaje + " Cordobas");

                }
                else if (MontoF >= 1000 && MontoF < 2500)
                {
                    operacion = MontoF * 0.03;
                    porcentaje = MontoF - operacion;
                    Console.WriteLine("El descuento del 3 por ciento es de: " + operacion + " Cordobas");
                    Console.WriteLine("El total es : " + porcentaje + " Cordobas");

                }
                else
                {
                    Console.WriteLine("No se aplica descuento");
                    Console.WriteLine("El total es : " + MontoF + " Cordobas");
                }


                Console.ReadKey();
            }
        }
    }
}
