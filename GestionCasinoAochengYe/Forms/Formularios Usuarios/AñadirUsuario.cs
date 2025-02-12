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
    public partial class AñadirUsuario : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int
        wParam, int lParam);
        public AñadirUsuario()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
        }
        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string username = txtBoxUsuario.Text;
            string password = txtBoxContraseña.Text;
            string confirmPassword = txtBoxRepetirContraseña.Text;
            bool admin = checkBoxAdmin.Checked;
            //comprobar que el usuario no exista
            DaoUsuario daoUsuario = new DaoUsuario();
            if (daoUsuario.ExisteUsuario(username))
            {
                MessageBox.Show("El usuario ya existe.");
                return;
            }

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Por favor, ingresa un usuario y una contraseña.");
                return;
            }else if (password != confirmPassword)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            // Crear una instancia del usuario con la contraseña hasheada
            //string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            //Usuario nuevoUsuario = new Usuario(username, hashedPassword, false, DateTime.Now);

            Usuario nuevoUsuario = new Usuario(username, password, admin, DateTime.Now);
            daoUsuario.CrearUsuario(nuevoUsuario);

            MessageBox.Show("Usuario creado exitosamente.");
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
    }
}
