using System;

namespace RefactorizacionCreacionPersonaje
{
    class GeneradorPersonajes
    {
        private static Raza? _raza;
        private static Profesion? _profesion;
        public static int PedirValorAlUsuario(string mensaje)
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



        public static void ClasificarOpciones(int opcion)
        {
            if(opcion == 1)
            {
                _raza = (Raza)PedirValorAlUsuario("¿De qué raza es el personaje?\n0. Humano\n1. Elfo. \n2. Enano.\n3. Orco.");
            }
            else if (opcion == 2)
            {
                _profesion = (Profesion)PedirValorAlUsuario("¿De qué profesión es el personaje?\n0. Guerrero\n1. Mago. \n2. Ladrón.\n3. Clérigo.");
            }
            else if (opcion == 3)
            {
                CrearYMostrarPersonaje();
            }
            else if (opcion == 4)
            {
                Console.WriteLine("Adiós!!!");
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
