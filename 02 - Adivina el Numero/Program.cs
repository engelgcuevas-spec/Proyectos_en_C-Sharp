using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivina_el_numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numero_secreto = random .Next(1,101);
            int Intentos = 0;
            int JugoUsuario = 0;

            Console.WriteLine("Adivina el numero \n");
            Console.WriteLine("Estas Listo?\n");
            Console.WriteLine("Que comience el juego");
            
            while(JugoUsuario != numero_secreto)
            {
                Console.WriteLine("Introduce el numero \n");
                string entrada = Console.ReadLine();
                Console.Clear();

                if (!int .TryParse(entrada, out JugoUsuario))
                {
                    Console.WriteLine("Estas menso, ese no es un numero \n");
                    continue;
                }
                Intentos ++;
                Console.WriteLine($"Van {Intentos} intentos \n");

                if(JugoUsuario < numero_secreto)
                {
                    Console.WriteLine("El numero que pusiste es menor al secreto \n");
                }
                else if(JugoUsuario > numero_secreto)
                {
                    Console.WriteLine("El numero que pusiste es mayor al secreto \n");
                }
                else
                {
                    Console.WriteLine("Que cabra, lo adivinaste \n");
                }
            }
            Console.WriteLine($"Gracias por jugar, el numero secreto era:  {numero_secreto}");
            Console.ReadLine();
        }
    }
}
