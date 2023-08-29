using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad14
{
    class Program
    {
        static void Main(string[] args)
        {

            float prom = 0, calif, suma = 0;
            int alumnos;

            do {
              Console.WriteLine("Escriba el numero de alumnos");
              alumnos = int.Parse(Console.ReadLine());
            } while (alumnos<0);

            for (int i = 0; i < alumnos; i++)
            {
                do
                {
                    Console.WriteLine("Escriba el numero de la clasificacion "+(i+1)+" : ");
                    calif = float.Parse(Console.ReadLine());
                } while (calif <= 0 || calif>20);

                suma = suma + calif;
            }
            prom = suma / alumnos;
            Console.WriteLine("El promedio del grupo es de: "+prom+ " Puntos");


            Console.ReadKey();
        }
    }
}
