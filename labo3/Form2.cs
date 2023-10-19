using System;
using System.Windows.Forms;

namespace labo3
{
    public partial class Form2 : Form
    {
        public Jugador[] jugadores;
        private int indice = 0;
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

        private void button1_Click(object sender, EventArgs e)
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

                        if (indice == jugadores.Length)
                        {
                            MessageBox.Show("Se han ingresado todos los jugadores.");
                            ((Form1)Form3Instance).AgregarJugador(jugador); // Pasar el último jugador a Form1
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