namespace TAREAPILAS2
{
    using System;
    using System.Collections.Generic;

    public class Cancion
    {
        public string Titulo { get; set; }
        public string Artista { get; set; }

        public Cancion(string titulo, string artista)
        {
            Titulo = titulo;
            Artista = artista;
        }

        public override string ToString()
        {
            return $"{Titulo} - {Artista}";
        }
    }

    public class SpotifyPila
    {
        private Stack<Cancion> pilaCanciones;

        public SpotifyPila()
        {
            pilaCanciones = new Stack<Cancion>();
        }

        // Agregar una canción a la pila (Push)
        public void AñadirCancion(Cancion cancion)
        {
            pilaCanciones.Push(cancion);
            Console.WriteLine($"Añadido a la lista: {cancion}");
        }

        // Eliminar la última canción añadida (Pop)
        public void EliminarUltimaCancion()
        {
            if (pilaCanciones.Count > 0)
            {
                Cancion eliminada = pilaCanciones.Pop();
                Console.WriteLine($"Eliminado de la lista: {eliminada}");
            }
            else
            {
                Console.WriteLine("No hay canciones en la pila para eliminar.");
            }
        }

        // Ver la última canción sin eliminarla (Peek)
        public void VerUltimaCancion()
        {
            if (pilaCanciones.Count > 0)
            {
                Cancion ultimaCancion = pilaCanciones.Peek();
                Console.WriteLine($"Última canción en la pila: {ultimaCancion}");
            }
            else
            {
                Console.WriteLine("No hay canciones en la pila.");
            }
        }

        // Mostrar todas las canciones de la pila
        public void MostrarCanciones()
        {
            if (pilaCanciones.Count > 0)
            {
                Console.WriteLine("Canciones en la lista de reproducción:");
                foreach (Cancion cancion in pilaCanciones)
                {
                    Console.WriteLine(cancion);
                }
            }
            else
            {
                Console.WriteLine("No hay canciones en la pila.");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SpotifyPila spotifyPila = new SpotifyPila();

            // Añadir canciones a la pila
            spotifyPila.AñadirCancion(new Cancion("Llamado de emergencia", "Daddy yankey"));
            spotifyPila.AñadirCancion(new Cancion("TU", "Sabino"));
            spotifyPila.AñadirCancion(new Cancion("La Magia", "Sabino"));

            // Mostrar la última canción
            spotifyPila.VerUltimaCancion();

            // Eliminar la última canción (LIFO: se elimina "Song 3")
            spotifyPila.EliminarUltimaCancion();

            // Mostrar todas las canciones después de eliminar
            spotifyPila.MostrarCanciones();

            // Eliminar otra canción
            spotifyPila.EliminarUltimaCancion();

            // Mostrar todas las canciones restantes
            spotifyPila.MostrarCanciones();
        }
    }

}
