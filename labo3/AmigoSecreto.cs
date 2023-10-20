using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labo3
{
    public class AmigoSecreto
    {
        private int cantidadDeJugadores;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private int numeroDeEndulzadas;
        private int frecuenciaDeEndulzadasEnDias;
        private float valorDeLaEndulzada;
        private float valorDelRegalo;
        private Jugador[] jugadores;

        public int CantidadDeJugadores { get; private set; }
        public DateTime FechaInicio { get; private set; }
        public DateTime FechaFin { get; private set; }

        public AmigoSecreto(int cantidadDeJugadores, DateTime fechaInicio, DateTime fechaFin, int numeroDeEndulzadas,
                            int frecuenciaDeEndulzadasEnDias, float valorDeLaEndulzada, float valorDelRegalo, Jugador[] jugadores)
        {
            this.cantidadDeJugadores = cantidadDeJugadores;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.numeroDeEndulzadas = numeroDeEndulzadas;
            this.frecuenciaDeEndulzadasEnDias = frecuenciaDeEndulzadasEnDias;
            this.valorDeLaEndulzada = valorDeLaEndulzada;
            this.valorDelRegalo = valorDelRegalo;
            this.jugadores = jugadores;
        }

        public void AsignarJugadores(int cantidadDeJugadores)
        {
            // Implementa la lógica para asignar jugadores aquí
        }

        public void AsignarAmigosSecretos()
        {
            // Implementa la lógica para asignar amigos secretos aquí
        }

        public void ImprimirInformacionDelJuego()
        {
            // Implementa la lógica para imprimir la información del juego aquí
        }

        public void ImprimirGustosDeJugadores()
        {
            // Implementa la lógica para imprimir los gustos de cada jugador aquí
        }

        public int CalcularProximaEndulzada(DateTime fecha)
        {
            // Implementa la lógica para calcular la próxima endulzada aquí
            return 0; // Solo para cumplir con la sintaxis
        }
    }
}