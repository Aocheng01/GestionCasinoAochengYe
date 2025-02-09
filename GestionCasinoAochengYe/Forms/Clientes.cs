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
using GestionCasinoAochengYe.dto;
using GestionCasinoAochengYe.dao;

namespace GestionCasinoAochengYe.Forms
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();

            DaoCliente daoCliente = new DaoCliente();
            List<Cliente> listaClientes = daoCliente.ObtenerClientes();

            dataGridViewClientes.DataSource = listaClientes;
            dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Form editarCliente = new EditarClientes();
            editarCliente.ShowDialog();
        }

        private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegúrate de que el clic se hace en una fila válida
            {
                DataGridViewRow filaSeleccionada = dataGridViewClientes.Rows[e.RowIndex];

                txtBoxId.Text = filaSeleccionada.Cells[0].Value?.ToString() ?? string.Empty;
               
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarClientes editarCliente = new EditarClientes();

            editarCliente.ShowDialog();
        }
    }
}
