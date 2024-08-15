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

                        Console.WriteLine("La suma de los números es: " + suma(a, b));

                    break;

                    case 2:

                        Console.WriteLine("La resta de los números es: " + resta(a, b));
            
                    break;

                    case 3:

                        Console.WriteLine("La multiplicación de los números es: " + multiplicacion(a, b));

                    break;

                    case 4:

                        Console.WriteLine("La división de los números es: " + division(a, b));

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
