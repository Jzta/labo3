using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labo3
{
    public partial class Form1 : Form
    {
        private AmigoSecreto amigoSecreto;
        public Jugador[] jugador;


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


        private void CrearJuego_Click(object sender, EventArgs e)
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

                // Aquí deberías tener una lista de objetos Jugador que has creado según los datos ingresados en tu formulario.

                Jugador[] jugadores = new Jugador[cantidadDeJugadores];
                // Llena la lista de jugadores con los datos ingresados en el formulario

                amigoSecreto = new AmigoSecreto(cantidadDeJugadores, fechaInicio, fechaFin, numeroDeEndulzadas, frecuenciaDeEndulzadasEnDias, valorDeLaEndulzada, valorDelRegalo, jugadores);

                amigoSecreto.AsignarJugadores(cantidadDeJugadores);
                amigoSecreto.AsignarAmigosSecretos();
                amigoSecreto.ImprimirInformacionDelJuego();
                amigoSecreto.ImprimirGustosDeJugadores();
                amigoSecreto.CalcularProximaEndulzada(DateTime.Now);



                for (int i = 0; i < cantidadDeJugadores; i++)
                {
                    Form2 form2 = new Form2();
                    form2.ShowDialog();

                    // Aquí puedes acceder a los datos del jugador ingresados en Form2 y hacer lo que necesites con esos datos
                    if (form2.jugador != null) // Utilizar 'jugador' en lugar de 'jugadores'
                    {
                        jugador[i] = form2.jugador;
                        Console.WriteLine($"Datos del jugador {i + 1}:");
                        Console.WriteLine($"Nombre: {jugador[i].Nombre}");
                        Console.WriteLine($"Email: {jugador[i].Email}");
                        Console.WriteLine($"Dulces favoritos: {jugador[i].DulcesFavoritos}");
                        Console.WriteLine($"Regalo ideal: {jugador[i].RegaloIdeal}");
                        Console.WriteLine();
                        // Puedes realizar más operaciones con los datos del jugador según sea necesario
                    }
                }
            }
        }
    }
}
