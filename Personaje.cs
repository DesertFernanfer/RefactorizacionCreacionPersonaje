using System;
using System.Collections.Generic;

namespace RefactorizacionCreacionPersonaje
{
    


    public class Personaje
    {
        private readonly Profesion _profesion;
        private readonly Raza _raza;
        private Dictionary<Caracteristica, int> _caracteristicas;

        public Personaje(Raza razaElegida, Profesion profesionElegida) {
            _raza = razaElegida;
            _profesion = profesionElegida;    
            GenerarCaracteristicas();
            AplicarModificadoresPorProfesion();
            AplicarModificadoresPorRaza();
            CorregirCaracteristicaPrincipal();
        }


        private void GenerarCaracteristicas() {
            _caracteristicas = new Dictionary<Caracteristica, int>();
            Random generador = new Random();
            foreach (Caracteristica caracteristica in Enum.GetValues(typeof(Caracteristica))) {
                _caracteristicas[caracteristica]= generador.Next(25, 81);
                Console.WriteLine(caracteristica);
            }
        }

        private void AplicarModificadoresPorRaza() {
            foreach(KeyValuePair<Caracteristica,int> caracteristicaYModificador in DatosRazasProfesionesCaracteristicas._modificadoresPorRaza[_raza]) {
                _caracteristicas[caracteristicaYModificador.Key] += caracteristicaYModificador.Value;
            }
        }

        private void AplicarModificadoresPorProfesion() {
            foreach (KeyValuePair<Caracteristica, int> caracteristicaYModificador in DatosRazasProfesionesCaracteristicas._modificadoresPorProfesion[_profesion]) {
                _caracteristicas[caracteristicaYModificador.Key] += caracteristicaYModificador.Value;
            }
        }

        private void CorregirCaracteristicaPrincipal() {
            int media = CalcularMediaCaracteristicas();
            _caracteristicas[DatosRazasProfesionesCaracteristicas._caracteristicaPrincipal[_profesion]]= Math.Max(_caracteristicas[DatosRazasProfesionesCaracteristicas._caracteristicaPrincipal[_profesion]], media);
        }

        private int CalcularMediaCaracteristicas() {
            int media = 0;
            foreach(KeyValuePair<Caracteristica,int> parCaracteristicaYValor in _caracteristicas) {
                media += parCaracteristicaYValor.Value;
            }
            media /= 3;
            return media;
        }


        public void MostrarPersonaje() {
            Console.WriteLine("Estas son las caracteristicas del personaje:");
            foreach(KeyValuePair<Caracteristica, int> parCaracteristicaNombre in _caracteristicas) {
                Console.Write($"{Enum.GetName(typeof(Caracteristica), parCaracteristicaNombre.Key)}: ");
                Console.ForegroundColor = ElegirColor(_caracteristicas[parCaracteristicaNombre.Key]);
                Console.WriteLine(_caracteristicas[parCaracteristicaNombre.Key]);
                Console.ResetColor();
            }
        }


        private ConsoleColor ElegirColor(int valorCaracteristica) {
            ConsoleColor color = ConsoleColor.Gray;
            
            if (valorCaracteristica < 40) {
                color = ConsoleColor.Red;
            }
            else if (valorCaracteristica < 60) {
                color = ConsoleColor.Yellow;
            }
            else if (valorCaracteristica < 81) {
                color = ConsoleColor.Green;
            }
            return color;
        }

        
    }
}
