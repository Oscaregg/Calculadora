using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos1
{
    internal class principal
    {
        public static void Main(String[] args)
        {

            int opc = 0;
            float a, b;
            do
            {
                float resp;

                Console.WriteLine("Ingrese el primer número");
                a = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo número");
                b = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese una opción");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Salir");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:

                        resp = suma(a, b);

                        Console.WriteLine("La suma es: " + resp);

                    break;

                    case 2:

                        resp = resta(a, b);

                        Console.WriteLine("La resta es: " + resp);
            
                    break;

                    case 3:

                        resp = multiplicacion(a, b);

                        Console.WriteLine("La multiplicación es: " + resp);

                    break;

                    case 4:

                        resp = division(a, b);

                        Console.WriteLine("La división es: " + resp);

                    break;

                    case 5:

                        Console.WriteLine("Gracias por usar nuestra calculadora, vuelva pronto");

                        Environment.Exit(0);

                    break;

                    default:

                        Console.WriteLine("Opción incorrecta, intente con una opción del 1 al 5");

                    break;
                }   

            } while (opc != 5);
           
        }

        static float suma(float a, float b)
        {
            float resultado = a + b;
            return resultado;
        }

        static float resta(float a, float b)
        {
            float resultado = a + b;
            return resultado;
        }

        static float multiplicacion(float a, float b)
        {
            float resultado = a * b;
            return resultado;
        }

        static float division(float a, float b)
        {
            float resultado = a / b;
            return resultado;
        }

    }
}
