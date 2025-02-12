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
            DialogResult result = MessageBox.Show(Text = "¿Estás seguro de que quieres eliminar este usuario?", "Eliminar usuario", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtBoxId.Text);
                DaoUsuario daoUsuario = new DaoUsuario();
                daoUsuario.EliminarUsuario(id);
                actualizarTabla();
            }
        }

    }
}
