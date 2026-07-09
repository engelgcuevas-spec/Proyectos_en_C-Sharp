using System;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace hola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculadora calculadora = new calculadora();
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("   Calculadora   \n");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Salir \n");
                Console.WriteLine("Elija una opcion");

                string opcion = Console.ReadLine();
                string[] OpcionElegible = { "1", "2", "3", "4"};
                double a = 0, b = 0;
                double resultado = 0;
                Console.Clear();
                // hola
                if (OpcionElegible.Contains(opcion))
                {
                    Console.WriteLine("Elije el primer numero");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Elije el segundo numero");
                    b = Convert.ToDouble(Console.ReadLine());
                }

                switch (opcion)
                {
                    case "1":
                        resultado = calculadora.sumar(a, b);
                        Console.WriteLine("resultado: {0}", resultado);
                        break;

                    case "2":
                        resultado = calculadora.restar(a, b);
                        Console.WriteLine("resultado: {0}", resultado);
                        break;

                    case "3":
                        resultado = calculadora.multiplicar(a, b);
                        Console.WriteLine("resultado: {0}", resultado);
                        break;

                    case "4":
                        if (b == 0)
                        {
                            Console.WriteLine("No se puede hacer esta division");
                        }
                        else
                        {
                            resultado = calculadora.dividir(a, b);
                            Console.WriteLine("resultado: {0}", resultado);
                        }
                        break;
                            
                    case "5":
                        salir = true;
                        Console.WriteLine("Gracias por usar la calculadora");
                        break;

                    default:
                        Console.WriteLine("opcion invalida");
                        break;
                }

                Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

            }
        }

        class calculadora
        {
            public double sumar(double a, double b)
            {
                double resultado = a + b;
                return resultado;
            }

            public double restar(double a, double b)
            {
                double resultado = a - b;
                return resultado;
            }

            public double multiplicar(double a, double b)
            {
                double resultado = a * b;
                return resultado;
            }

            public double dividir(double a, double b)
            {
                double resultado = a / b;
                return resultado;
            }

        }
    }
}