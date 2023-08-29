using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            double ImporB,operacion,ImportN;
            string i;
            bool imb;

            do
            {
                do
                {
                  Console.WriteLine("Ingrese el importe bruto");
                  i = Console.ReadLine();
                  imb = double.TryParse(i, out ImporB);
                } while (ImporB <= 0);
            } while (!imb);

            if (ImporB >= 15000)
            {
                operacion = ImporB * 0.16; //16%
                ImportN = ImporB - operacion;

                Console.WriteLine("El importe bruto es de: " + ImporB + " Cordobas");
                Console.WriteLine("La cantidad a restar al importe bruto es de: " + operacion + " Cordobas");
                Console.WriteLine("El importe neto es :"+ImportN+" Cordobas");

            }else if(ImporB<15000){

                operacion = ImporB * 0.1; //10%
                ImportN = ImporB - operacion;

                Console.WriteLine("El importe bruto es de: "+ImporB+ " Cordobas");
                Console.WriteLine("La cantidad a restar al importe bruto es de: " + operacion + " Cordobas");
                Console.WriteLine("El importe neto es :" + ImportN+" Cordobas");

            }
            Console.ReadKey();
        }
    }
}
