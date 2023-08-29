using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad16
{
    class Program
    {
        static void Main(string[] args)
        {
            char sexo;
            int edad,pene=0;

            while (pene == 0)
            {
                Console.WriteLine("¿Cual es su sexo (H=Hombre y M=Mujer)");
                sexo = char.Parse(Console.ReadLine());

                do
                {
                 Console.WriteLine("¿Cual es su edad?");
                 edad = int.Parse(Console.ReadLine());
                } while (edad <= 20 && edad > 100);

                if (sexo == 'M' || sexo == 'm')
                {
                    if (edad > 54)
                    {
                     Console.WriteLine("Eres una mujer");
                     Console.WriteLine("Ya puede jubilarse");
                    }
                    else
                    {
                     Console.WriteLine("Eres una mujer");
                     Console.WriteLine("No puede jubilarse");

                    }
                }

                if (sexo == 'H' || sexo == 'h')
                {
                    if (edad > 60)
                    {
                    Console.WriteLine("Eres un hombre");
                    Console.WriteLine("Ya puede jubilarse");
                    }
                    else
                    {
                     Console.WriteLine("Eres un hombre");
                     Console.WriteLine("No puede jubilarse");

                    }


                }


            }
        }
    }
}
