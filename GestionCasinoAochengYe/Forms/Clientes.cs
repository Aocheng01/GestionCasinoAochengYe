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

            actualizarTabla();
        }

        private void actualizarTabla()
        {
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
            actualizarTabla();
        }

        private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegúrate de que el clic se hace en una fila válida
            {
                DataGridViewRow filaSeleccionada = dataGridViewClientes.Rows[e.RowIndex];

                txtBoxIdNombre.Text = filaSeleccionada.Cells[0].Value?.ToString() ?? string.Empty;
               
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
            actualizarTabla();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este cliente?", "Eliminar cliente", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int idCliente = Convert.ToInt32(txtBoxIdNombre.Text);
                DaoCliente daoCliente = new DaoCliente();
                daoCliente.EliminarCliente(idCliente);
                actualizarTabla();
            }
          
            
          



        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string textoBuscado = txtBoxIdNombre.Text.Trim(); // Obtener el texto del TextBox y quitar espacios

            if (string.IsNullOrEmpty(textoBuscado))
            {
                MessageBox.Show("Por favor, ingrese un ID o Nombre para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in dataGridViewClientes.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null) // Evitar errores por valores nulos
                {
                    if (row.Cells[0].Value.ToString().Equals(textoBuscado, StringComparison.OrdinalIgnoreCase) ||
                        row.Cells[1].Value.ToString().Equals(textoBuscado, StringComparison.OrdinalIgnoreCase))
                    {
                        dataGridViewClientes.ClearSelection();
                        row.Selected = true;
                        dataGridViewClientes.FirstDisplayedScrollingRowIndex = row.Index;
                        return;
                    }
                }
            }

            MessageBox.Show("No se encontró ningún resultado.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}