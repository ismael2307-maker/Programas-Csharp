using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad15
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, j,edad;
            string nombre, grupo = " ";
            double nota, suma=0,prom=0;

            for (i = 0; i < 45; i++)
            {
                Console.WriteLine("Digite su nombre : ");
                nombre = Console.ReadLine();

                Console.WriteLine("Digite su Grupo : ");
                grupo = Console.ReadLine();

                do
                {
                    Console.WriteLine("Digite su edad");
                    edad = int.Parse(Console.ReadLine());
                } while (edad <= 17 || edad > 23);

                for (j = 0; j < 6; j++)
                {
                    do
                    {
                      Console.WriteLine("Escriba la calificacion " +  (j + 1) + " : ");
                      nota = double.Parse(Console.ReadLine());
                    } while (nota < 0 || nota >= 100);

                    suma = suma + nota;
                }
                prom = suma / 6;
                Console.WriteLine("HOJA DE MARTRICULA");
                Console.WriteLine("Nombre: "+nombre);
                Console.WriteLine("Grupo Universitario : "+grupo);
                Console.WriteLine("Edad "+edad+ " Años");
                Console.WriteLine("Contabilidad Financiera : "+prom+ " Puntos");


            }




            Console.ReadKey();
        }
    }
}
