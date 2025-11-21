using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoEstudio
{
    internal class BusquedaBinaria
    {
        static void Main()
        {
            // Lista ordenada de autores 
            List<string> autores = new List<string>()
        {
            "Borges",
            "Cervantes",
            "Cortázar",
            "García Márquez",
            "Homero"
        };

            Console.WriteLine("=== BÚSQUEDA BINARIA DE AUTORES ===");
            Console.Write("Ingresa el nombre del autor a buscar: ");
            string autorBuscado = Console.ReadLine();

            // Variables para definir los límites del área de búsqueda
            int inicio = 0;                  // Primer índice de la lista
            int fin = autores.Count - 1;     // Último índice de la lista
            bool encontrado = false;         // Bandera para saber si lo encontramos

            // Ciclo de búsqueda binaria
            while (inicio <= fin)
            {
                // Se calcula la posición media
                int medio = (inicio + fin) / 2;

                // Compara el autor en la posición media con el autor buscado
                // string.Compare devuelve:
                //  0 -> son iguales
                // <0 -> el medio es "menor" al buscado (buscar a la derecha)
                // >0 -> el medio es "mayor" al buscado (buscar a la izquierda)
                int comparacion = string.Compare(autores[medio], autorBuscado, true);

                if (comparacion == 0)
                {
                    // Encontrado
                    Console.WriteLine($"Autor encontrado en la posición {medio}");
                    encontrado = true;
                }
                else if (comparacion < 0)
                {
                    // Si el autor en medio es menor al buscado,
                    // debemos seguir buscando en la mitad derecha
                    inicio = medio + 1;
                }
                else
                {
                    // Si es mayor, buscamos en la mitad izquierda
                    fin = medio - 1;
                }
            }

            // Si no se encontró el autor
            if (!encontrado)
            {
                Console.WriteLine("El autor no se encuentra en la lista.");
            }

            Console.WriteLine("\nPresiona una tecla para salir...");
            Console.ReadKey();
        }
    }

}

