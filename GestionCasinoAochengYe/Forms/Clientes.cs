using GestionCasinoAochengYe.dao;
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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();

            DaoUsuario daoUsuario = new DaoUsuario();
            List<usuarios> listaUsuarios = daoUsuario.obtenerUsuarios();

            dataGridViewClientes.DataSource = listaUsuarios;
            dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {

        }
    }
}
