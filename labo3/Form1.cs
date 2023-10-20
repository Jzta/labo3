using System;
using System.Windows.Forms;

namespace labo3
{
    public partial class Form1 : Form
    {
        private AmigoSecreto amigoSecreto;
        private Jugador[] jugadores;
        private int cantidadDeJugadores;
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

        private bool ValidarCampos()
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
                int cantidadDeJugadores = (int)jugadoresNumericUpDown.Value;
                DateTime fechaInicio = dateTimePicker1.Value;
                DateTime fechaFin = dateTimePicker2.Value;
                int numeroDeEndulzadas = (int)endulzadasNumericUpDown.Value;
                int frecuenciaDeEndulzadasEnDias = (int)frecuenciaNumericUpDown.Value;
                float valorDeLaEndulzada = float.Parse(valorEndulzadaTextBox.Text);
                float valorDelRegalo = float.Parse(valorRegaloTextBox.Text);

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
                        Console.WriteLine($"Datos del jugador {i + 1}:");
                        Console.WriteLine($"Nombre: {jugadores[i].Nombre}");
                        Console.WriteLine($"Email: {jugadores[i].Email}");
                        Console.WriteLine($"Dulces favoritos: {jugadores[i].DulcesFavoritos}");
                        Console.WriteLine($"Regalo ideal: {jugadores[i].RegaloIdeal}");
                        Console.WriteLine();
                    }
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