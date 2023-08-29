using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peneeee
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversion de texto a numero
            int num1;
            int num2;
            int Resultado;
            Console.WriteLine("Digite el primer numero :");
            num1 =int.Parse (Console.ReadLine());

            Console.WriteLine("Digite el segundo numero :");
            num2 = int.Parse(Console.ReadLine());

            Resultado = num1 + num2;

            //Console.WriteLine("El resultado de la suma es de " + Resultado);

            Console.WriteLine("El resultado de la suma es de :" + (num1 + num2));

            Console.ReadKey();
        }
    }
}
