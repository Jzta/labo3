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
        private Jugador[] jugador;

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
            this.jugadores = new Jugador[cantidadDeJugadores];
            this.jugador = new Jugador[cantidadDeJugadores];
        }

        public void AsignarJugadores(int cantidadDeJugadores)
        {
            for (int i = 0; i < cantidadDeJugadores; i++)
            {
                if (i < jugadores.Length && i < jugador.Length)
                {
                    jugadores[i] = jugador[i];
                }
            }
        }

        public void AsignarAmigosSecretos()
        {
            // Lógica para asignar amigos secretos
            Random random = new Random();

            // Creamos un vector de índices para mantener un registro de los índices utilizados
            int[] indicesUtilizados = new int[jugador.Length];

            // Inicializamos el vector de índices utilizados con valores negativos para indicar que no han sido usados
            for (int j = 0; j < indicesUtilizados.Length; j++)
            {
                indicesUtilizados[j] = -1;
            }

            // Iteramos sobre los jugadores para asignar amigos secretos
            for (int i = 0; i < jugador.Length; i++)
            {
                int indiceAmigoSecreto;

                do
                {
                    // Seleccionamos un índice aleatorio que no haya sido utilizado antes
                    indiceAmigoSecreto = random.Next(0, jugador.Length);
                } while (Array.Exists(indicesUtilizados, element => element == indiceAmigoSecreto) || indiceAmigoSecreto == i);

                // Asignamos el amigo secreto
                jugador[i].AmigoSecreto = jugador[indiceAmigoSecreto];
                indicesUtilizados[i] = indiceAmigoSecreto;
            }
        }

        public void ImprimirInformacionDelJuego()
        {
            Console.WriteLine("Información del juego:");
            Console.WriteLine($"Cantidad de jugadores: {cantidadDeJugadores}");
            Console.WriteLine($"Fecha de inicio: {fechaInicio}");
            Console.WriteLine($"Fecha de fin: {fechaFin}");
            Console.WriteLine($"Número de endulzadas: {numeroDeEndulzadas}");
            Console.WriteLine($"Frecuencia de endulzadas en días: {frecuenciaDeEndulzadasEnDias}");
            Console.WriteLine($"Valor de la endulzada: {valorDeLaEndulzada}");
            Console.WriteLine($"Valor del regalo: {valorDelRegalo}");

            for (int i = 0; i < cantidadDeJugadores; i++)
            {
                Console.WriteLine($"Jugador {jugadores[i].Nombre} le dará un regalo a {jugadores[i].AmigoSecreto.Nombre}.");
            }
        }

        public void ImprimirGustosDeJugadores()
        {
            Console.WriteLine("Gustos de los jugadores:");
            for (int i = 0; i < cantidadDeJugadores; i++)
            {
                Console.WriteLine($"Jugador {jugadores[i].Nombre}:");
                Console.WriteLine($"Dulces favoritos: {jugadores[i].DulcesFavoritos}");
                Console.WriteLine($"Regalo ideal: {jugadores[i].RegaloIdeal}");
                Console.WriteLine();
            }
        }

        public int CalcularProximaEndulzada(DateTime fecha)
        {
            TimeSpan diferencia = fechaFin - fechaInicio;
            int totalDias = diferencia.Days;
            int endulzadasRestantes = numeroDeEndulzadas;

            int frecuenciaEnDias = frecuenciaDeEndulzadasEnDias;
            int endulzadasPosibles = totalDias / frecuenciaEnDias;

            if (endulzadasPosibles < endulzadasRestantes)
            {
                return endulzadasPosibles;
            }
            else
            {
                return endulzadasRestantes;
            }
        }

    }
}
