using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labo3
{
    public class Jugador
    {
        internal Jugador AmigoSecreto;

        public string Nombre { get; set; }
        public string Email { get; set; }
        public string DulcesFavoritos { get; set; }
        public string RegaloIdeal { get; set; }

        public Jugador(string nombre, string email, string dulcesFavoritos, string regaloIdeal)
        {
            Nombre = nombre;
            Email = email;
            DulcesFavoritos = dulcesFavoritos;
            RegaloIdeal = regaloIdeal;
        }

        // Agrega aquí cualquier otra lógica relacionada con la clase Jugador
    }
}