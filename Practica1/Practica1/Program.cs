using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            string ed,kil;
            bool esdad,eskilos;
            double kilos,conversion;
          
            do
            {
                do
                {
                 Console.WriteLine("Digite su edad, por favor");
                 ed = Console.ReadLine();
                 esdad = int.TryParse(ed, out edad);
                } while (edad <= 0 || edad>100);

            } while (!esdad);
          
            do
            {
                do
                 {
                  Console.WriteLine("Digite su peso en kilos, por favor");
                  kil = Console.ReadLine();
                  eskilos = Double.TryParse(kil, out kilos);
                }while(kilos<=0 || kilos>100);

            } while (!eskilos);

            conversion = kilos*2.205;

            Console.WriteLine("Su edad es de: "+edad+ " Años");
            Console.WriteLine("Su peso en kilos es de: "+kilos+ " Kilos");
            Console.WriteLine("Su peso en libras es de : "+conversion+ " Libras");
           
          
            Console.ReadKey();
        }
    }
}
