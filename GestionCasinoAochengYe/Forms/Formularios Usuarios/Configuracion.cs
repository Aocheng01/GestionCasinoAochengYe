using GestionCasinoAochengYe.dao;
using GestionCasinoAochengYe.dto;
using GestionCasinoAochengYe.Forms.Partida;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionCasinoAochengYe.dao;
using GestionCasinoAochengYe.dto;
using GestionCasinoAochengYe.Forms.Formularios_Usuarios;
using System.Runtime.InteropServices;

namespace GestionCasinoAochengYe.Forms
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
            actualizarTabla();

        }

        private void actualizarTabla()
        {
            DaoUsuario daoUsuario = new DaoUsuario();
            List<Usuario> listaUsuarios = daoUsuario.obtenerUsuarios();
            dataGridViewUsuarios.DataSource = listaUsuarios;
            dataGridViewUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Form añadirUsuario = new AñadirUsuario();
            añadirUsuario.ShowDialog();
            actualizarTabla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string id = dataGridViewUsuarios.CurrentRow.Cells[0].Value.ToString();
            string nombre = dataGridViewUsuarios.CurrentRow.Cells[1].Value.ToString();
            string contraseña = dataGridViewUsuarios.CurrentRow.Cells[2].Value.ToString();
            bool admin = dataGridViewUsuarios.CurrentRow.Cells[3].Value.ToString() == "True";

            EditarUsuario editarUsuario = new EditarUsuario();
            editarUsuario.InicializarFormulario(id, nombre, contraseña, admin);

            editarUsuario.ShowDialog();
            actualizarTabla();
            


        }

        private void BuscarFilaEnDataGridView(string textoBuscado)
        {
            // Limpiar selección previa
            dataGridViewUsuarios.ClearSelection();

            foreach (DataGridViewRow row in dataGridViewUsuarios.Rows)
            {
                if (row.Cells[0].Value != null) // Evitar errores si la celda está vacía
                {
                    if (row.Cells[0].Value.ToString().Equals(textoBuscado, StringComparison.OrdinalIgnoreCase))
                    {
                        // Seleccionar la fila y hacer que se vea como si se hizo clic en ella
                        row.Selected = true;
                        dataGridViewUsuarios.FirstDisplayedScrollingRowIndex = row.Index;
                        dataGridViewUsuarios.CurrentCell = row.Cells[0]; // Establecer la celda actual para la fila seleccionada

                        return;
                    }
                }
            }
        }

        private void dataGridViewUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegúrate de que el clic se hace en una fila válida
            {
                DataGridViewRow filaSeleccionada = dataGridViewUsuarios.Rows[e.RowIndex];

                txtBoxId.Text = filaSeleccionada.Cells[0].Value?.ToString() ?? string.Empty;

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DaoUsuario daoUsuario = new DaoUsuario();
            int idUsuarioActual = daoUsuario.ObtenerId(InicioSesion.usuarioActual);
            int id = Convert.ToInt32(txtBoxId.Text);
            if (idUsuarioActual == id) { 
                MessageBox.Show("No puedes eliminar tu propio usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(Text = "¿Estás seguro de que quieres eliminar este usuario?", "Eliminar usuario", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                daoUsuario.EliminarUsuario(id);
                actualizarTabla();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string textoBuscado = txtBoxId.Text.Trim(); // Obtener el texto del TextBox y quitar espacios

            if (string.IsNullOrEmpty(textoBuscado))
            {
                MessageBox.Show("Por favor, ingrese un ID o Nombre para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BuscarFilaEnDataGridView(textoBuscado);
        }
    }
}
