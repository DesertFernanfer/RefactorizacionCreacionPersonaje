using System;
using System.Collections.Generic;
using System.Text;

namespace RefactorizacionCreacionPersonaje
{
    class Program
    {
        static void Main()
        {
            int opcion;
            do
            {
                Console.Clear();
                opcion = GeneradorPersonajes.PedirValorAlUsuario("Bienvenido al programa de creación de personajes." +
                    "\nSelecciona una opción:\n1.Introducir raza.\n2.Introducir profesión." +
                    "\n3.Crear personaje y mostrar informe.\n4.Salir.");
                GeneradorPersonajes.ClasificarPersonaje(opcion);
            } while (opcion != 4);
        }
    }
}
