using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            string nombre = "Maynor";
            int num1 = 55; //Indica valores enteros, tanto positivos y negativos

            uint num2 = 500; //Numero solo para positivos

            float num3 = 35.5f; //Numeros decimales
            double num4 = 45.50; //Numeros decimales, un espacio mas que el float
            decimal num5 = 502674.845612378m;//Numeros demasiado grandes

            byte num6 = 255; //Para trabajar numeros muy pequeños, su maximo es de 255

            bool acceso = false; //true

            DateTime fecha = DateTime.Today; //Para ver la facha actual

            Console.WriteLine("Hoy es :" + fecha);
            

         
            Console.ReadKey();


        }
    }
}
