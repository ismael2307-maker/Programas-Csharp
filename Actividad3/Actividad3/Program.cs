using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3
{
    class Program
    {
        static void Main(string[] args)
        {
            double CEnergia, Cagua, CInternet, Total;
            double vuelto,cd;

            do
            {
              Console.WriteLine("Digite su costo de servicios de energia");
              CEnergia = double.Parse(Console.ReadLine());
            } while (CEnergia<=0);

            do
            {
              Console.WriteLine("Digite su costo de servicios de agua");
              Cagua = double.Parse(Console.ReadLine());
            } while (Cagua <= 0);

            do
            {
              Console.WriteLine("Digite su costo de servicios de internet");
              CInternet = double.Parse(Console.ReadLine());
            } while (CInternet <= 0);

            Total = CEnergia + Cagua + CInternet;

            
            do
            {
              Console.WriteLine("Ingrese la cantidad de dinero");
              cd = double.Parse(Console.ReadLine());
            } while(cd<=0);

            if (cd <= Total)
            {
                Console.WriteLine("El dinero entregado no cubre el total a pagar");
            }else
            {
                vuelto = cd - Total;

                Console.WriteLine("Resumen de los pagos: ");

                Console.WriteLine("Servicios de energia: " + CEnergia + " Cordobas");
                Console.WriteLine("Servicios de agua: " + Cagua + " Cordobas");
                Console.WriteLine("Servicios de internet: " + CInternet + " Cordobas");

                Console.WriteLine("El total a pagar por los 3 servicios es: "+Total);
                Console.WriteLine("Su vuelto es de: " + vuelto + " Cordobas");

            }
            Console.ReadKey();
        }
    }
}
