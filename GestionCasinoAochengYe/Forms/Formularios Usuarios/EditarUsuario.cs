using GestionCasinoAochengYe.dao;
using GestionCasinoAochengYe.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCasinoAochengYe.Forms.Formularios_Usuarios
{
    public partial class EditarUsuario : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int
        wParam, int lParam);

        public string id { get; set; }
        public string nombre { get; set; }
        public string contraseña { get; set; }
        public bool admin { get; set; }

        public EditarUsuario()
        {
            this.StartPosition= FormStartPosition.CenterParent;
            InitializeComponent();
        }

        public void InicializarFormulario(string id, string nombre, string contraseña, bool admin)
        {
            this.id= id;
            this.nombre = nombre;
            this.contraseña = contraseña;
            this.admin = admin;

            txtBoxUsuario.Text = nombre;
            checkBoxAdmin.Checked = admin;
        }
        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que el nombre de usuario y la contraseña no estén vacíos
            if (string.IsNullOrWhiteSpace(txtBoxUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtBoxContraseña.Text) ||
                string.IsNullOrWhiteSpace(txtBoxRepetirContraseña.Text))
            {
                MessageBox.Show("El usuario y la contraseña son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que las contraseñas coincidan
            if (txtBoxContraseña.Text != txtBoxRepetirContraseña.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(this.id);
            DaoUsuario daoUsuario = new DaoUsuario();

            // Obtener la fecha de creación original del usuario
            DateTime fechaCreacion = daoUsuario.ObtenerFechaCreacion(id);

            Usuario usuarioNuevo = new Usuario(id, txtBoxUsuario.Text, txtBoxContraseña.Text, checkBoxAdmin.Checked, fechaCreacion, InicioSesion.usuarioActual);
            daoUsuario.ActualizarUsuario(usuarioNuevo);
            this.Close();
        }


    }
}
