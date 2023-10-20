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
        private Jugador[] jugadores;
        private int indice = 0;

        public Form3()
        {
            InitializeComponent();
            jugadores = new Jugador[10]; // Inicializa el vector con un tamaño de 10
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

        // Método para imprimir la información del juego en el Form3
        public void ImprimirInformacionJuego()
        {
            // Implementa la lógica para imprimir la información del juego aquí
            MessageBox.Show("Imprimir información del juego aquí.");
        }
    }
}
