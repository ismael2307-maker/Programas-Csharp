using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1
{
    class Program
    {
        static void Main(string[] args)
        {
         int num1,num2,num3,num4,num5;
            int suma;
            int promedio;

            do 
            {
              Console.WriteLine("Digite el primer numero");
              num1 = int.Parse(Console.ReadLine());
            } while(num1<=0 || num1>20);

            do
            {
             Console.WriteLine("Digite el segundo numero");
             num2 = int.Parse(Console.ReadLine());
            }while (num2<=0 || num2 >20);

            do
            {
             Console.WriteLine("Digite el tercer numero");
             num3 = int.Parse(Console.ReadLine());
            } while (num3<=0 || num3>20);

            do
            {
             Console.WriteLine("Digite el cuarto numero");
             num4 = int.Parse(Console.ReadLine());
            } while (num4 <= 0 || num4 > 20);

            do
            {
             Console.WriteLine("Digite el quinto numero");
             num5 = int.Parse(Console.ReadLine());
            } while (num5 <= 0 || num5 > 20);

            suma = num1+num2+num3+num4+num5;

            promedio = suma / 5;

            Console.WriteLine("Su promedio es de: "+promedio +" Puntos");

            Console.ReadKey();
        }

    }
}
