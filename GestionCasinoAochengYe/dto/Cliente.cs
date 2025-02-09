using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCasinoAochengYe.dto
{
    internal class Cliente
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public double saldo { get; set; }

        public Cliente(string nombre, string apellido, string email, string telefono, double saldo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.telefono = telefono;
            this.saldo = saldo;
        }

        public Cliente(int id, string nombre, string apellido, string email, string telefono, double saldo)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.telefono = telefono;
            this.saldo = saldo;
        }
        public Cliente()
        {
        }


    }
}
