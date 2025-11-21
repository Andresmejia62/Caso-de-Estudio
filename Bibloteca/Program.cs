using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var libros = new List<Libro>
            {
                new Libro { Titulo = "El Quijote", AñoPublicacion = 1605 },
                new Libro { Titulo = "Andres y sus aventuras con Shylon", AñoPublicacion = 1967 },
                new Libro { Titulo = "El chavo", AñoPublicacion = 1963 },
                new Libro { Titulo = "El billy y el goofy", AñoPublicacion = 1963 },
                new Libro { Titulo = "Messi, el mejor jugador de todos los tiempos", AñoPublicacion = 2026 }
            };

            if (libros.Count == 0)
            {
                Console.WriteLine("No hay libros en la lista.");
            }

            var masReciente = libros.OrderByDescending(l => l.AñoPublicacion).First();
            var masAntiguo = libros.OrderBy(l => l.AñoPublicacion).First();

            Console.WriteLine($"Libro más reciente: {masReciente.Titulo} ({masReciente.AñoPublicacion})");
            Console.WriteLine($"Libro más antiguo: {masAntiguo.Titulo} ({masAntiguo.AñoPublicacion})");
            Console.ReadLine();
        }
    }

    public class Libro
    {
        public string Titulo { get; set; }
        public int AñoPublicacion { get; set; }
    }
}
