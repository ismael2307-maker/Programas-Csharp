using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad13
{
    class Program
    {
        static void Main(string[] args)
        {
            double area;
            double x1, y1, x2, y2, x3, y3;

            do
            {
             Console.WriteLine("Digite el valor x1 del punto p1");
             x1 = double.Parse(Console.ReadLine());
            } while (x1<=0);

            do
            {
             Console.WriteLine("Digite el valor y1 del punto p1");
             y1= double.Parse(Console.ReadLine());
            } while (y1 <= 0);

            do
            {
             Console.WriteLine("Digite el valor x2 del punto p2");
             x2 = double.Parse(Console.ReadLine());
            } while (x2 <= 0);

            do
            {
             Console.WriteLine("Digite el valor y2 del punto p2");
             y2 = double.Parse(Console.ReadLine());
            } while (y2 <= 0);

            do
            {
             Console.WriteLine("Digite el valor x3 del punto p3");
             x3 = double.Parse(Console.ReadLine());
            } while (x3 <= 0);

            do
            {
             Console.WriteLine("Digite el valor y3 del punto p3");
             y3 = double.Parse(Console.ReadLine());
            } while (y3 <= 0);

            area = Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2))/2;

            Console.WriteLine("La superficie es de: "+area+ " Centimetros");




            Console.ReadKey();
        }
    }
}

