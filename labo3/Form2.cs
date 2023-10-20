using System;
using System.Windows.Forms;

namespace labo3
{
    public partial class Form2 : Form
    {
        public Jugador[] jugadores;
        private int indice = 0;
        int cantidadDeJugadores = 10;
        DateTime fechaInicio = new DateTime(2023, 10, 1);
        DateTime fechaFin = new DateTime(2023, 10, 31);
        int numeroDeEndulzadas = 5;
        int frecuenciaDeEndulzadasEnDias = 7;
        float valorDeLaEndulzada = 2.5f;
        float valorDelRegalo = 30.0f;
        public Form Form3Instance { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int cantidadJugadores)
        {
            InitializeComponent();
            jugadores = new Jugador[cantidadJugadores];
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (nombreTextBox != null && emailTextBox != null && dulcesFavoritosTextBox != null && regaloIdealTextBox != null)
            {
                if (!string.IsNullOrWhiteSpace(nombreTextBox.Text) && !string.IsNullOrWhiteSpace(emailTextBox.Text) && !string.IsNullOrWhiteSpace(dulcesFavoritosTextBox.Text) && !string.IsNullOrWhiteSpace(regaloIdealTextBox.Text))
                {
                    if (indice < jugadores.Length && Form3Instance != null)
                    {
                        Jugador jugador = new Jugador(nombreTextBox.Text, emailTextBox.Text, dulcesFavoritosTextBox.Text, regaloIdealTextBox.Text);
                        jugadores[indice] = jugador;
                        ((Form1)Form3Instance).AgregarJugador(jugador); // Pasar el jugador a Form1
                        LimpiarCampos();
                        indice++;

                        AmigoSecreto amigoSecreto = new AmigoSecreto(cantidadDeJugadores, fechaInicio, fechaFin, numeroDeEndulzadas,
                                             frecuenciaDeEndulzadasEnDias, valorDeLaEndulzada, valorDelRegalo, jugadores);

                        if (indice == jugadores.Length)
                        {
                            MessageBox.Show("Se han ingresado todos los jugadores.");
                            ((Form1)Form3Instance).AgregarJugador(jugador); // Pasar el último jugador a Form1

                            Form3 form3 = new Form3();
                            form3.ImprimirInformacionJuego(amigoSecreto);
                            form3.Show();

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

        private void LimpiarCampos()
        {
            nombreTextBox.Text = "";
            emailTextBox.Text = "";
            dulcesFavoritosTextBox.Text = "";
            regaloIdealTextBox.Text = "";
        }
    }
}