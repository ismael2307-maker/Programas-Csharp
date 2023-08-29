using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad10
{
    class Program
    {
        static void Main(string[] args)
        {
            int modelo;
            int culo = 0;
            double operacion,total;

            const double Corolla = 19900;
            const double Chevey = 26500;
            const double Yaris = 18500;
            const double Mazda = 12000;

            while (culo == 0)
            {

                Console.WriteLine("1.Corola 2.-Chevey 3.-Yaris 4.-Mazda");

                do
                {
                    Console.WriteLine("Seleccione su opcion");
                    modelo = int.Parse(Console.ReadLine());
                } while (modelo <= 0 || modelo > 4);


                switch (modelo)
                {
                    case 1:
                        {
                            operacion = Corolla * 0.08;
                            total = Corolla - operacion;

                            Console.WriteLine("El descuento por la marca corrolla es de: " + operacion + " Dolares");
                            Console.WriteLine("El valor final a pagar sera de: " + total + " Dolares");

                            break;
                        }
                    case 2:
                        {
                            operacion = Chevey * 0.05;
                            total = Chevey - operacion;

                            Console.WriteLine("El descuento por la marca chevey es de: " + operacion + " Dolares");
                            Console.WriteLine("El valor final a pagar sera de: " + total + " Dolares");

                            break;
                        }
                    case 3:
                        {
                            operacion = Yaris * 0.06;
                            total = Yaris - operacion;

                            Console.WriteLine("El descuento por la marca Yaris es de: " + operacion + " Dolares");
                            Console.WriteLine("El valor final a pagar sera de: " + total + " Dolares");

                            break;
                        }
                    case 4:
                        {
                            operacion = Mazda * 0.09;
                            total = Mazda - operacion;

                            Console.WriteLine("El descuento por la marca Mazda es de: " + operacion + " Dolares");
                            Console.WriteLine("El valor final a pagar sera de: " + total + " Dolares");

                            break;
                        }

                }
            }
            Console.ReadKey();
        }
    }
}
