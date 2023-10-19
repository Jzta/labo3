using System;
using System.Windows.Forms;

namespace labo3
{
    public partial class Form2 : Form
    {
        private Jugador[] jugadores;
        private int indice = 0;
        public Jugador jugador;

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
                    if (indice < jugadores.Length)
                    {
                        Jugador jugador = new Jugador(nombreTextBox.Text, emailTextBox.Text, dulcesFavoritosTextBox.Text, regaloIdealTextBox.Text);
                        jugadores[indice] = jugador;
                        LimpiarCampos();
                        indice++;

                        if (indice == jugadores.Length)
                        {
                            MessageBox.Show("Se han ingresado todos los jugadores.");
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