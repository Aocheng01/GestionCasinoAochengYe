﻿using GestionCasinoAochengYe.dao;
using GestionCasinoAochengYe.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCasinoAochengYe.Forms
{
    public partial class Partidas : Form
    {
        public Partidas()
        {
            InitializeComponent();

            DaoPartida daoPartida = new DaoPartida();
            List<Partida> listaPartidas = daoPartida.ObtenerPartidas();
            dataGridViewPartidas.DataSource = listaPartidas;
            dataGridViewPartidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
    }
}
