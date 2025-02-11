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
using GestionCasinoAochengYe.Forms.Partida;


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

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Form añadirPartida = new AñadirPartida();
            añadirPartida.ShowDialog();
            actualizarTabla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string id = dataGridViewPartidas.CurrentRow.Cells[1].Value.ToString();
            string fecha = dataGridViewPartidas.CurrentRow.Cells[2].Value.ToString();
            string apuesta = dataGridViewPartidas.CurrentRow.Cells[3].Value.ToString();
            string ganancia = dataGridViewPartidas.CurrentRow.Cells[4].Value.ToString();
            string juego = dataGridViewPartidas.CurrentRow.Cells[5].Value.ToString();

            EditarPartidas editarPartida = new EditarPartidas();
            editarPartida.InicializarFormulario(id, Convert.ToDateTime(fecha), Convert.ToDouble(apuesta), Convert.ToDouble(ganancia), juego);
            editarPartida.ShowDialog();
            actualizarTabla();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar esta partida?", "Eliminar partida", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtBoxIdNombre.Text);
                DaoPartida daoPartida = new DaoPartida();
                daoPartida.EliminarPartida(id);
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
            BuscarFilaEnDataGridView(textoBuscado);
        }

        private void BuscarFilaEnDataGridView(string textoBuscado)
        {
            // Limpiar selección previa
            dataGridViewPartidas.ClearSelection();

            foreach (DataGridViewRow row in dataGridViewPartidas.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null) // Evitar errores por valores nulos
                {
                    if (row.Cells[0].Value.ToString().Equals(textoBuscado, StringComparison.OrdinalIgnoreCase) ||
                        row.Cells[1].Value.ToString().Equals(textoBuscado, StringComparison.OrdinalIgnoreCase))
                    {
                        // Seleccionar la fila y hacer que se vea como si se hizo clic en ella
                        row.Selected = true;
                        dataGridViewPartidas.FirstDisplayedScrollingRowIndex = row.Index;
                        dataGridViewPartidas.CurrentCell = row.Cells[0]; // Establecer la celda actual para la fila seleccionada

                        return;
                    }
                }
            }

            MessageBox.Show("No se encontró ningún resultado.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridViewPartidas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegúrate de que el clic se hace en una fila válida
            {
                DataGridViewRow filaSeleccionada = dataGridViewPartidas.Rows[e.RowIndex];

                txtBoxIdNombre.Text = filaSeleccionada.Cells[0].Value?.ToString() ?? string.Empty;

            }
        }
    }
}
