using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoEstudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Busqueda lineal 

            List<string> Libros = new List<string>()
            {
                "Don Quijote","La Odisea","Divina Comedia", "Rayuela"
            };

            List<string> Autores = new List<string>()
            {
                "Borges","Cortazar","Dante","Homero"
            };

            Console.WriteLine("=== BÚSQUEDA LINEAL DE LIBROS ===");
            Console.WriteLine("Ingresa el libro a buscar");
            string librobuscado = Console.ReadLine();

            bool Encontrado = false;

            for (int i = 0; i < Libros.Count; i++)
            {
                if (Libros[i].Equals(librobuscado, StringComparison.OrdinalIgnoreCase))
                {
                    Encontrado = true;
                    // Reemplaza la línea problemática por la siguiente:
                    Console.WriteLine("Libro encontrado en la posición: " + (i + 1));
                }

            }

            if (!Encontrado)
            {
                Console.WriteLine("El libro no se encuentra en la lista");
                    }


        }
    }
}
