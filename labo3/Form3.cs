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
    public partial class Form3 : Form
    {
        public void ImprimirInformacionJuego(AmigoSecreto amigoSecreto)
        {
            // Aquí puedes acceder a las propiedades de amigoSecreto para imprimir la información del juego
            Console.WriteLine("Información del juego:");
            Console.WriteLine($"Cantidad de jugadores: {amigoSecreto.CantidadDeJugadores}");
            Console.WriteLine($"Fecha de inicio: {amigoSecreto.FechaInicio}");
            Console.WriteLine($"Fecha de fin: {amigoSecreto.FechaFin}");
            // ... y así sucesivamente para otras propiedades relevantes

            // También puedes considerar la opción de mostrar esta información en algún control visual como un cuadro de texto o un control de cuadrícula si estás utilizando una aplicación de Windows Forms
        }

        private Jugador[] jugadores;
        private int indice = 0;

        public Form3()
        {
            InitializeComponent();
            jugadores = new Jugador[10]; // Por ejemplo, inicializamos el vector con tamaño 10
            InitializeDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InitializeDataGridView()
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Nombre";
            dataGridView1.Columns[1].Name = "Correo electrónico";
            dataGridView1.Columns[2].Name = "Dulces favoritos";
            dataGridView1.Columns[3].Name = "Regalo ideal";
        }

        public void AgregarJugador(Jugador jugador)
        {
            if (indice < jugadores.Length)
            {
                jugadores[indice] = jugador;
                string[] row = { jugador.Nombre, jugador.Email, jugador.DulcesFavoritos, jugador.RegaloIdeal };
                dataGridView1.Rows.Add(row);
                indice++;
            }
            else
            {
                MessageBox.Show("Se ha alcanzado el límite de jugadores.");
            }
        }

        
    }
}