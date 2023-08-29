using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine (sumaNumeros(7,9));

            Console.WriteLine(divisionNumeros(18,3));

            Console.WriteLine(multiplicacionNumeros(5, 3));

            Console.ReadKey();
        }


        static int sumaNumeros(int num1, int num2){

            // Console.WriteLine($"La suma de los numeros es: {num1+num2}");


            return num1 + num2;
        }

        static double divisionNumeros(double num1, double num2) => num1 / num2; //Otra forma de declarar metodos

        static int multiplicacionNumeros(int num1, int num2) {

            int resultado;

            resultado = num1 * num2;

            return resultado;
        }

           
        
        


        
    }
}
