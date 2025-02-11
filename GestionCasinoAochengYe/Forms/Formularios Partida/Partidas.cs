using GestionCasinoAochengYe.dao;
using GestionCasinoAochengYe.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionCasinoAochengYe.dto;
using System.Windows.Forms;


namespace GestionCasinoAochengYe.Forms
{
    public partial class Partidas : Form
    {
        public Partidas()
        {
            InitializeComponent();
            actualizarTabla();

        }

        private void actualizarTabla()
        {
            DaoPartida daoPartida = new DaoPartida();
            List<dto.Partida> listaPartidas = daoPartida.ObtenerPartidas();
            dataGridViewPartidas.DataSource = listaPartidas;
            dataGridViewPartidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

    }
}
