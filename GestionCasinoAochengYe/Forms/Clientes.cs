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
            Form añadirCliente = new AñadirCliente();
            añadirCliente.ShowDialog();
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
    
                // Obtiene el nombre del cliente de la fila seleccionada (suponiendo que el nombre está en la primera columna)
                string id = dataGridViewClientes.CurrentRow.Cells[0].Value.ToString(); 
                string nombreCliente = dataGridViewClientes.CurrentRow.Cells[1].Value.ToString(); 
                string apellidoCliente = dataGridViewClientes.CurrentRow.Cells[2].Value.ToString(); 
                string email = dataGridViewClientes.CurrentRow.Cells[3].Value.ToString(); 
                string telefono = dataGridViewClientes.CurrentRow.Cells[4].Value.ToString(); 
                string saldo = dataGridViewClientes.CurrentRow.Cells[5].Value.ToString(); 

            // Crea una instancia del formulario de edición
            EditarClientes editarCliente = new EditarClientes();

                // Pasa el nombre del cliente al formulario de edición
                editarCliente.InicializarFormulario(id, nombreCliente, apellidoCliente, email, telefono, saldo);

                // Muestra el formulario de manera modal
                editarCliente.ShowDialog();

        }
    }
}