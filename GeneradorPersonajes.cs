using System;

namespace RefactorizacionCreacionPersonaje
{
    class GeneradorPersonajes
    {
        private static Raza? _raza;
        private static Profesion? _profesion;
        static void Main()
        {
            int opcion;
            do
            {
                Console.Clear();
                opcion = PedirValorAlUsuario("Bienvenido al programa de creación de personajes." +
                    "\nSelecciona una opción:\n1.Introducir raza.\n2.Introducir profesión." +
                    "\n3.Crear personaje y mostrar informe.\n4.Salir.");
                ClasificarPersonaje(opcion);
            } while (opcion != 4);
        }


        private static int PedirValorAlUsuario(string mensaje)
        {
            int valor;
            bool valorValido;
            do
            {
                Console.WriteLine(mensaje);
                valorValido = int.TryParse(Console.ReadLine(), out valor);
                if (valor < 0 || valor > 4)
                {
                    valorValido = false;
                }
            } while (!valorValido);
            return valor;
        }



        private static void ClasificarPersonaje(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    {
                        _raza = (Raza)PedirValorAlUsuario("¿De qué raza es el personaje?\n0. Humano\n1. Elfo. \n2. Enano.\n3. Orco.");
                        break;
                    }
                case 2:
                    {
                        _profesion = (Profesion)PedirValorAlUsuario("¿De qué profesión es el personaje?\n0. Guerrero\n1. Mago. \n2. Ladrón.\n3. Clérigo.");
                        break;
                    }
                case 3:
                    {
                        CrearYMostrarPersonaje();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Adiós!!!");
                        break;
                    }
            }
        }


        private static void CrearYMostrarPersonaje()
        {
            if (_raza == null || _profesion == null)
            {
                Console.WriteLine("Es necesario definir primero raza y profesión." +
                    "\nPulsa cualquier tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                Personaje personaje = new Personaje((Raza)_raza, (Profesion)_profesion);
                personaje.MostrarPersonaje();
                Console.WriteLine("Pulsa cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
