using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCasinoAochengYe.dto
{
    internal class Partida
    {
        public int id_partida { get; set; }
        public int id_cliente { get; set; }
        public DateTime fecha { get; set; }
        public double apuesta { get; set; }
        public double ganancia { get; set; }
        public string juego { get; set; }
        public string usuarioModificacion { get; set; }

        public Partida(int id_cliente, DateTime fecha, double apuesta, double ganancia, string juego)
        {
            this.id_cliente = id_cliente;
            this.fecha = fecha;
            this.apuesta = apuesta;
            this.ganancia = ganancia;
            this.juego = juego;
        }

        public Partida(int id_partida, int id_cliente, DateTime fecha, double apuesta, double ganancia, string juego)
        {
            this.id_partida = id_partida;
            this.id_cliente = id_cliente;
            this.fecha = fecha;
            this.apuesta = apuesta;
            this.ganancia = ganancia;
            this.juego = juego;
        }

        public Partida(int id_partida, int id_cliente, DateTime fecha, double apuesta, double ganancia, string juego, string usuarioModificacion)
        {
            this.id_partida = id_partida;
            this.id_cliente = id_cliente;
            this.fecha = fecha;
            this.apuesta = apuesta;
            this.ganancia = ganancia;
            this.juego = juego;
            this.usuarioModificacion = usuarioModificacion;
        }

        public Partida()
        {
        }

    }
}
