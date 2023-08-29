using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int[] numeros = new int[8];

             numeros[0] = 1;
             numeros[1] = 3;
             numeros[2] = 5;
             numeros[3] = 7;
             numeros[4] = 9;
             numeros[5] = 11;
             numeros[6] = 13;
             numeros[7] = 15;

             for (int i = 0; i < 8; i++) {
                 Console.Write("\t" +numeros[i]);

             }
             Console.ReadKey();
            */

            /*int edad = 19;

            edad++;

            edad -= 8;

            Console.WriteLine("Tu edad es de :" + edad  + " Años");

            Console.WriteLine($"Tu edad es de : {edad} años"); //Interpolacion de Strings

            Console.ReadKey();
            */

            /* double Temperatura = 33.5;
             int TemperaturaManagua;

             //Conversion explicita
             //Casting

             TemperaturaManagua = (int) Temperatura;

             //Conversion Implicita

             int habitantesCiudad = 10000000;

             long habitantesCiudad2018 = habitantesCiudad;

             float pesoMaterial = 5.78F;

             double pesoMaterialprec = pesoMaterial;

             Console.WriteLine(pesoMaterialprec);

             Console.ReadKey();
            */

            //CONSTANTES

            /* const int VALOR = 5;

             const int VALOR2 = 7;

             Console.WriteLine("El numero es : {0}",VALOR,VALOR2);

             Console.ReadKey();
            */

            const double PI = 3.1416;
            double radio;
            
            double area;
            
            Console.WriteLine("Introduzca El radio");
            radio = double.Parse(Console.ReadLine());

            //area = radio * radio * PI;

            area = Math.Pow(radio, 2)*PI;

            Console.WriteLine($"El area es de: {area} CM");

            Console.ReadKey();
        }

    }
}
