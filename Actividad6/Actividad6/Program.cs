using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad6
{
    class Program
    {
        static void Main(string[] args)
        {
            int km,millas;
            int operacion,resultado;
            int IN = 0;


            while (IN == 0) { 

            Console.WriteLine("1.-Kilometros a metros 2.-Kilometros a millas 3.-millas a kilometros 4.-millas a metros 5.-metros a kilometros 6.-metros a millas");
            operacion = int.Parse(Console.ReadLine());

                switch (operacion)
                {

                    case 1:
                     {

                       do
                       {
                        Console.WriteLine("Digite la cantidad de kilometros");
                        km = int.Parse(Console.ReadLine());
                       } while (km <= 0);

                       resultado = km * 1000;

                      Console.WriteLine("La conversion de kilometros a metros es de:"+resultado);

                      break;
                     }

                    case 2:     
                    {
                      do
                      {
                       Console.WriteLine("Digite la cantidad de kilometros");
                       km = int.Parse(Console.ReadLine());
                      } while (km <= 0);


                    break;      
                    }








                }





            }



        }
    }
}
