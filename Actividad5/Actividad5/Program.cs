using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            int operacion,IN=0;
            double resultado;

            while(IN==0)
            {
              Console.WriteLine("1.-Suma 2.-Resta 3.-multiplicacion 4.-Division 5.-Modulo 6.-Exponenciacion");

                do
                {
                 Console.WriteLine("Digite su opcion");
                 operacion = int.Parse(Console.ReadLine());
                } while (operacion <= 0 || operacion > 6);


                switch (operacion)
                {
                    case 1:
                    {
                      do
                      {
                       Console.WriteLine("Digite el primer numero");
                       num1 = double.Parse(Console.ReadLine());
                      } while (num1 <= 0 || num1 > 10);


                       do
                       {
                       Console.WriteLine("Digite el segundo numero");
                       num2 = double.Parse(Console.ReadLine());
                       } while (num2 <= 0 || num2 > 10);


                       resultado = num1 + num2;
                       Console.WriteLine("El resultado de la suma es : "+resultado);
                    break;
                    }

                    case 2:
                        {
                         do
                         {
                           Console.WriteLine("Digite el primer numero");
                           num1 = double.Parse(Console.ReadLine());
                         } while (num1 <= 0 || num1 > 10);


                         do
                         {
                          Console.WriteLine("Digite el segundo numero");
                           num2 = double.Parse(Console.ReadLine());
                         } while (num2 <= 0 || num2 > 10);

                           resultado = num1 - num2;
                           Console.WriteLine("El resultado de la resta es : " + resultado);
                           break;
                        }


                    case 3:
                        {
                         do
                         {
                          Console.WriteLine("Digite el primer numero");
                          num1 = double.Parse(Console.ReadLine());
                         } while (num1 <= 0 || num1 > 10);


                         do
                         {
                           Console.WriteLine("Digite el segundo numero");
                           num2 = double.Parse(Console.ReadLine());
                         } while (num2 <= 0 || num2 > 10);

                            resultado = num1 * num2;
                            //Console.WriteLine("El resultado de la multiplicacion es : " + resultado);

                            Console.WriteLine($"La multiplicacion de los numeros es: {num1*num2}");

                            
                            break;
                        }

                    case 4:
                        {
                         do
                         {
                          Console.WriteLine("Digite el primer numero");
                          num1 = double.Parse(Console.ReadLine());
                         } while (num1 <= 0 || num1 > 10);


                            do
                            {
                              Console.WriteLine("Digite el segundo numero");
                              num2 = double.Parse(Console.ReadLine());
                            } while (num2 <= 0 || num2 > 10);

                            resultado = num1 / num2;
                            Console.WriteLine($"La division de los numeros es: {num1 / num2}");

                            break;
                        }


                    case 5:
                        {
                         do
                          {
                            Console.WriteLine("Digite el primer numero");
                            num1 = double.Parse(Console.ReadLine());
                          } while (num1 <= 0 || num1 > 10);


                          do
                           {
                            Console.WriteLine("Digite el segundo numero");
                            num2 = double.Parse(Console.ReadLine());
                           } while (num2 <= 0 || num2 > 10);

                            resultado = num1 % num2;
                            Console.WriteLine($"El modulo de los numeros es: {num1 % num2}");
                          
                            break;
                        }
                        
                    case 6:
                        {
                         do
                          {
                           Console.WriteLine("Digite el primer numero");
                           num1 = double.Parse(Console.ReadLine());
                          } while (num1 <= 0 || num1 > 10);


                         do
                          {
                            Console.WriteLine("Digite el segundo numero");
                            num2 = double.Parse(Console.ReadLine());
                          } while (num2 <= 0 || num2 > 10);

                            resultado = (double) Math.Pow(num1,num2);
                            Console.WriteLine("El resultado de la exponenciancion es: "+resultado);
                            break;
                        }










                }










            }



        }
    }
}
