using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    class Program
    {
        static void Main(string[] args)
        {
            double SUE,operacion,operacion2;
            int CATE,HE;

            Console.WriteLine("1.-Categoria #1 2.-Categoria #2 3.-Categoria #3 4.-Categoria #4");

            do
            {
                Console.WriteLine("Seleccione su opcion");
                CATE = int.Parse(Console.ReadLine());
            } while (CATE <= 0 || CATE > 8);

            if (CATE > 4)
            {
                Console.WriteLine("al ser mayor de categoria, no se les paga horas extras");


            }
            else
            {


                switch (CATE)
                {
                    case 1:
                        {
                            do
                            {
                                Console.WriteLine("Digite su sueldo base");
                                SUE = double.Parse(Console.ReadLine());
                            } while (SUE <= 0 || SUE > 100000);

                            do
                            {
                                Console.WriteLine("Digite las horas extras trabajas");
                                HE = int.Parse(Console.ReadLine());
                            } while (HE <= 0 || HE > 40);

                            if (HE > 30)
                            {

                                operacion = HE * 30;
                                operacion2 = SUE + operacion;
                                Console.WriteLine("Por las " + HE + " horas extras trabajadas, su pago por dichas horas sera de: " + operacion + " Cordobas");
                                Console.WriteLine("Su pago total es de: " + operacion2 + " Cordobas");

                            }
                            else
                            {
                                operacion = HE * 30;
                                operacion2 = SUE + operacion;
                                Console.WriteLine("Por las " + HE + " horas extras trabajadas, su pago por dichas horas sera de: " + operacion + " Cordobas");
                                Console.WriteLine("Su pago total es de: " + operacion2 + " Cordobas");

                            }
                            break;
                        }
                    case 2:
                        {
                            do
                            {
                                Console.WriteLine("Digite su sueldo base");
                                SUE = double.Parse(Console.ReadLine());
                            } while (SUE <= 0 || SUE > 100000);

                            do
                            {
                                Console.WriteLine("Digite las horas extras trabajas");
                                HE = int.Parse(Console.ReadLine());
                            } while (HE <= 0 || HE > 40);

                            if (HE > 30)
                            {
                                operacion = HE * 30;
                                operacion2 = SUE + operacion;
                                Console.WriteLine("Por las " + HE + " horas extras trabajadas, su pago por dichas horas sera de: " + operacion + " Cordobas");
                                Console.WriteLine("Su pago total es de: " + operacion2 + " Cordobas");

                            }
                            else
                            {
                                operacion = HE * 38;
                                operacion2 = SUE + operacion;
                                Console.WriteLine("Por las " + HE + " horas extras trabajadas, su pago por dichas horas sera de: " + operacion + " Cordobas");
                                Console.WriteLine("Su pago total es de: " + operacion2 + " Cordobas");
                            }
                            break;
                        }

                    case 3:
                        {

                            do
                            {
                                Console.WriteLine("Digite su sueldo base");
                                SUE = double.Parse(Console.ReadLine());
                            } while (SUE <= 0 || SUE > 100000);

                            do
                            {
                                Console.WriteLine("Digite las horas extras trabajas");
                                HE = int.Parse(Console.ReadLine());
                            } while (HE <= 0 || HE > 40);

                            if (HE > 30)
                            {
                                operacion = HE * 30;
                                operacion2 = SUE + operacion;
                                Console.WriteLine("Por las " + HE + " horas extras trabajadas, su pago por dichas horas sera de: " + operacion + " Cordobas");
                                Console.WriteLine("Su pago total es de: " + operacion2 + " Cordobas");

                            }
                            else
                            {
                                operacion = HE * 50;
                                operacion2 = SUE + operacion;
                                Console.WriteLine("Por las " + HE + " horas extras trabajadas, su pago por dichas horas sera de: " + operacion + " Cordobas");
                                Console.WriteLine("Su pago total es de: " + operacion2 + " Cordobas");
                            }
                            break;
                        }
                    case 4:
                        {

                            do
                            {
                                Console.WriteLine("Digite su sueldo base");
                                SUE = double.Parse(Console.ReadLine());
                            } while (SUE <= 0 || SUE > 100000);

                            do
                            {
                                Console.WriteLine("Digite las horas extras trabajas");
                                HE = int.Parse(Console.ReadLine());
                            } while (HE <= 0 || HE > 40);

                            if (HE > 30)
                            {
                                operacion = HE * 30;
                                operacion2 = SUE + operacion;
                                Console.WriteLine("Por las " + HE + " horas extras trabajadas, su pago por dichas horas sera de: " + operacion + " Cordobas");
                                Console.WriteLine("Su pago total es de: " + operacion2 + " Cordobas");


                            }
                            else
                            {
                                operacion = HE * 70;
                                operacion2 = SUE + operacion;
                                Console.WriteLine("Por las " + HE + " horas extras trabajadas, su pago por dichas horas sera de: " + operacion + " Cordobas");
                                Console.WriteLine("Su pago total es de: " + operacion2 + " Cordobas");
                            }
                            break;
                        }
                }

            }
            Console.ReadKey();
        }
    }
}
