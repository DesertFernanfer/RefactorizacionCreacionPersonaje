using System;
using System.Collections.Generic;
using System.Text;

namespace RefactorizacionCreacionPersonaje
{

    public enum Profesion {Guerrero, Mago, Ladron, Clerigo };
    public enum Raza {Humano, Elfo, Enano, Orco }
    public enum Caracteristica { Fuerza, Inteligencia, Agilidad, Intuicion }


    class DatosRazasProfesionesCaracteristicas
    {

        public static readonly Dictionary<Profesion, Caracteristica> _caracteristicaPrincipal = new Dictionary<Profesion, Caracteristica>() {
            {Profesion.Guerrero,Caracteristica.Fuerza },
            {Profesion.Mago,Caracteristica.Inteligencia },
            {Profesion.Ladron,Caracteristica.Agilidad },
            {Profesion.Clerigo,Caracteristica.Intuicion }
        };

        public static readonly Dictionary<Caracteristica, int> _modificadoresPorHumano = new Dictionary<Caracteristica, int>() {
            {Caracteristica.Fuerza,5 }
        };

        public static readonly Dictionary<Caracteristica, int> _modificadoresPorElfo = new Dictionary<Caracteristica, int>() {
            {Caracteristica.Agilidad,10 },
            {Caracteristica.Inteligencia,5 }
        };

        public static readonly Dictionary<Caracteristica, int> _modificadoresPorEnano = new Dictionary<Caracteristica, int>() {
           {Caracteristica.Fuerza,10 },
            {Caracteristica.Intuicion,5 },
            {Caracteristica.Agilidad,-5 }
        };

        public static readonly Dictionary<Caracteristica, int> _modificadoresPorOrco = new Dictionary<Caracteristica, int>() {
            {Caracteristica.Fuerza,15 },
            {Caracteristica.Intuicion,-5 },
            {Caracteristica.Inteligencia,-5 }
        };

        public static readonly Dictionary<Caracteristica, int> _modificadoresPorGuerrero = new Dictionary<Caracteristica, int>() {
            {Caracteristica.Fuerza,5 },
            {Caracteristica.Agilidad,5 }
        };

        public static readonly Dictionary<Caracteristica, int> _modificadoresPorMago = new Dictionary<Caracteristica, int>() {
            {Caracteristica.Fuerza,-5 },
            {Caracteristica.Inteligencia,15 }
        };

        public static readonly Dictionary<Caracteristica, int> _modificadoresPorLadron = new Dictionary<Caracteristica, int>() {
            {Caracteristica.Agilidad,10 }
        };

        public static readonly Dictionary<Caracteristica, int> _modificadoresPorClerigo = new Dictionary<Caracteristica, int>() {
            {Caracteristica.Fuerza,5 },
            {Caracteristica.Intuicion,5 }
        };

        public static readonly Dictionary<Profesion, Dictionary<Caracteristica, int>> _modificadoresPorProfesion = new Dictionary<Profesion, Dictionary<Caracteristica, int>>() {
            {Profesion.Clerigo,_modificadoresPorClerigo },
            {Profesion.Guerrero,_modificadoresPorGuerrero },
            {Profesion.Ladron,_modificadoresPorLadron },
            {Profesion.Mago,_modificadoresPorMago }
        };

        public static readonly Dictionary<Raza, Dictionary<Caracteristica, int>> _modificadoresPorRaza = new Dictionary<Raza, Dictionary<Caracteristica, int>>() {
            {Raza.Humano,_modificadoresPorHumano },
            {Raza.Elfo,_modificadoresPorElfo },
            {Raza.Enano,_modificadoresPorEnano },
            {Raza.Orco,_modificadoresPorOrco }
        };
        //Creo que no hace falta
        /*
        public static readonly Dictionary<Caracteristica, string> _nombresCaracteristicas = new Dictionary<Caracteristica, string>() {
            {Caracteristica.Fuerza,"Fuerza" },
            {Caracteristica.Agilidad,"Agilidad" },
            {Caracteristica.Inteligencia,"Inteligencia" },
            {Caracteristica.Intuicion,"Intuicion" }
        };
        */
        public static readonly Dictionary<int, ConsoleColor> _colores = new Dictionary<int, ConsoleColor>()
        {
            {39, ConsoleColor.Red },
            {59, ConsoleColor.Yellow },
            {80, ConsoleColor.Green }
        };



    }
}
