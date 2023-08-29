using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad4
{
    class Program
    {
        static void Main(string[] args)
        {
            int IN= 0;
            const double PI = 3.1415926536;
            double a, b; // para la elipse
            double D, d; //para el rombo 
            double Abase, Acaras, A, base1, base2, h, total;
            int operacion;
            double resultado;


             while (IN == 0)
            { 
            Console.WriteLine(" 1.-Elipse 2.-Rombo 3.-Piramide");

            do
            {
                Console.WriteLine("Digite la operacion geometrica");
                operacion = int.Parse(Console.ReadLine());
            } while (operacion <= 0 || operacion > 3);

            switch (operacion)
            {

              case 1:
                {

                 do
                 {
                  Console.WriteLine("Digite el valor de a");
                  a = double.Parse(Console.ReadLine());
                 }while (a <= 0);

                  do
                  {
                   Console.WriteLine("Digite el valor de b");
                   b = double.Parse(Console.ReadLine());
                  }while (b <= 0);

                   resultado = PI * a * b;
                   Console.WriteLine("El area de la elipse es: "+resultado);

                break;
                }

                case 2:
                {
                 do
                 {
                 Console.WriteLine("Digite el valor de la diagonal mayor");
                 D = double.Parse(Console.ReadLine());
                 } while (D <= 0);

                  do
                  {
                  Console.WriteLine("Digite el valor de la diagonal menor");
                  d = double.Parse(Console.ReadLine());
                  } while (d <= 0);

                  resultado = D * d / 2;
                  Console.WriteLine("El area del rombo es: " + resultado);

                break;
                }

                case 3:
                {
                 do
                 {
                 Console.WriteLine("Digite el valor de la base 1");
                 base1 = double.Parse(Console.ReadLine());
                 } while (base1 <= 0);

                 do
                 {
                 Console.WriteLine("Digite el valor de la base 2");
                 base2 = double.Parse(Console.ReadLine());
                 } while (base2 <= 0);

                  Abase = base1 * base2;


                 do
                 {
                 Console.WriteLine("Digite el valor de la altura");
                 h = double.Parse(Console.ReadLine());
                 } while (h <= 0);


                 A = base1 * h / 2;
                 Acaras = 4 * A;

                  total = Abase + Acaras;

                        Console.WriteLine("El area de la piramide es:" + total);
                 break;
                }




            }

           }



            Console.ReadKey();
        }
    }
}
