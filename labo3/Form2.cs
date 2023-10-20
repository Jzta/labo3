using System;
using System.Windows.Forms;

namespace labo3
{
    public partial class Form2 : Form
    {
        // Definir las variables y propiedades necesarias
        public Jugador[] jugadores;
        private int indice = 0;
        public int cantidadDeJugadores = 10; // Se puede ajustar según sea necesario
        private DateTime fechaInicio = new DateTime(2023, 10, 1); // Puedes ajustar la fecha de inicio
        private DateTime fechaFin = new DateTime(2023, 10, 31); // Puedes ajustar la fecha de finalización
        private int numeroDeEndulzadas = 5; // Puedes ajustar el número de endulzadas
        private int frecuenciaDeEndulzadasEnDias = 7; // Puedes ajustar la frecuencia de endulzadas
        private float valorDeLaEndulzada = 2; // Puedes ajustar el valor de la endulzada
        private float valorDelRegalo = 30; // Puedes ajustar el valor del regalo

        // Propiedades para almacenar la información del juego
        public int CantidadDeJugadores { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string InformacionJugadores { get; set; }

        // Propiedad para mantener una referencia al Form1
        public Form Form3Instance { get; set; }

        // Constructor de Form2
        public Form2()
        {
            InitializeComponent();
        }

        // Constructor adicional para inicializar el arreglo de jugadores
        public Form2(int cantidadJugadores)
        {
            InitializeComponent();
            jugadores = new Jugador[cantidadJugadores];
        }

        // Evento del botón para agregar jugadores
        public void button1_Click(object sender, EventArgs e)
        {
            // Validar si los campos de entrada no están vacíos
            if (nombreTextBox != null && emailTextBox != null && dulcesFavoritosTextBox != null && regaloIdealTextBox != null)
            {
                if (!string.IsNullOrWhiteSpace(nombreTextBox.Text) && !string.IsNullOrWhiteSpace(emailTextBox.Text) && !string.IsNullOrWhiteSpace(dulcesFavoritosTextBox.Text) && !string.IsNullOrWhiteSpace(regaloIdealTextBox.Text))
                {
                    // Comprobar si hay espacio para más jugadores y si hay una instancia de Form1
                    if (indice < jugadores.Length && Form3Instance != null)
                    {
                        // Crear un nuevo jugador y agregarlo al arreglo
                        Jugador jugador = new Jugador(nombreTextBox.Text, emailTextBox.Text, dulcesFavoritosTextBox.Text, regaloIdealTextBox.Text);
                        jugadores[indice] = jugador;
                        ((Form1)Form3Instance).AgregarJugador(jugador); // Pasar el jugador a Form1
                        LimpiarCampos();
                        indice++;

                        // Inicializar el objeto AmigoSecreto con los valores adecuados
                        AmigoSecreto amigoSecreto = new AmigoSecreto(cantidadDeJugadores, fechaInicio, fechaFin, numeroDeEndulzadas, frecuenciaDeEndulzadasEnDias, valorDeLaEndulzada, valorDelRegalo, jugadores);

                        // Verificar si se han ingresado todos los jugadores
                        if (indice == jugadores.Length)
                        {
                            // Muestra un mensaje con la información del juego y los jugadores
                            string informacionJuego =
                                $"Cantidad de jugadores: {CantidadDeJugadores}\n" +
                                $"Fecha de inicio: {FechaInicio}\n" +
                                $"Fecha de fin: {FechaFin}\n";

                            MessageBox.Show(informacionJuego);
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor complete todos los campos.");
                }
            }
            else
            {
                MessageBox.Show("Error de inicialización de controles en el formulario.");
            }
        }

        // Método para limpiar los campos de entrada
        private void LimpiarCampos()
        {
            nombreTextBox.Text = "";
            emailTextBox.Text = "";
            dulcesFavoritosTextBox.Text = "";
            regaloIdealTextBox.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}