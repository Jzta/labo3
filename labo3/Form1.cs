using System;
using System.Windows.Forms;

namespace labo3
{
    public partial class Form1 : Form
    {
        public AmigoSecreto amigoSecreto;
        private Jugador[] jugadores;
        public int cantidadDeJugadores;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private int numeroDeEndulzadas;
        private int frecuenciaDeEndulzadasEnDias;
        private float valorDeLaEndulzada;
        private float valorDelRegalo;



        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public bool ValidarCampos()
        {
            if (jugadoresNumericUpDown.Value <= 0 ||
                string.IsNullOrWhiteSpace(valorEndulzadaTextBox.Text) ||
                string.IsNullOrWhiteSpace(valorRegaloTextBox.Text))
            {
                MessageBox.Show("Por favor complete todos los campos requeridos.");
                return false;
            }
            return true;
        }

        public void CrearJuego_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                cantidadDeJugadores = (int)jugadoresNumericUpDown.Value;
                fechaInicio = dateTimePicker1.Value;
                fechaFin = dateTimePicker2.Value;
                numeroDeEndulzadas = (int)endulzadasNumericUpDown.Value;
                frecuenciaDeEndulzadasEnDias = (int)frecuenciaNumericUpDown.Value;
                valorDeLaEndulzada = float.Parse(valorEndulzadaTextBox.Text);
                valorDelRegalo = float.Parse(valorRegaloTextBox.Text);

                jugadores = new Jugador[cantidadDeJugadores]; // Inicializa el arreglo de jugadores

                amigoSecreto = new AmigoSecreto(cantidadDeJugadores, fechaInicio, fechaFin, numeroDeEndulzadas, frecuenciaDeEndulzadasEnDias, valorDeLaEndulzada, valorDelRegalo, jugadores);

                amigoSecreto.AsignarJugadores(cantidadDeJugadores);
                amigoSecreto.AsignarAmigosSecretos();
                amigoSecreto.ImprimirInformacionDelJuego();
                amigoSecreto.ImprimirGustosDeJugadores();
                amigoSecreto.CalcularProximaEndulzada(DateTime.Now);

                for (int i = 0; i < cantidadDeJugadores; i++)
                {
                    Form2 form2 = new Form2(cantidadDeJugadores);
                    form2.Form3Instance = this; // Asigna Form1 (this) a Form3Instance en Form2
                    form2.ShowDialog();

                    if (form2.jugadores != null)
                    {
                        jugadores[i] = form2.jugadores[i];
                        amigoSecreto.AgregarJugador(jugadores[i]); // Agrega el jugador a AmigoSecreto
                        Console.WriteLine($"Datos del jugador {i + 1}:");
                        Console.WriteLine($"Nombre: {jugadores[i].Nombre}");
                        Console.WriteLine($"Email: {jugadores[i].Email}");
                        Console.WriteLine($"Dulces favoritos: {jugadores[i].DulcesFavoritos}");
                        Console.WriteLine($"Regalo ideal: {jugadores[i].RegaloIdeal}");
                        Console.WriteLine();

                    }

                    form2.CantidadDeJugadores = cantidadDeJugadores;
                    form2.FechaInicio = fechaInicio;
                    form2.FechaFin = fechaFin;
                    
                }
            }
        }

        public void AgregarJugador(Jugador jugador)
        {
            Console.WriteLine($"Jugador {jugador.Nombre} agregado correctamente.");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}