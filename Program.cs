using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Lienzo mi_lienzo = new Lienzo(40, 20);
            Serpiente serpiente = new Serpiente(20, 10);

            Comida comida = new Comida(mi_lienzo);

            mi_lienzo.Bordes();
            bool jugando = true;
            while (jugando)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo Tecla = Console.ReadKey(true);
                    if (Tecla.Key == ConsoleKey.Escape)
                    {
                        jugando = false;
                    }
                    serpiente.CambiarDireccion(Tecla.Key);
                }
                if (jugando)
                {
                    Console.SetCursorPosition(comida.X, comida.Y);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("0");
                    Console.ResetColor();

                    serpiente.Mover(mi_lienzo, comida);
                    foreach (var parte in serpiente.Cuerpo)
                    {
                        Console.SetCursorPosition(parte.X, parte.Y);
                        Console.Write("@");
                    }

                    Thread.Sleep(100);
                }
            }
            Console.Clear();
            Console.SetCursorPosition(10, 10);
            Console.WriteLine("Gracias por jugar");
            Console.ReadLine();
           
        }
    }

    class Lienzo
    {
        public int Ancho { get; set; }
        public int Alto { get; set; }

        public Lienzo(int Ancho, int Alto)
        {
            this.Alto = Alto;
            this.Ancho = Ancho;
        }
        public void Bordes()
        {
            for (int i = 0; i <= Ancho; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("*");
                Console.SetCursorPosition(i, Alto);
                Console.Write("*");
            }
            for (int i = 0; i <= Alto; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("*");
                Console.SetCursorPosition(Ancho, i);
                Console.Write("*");
            }
        }

        public void Limpiar_Zelda(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
        }
    }

    class Serpiente
    {
        public List<(int X, int Y)> Cuerpo { get; set; }
        public int DirX { get; set; }
        public int DirY { get; set; }

        public Serpiente(int xInicial, int yInicial)
        {
            Cuerpo = new List<(int X, int Y)>();
            Cuerpo.Add((xInicial, yInicial));
            Cuerpo.Add((xInicial - 1, yInicial));
            Cuerpo.Add((xInicial - 2, yInicial));

            DirX = 1;
            DirY = 0;
        }

        public void Mover(Lienzo mapa, Comida comida)
        {
            var CabezaActual = Cuerpo[0];
            (int X, int Y) NuevaCabeza = (CabezaActual.X + DirX, CabezaActual.Y + DirY);
            Cuerpo.Insert(0, NuevaCabeza);

            if (NuevaCabeza.X == comida.X && NuevaCabeza.Y == comida.Y)
            {
                comida.GenerarNuevaPosicion(mapa);
            }
            else
            {
                var ColaVieja = Cuerpo[Cuerpo.Count - 1];
                Cuerpo.RemoveAt(Cuerpo.Count - 1);
                mapa.Limpiar_Zelda(ColaVieja.X, ColaVieja.Y);
            }
        }
        public void CambiarDireccion(ConsoleKey Tecla)
        {   
            switch (Tecla)
            {
                case ConsoleKey.UpArrow:
                    if (DirY != 1) { DirX = 0; DirY = -1; }
                    break;
                case ConsoleKey.DownArrow:
                    if (DirY != -1) { DirX = 0; DirY = 1; }
                    break;
                case ConsoleKey.LeftArrow:
                    if (DirX != 1) { DirX = -1; DirY = 0; }
                    break;
                case ConsoleKey.RightArrow:
                    if (DirX != -1) { DirX = 1; DirY = 0; }
                    break;
            }
        }
    }
    class Comida
    {
        public int X {  get; set; }
        public int Y { get; set; }
        private Random Rdn = new Random();
        
        public Comida(Lienzo mapa)
        {
           GenerarNuevaPosicion(mapa);
        }

        public void GenerarNuevaPosicion(Lienzo mapa)
        {
            X = Rdn.Next(1, mapa.Ancho);
            Y = Rdn.Next(1, mapa.Alto);
        }
    }
}
