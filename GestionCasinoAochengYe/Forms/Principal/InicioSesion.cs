using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GestionCasinoAochengYe.dao;
using GestionCasinoAochengYe.dto;
using BCrypt.Net;
using GestionCasinoAochengYe.Forms;
using System.Runtime.InteropServices;

namespace GestionCasinoAochengYe
{
    public partial class InicioSesion : Form
    {
        public event EventHandler iniciarSesion;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int
        wParam, int lParam);

        public static string usuarioActual {get; set; }

        public InicioSesion()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            DaoUsuario daoUsuario = new DaoUsuario();
            List<Usuario> listaUsuarios = daoUsuario.obtenerUsuarios();

            string username = txtBoxUsuario.Text;
            string password = txtBoxContraseña.Text; 

            // Buscar el usuario en la lista
            Usuario usuarioEncontrado = listaUsuarios.Find(usuario => usuario.nombre_usuario == username);

            if (usuarioEncontrado == null)
            {
                MessageBox.Show("El usuario no existe");
                return;
            }
            bool validPassword = BCrypt.Net.BCrypt.Verify(password, usuarioEncontrado.contraseña);
            if (!validPassword) { 
                MessageBox.Show("Contraseña incorrecta");
            }
            else if (validPassword && usuarioEncontrado.esAdministrador)
            {
                MessageBox.Show("Bienvenido administrador");
                usuarioActual = txtBoxUsuario.Text;
                Inicio inicio = new Inicio(true); // Muestra btnConfig
                inicio.Show();
                this.Hide();
            }
            else if (validPassword && !usuarioEncontrado.esAdministrador)
            {
                MessageBox.Show("Bienvenido usuario");
                usuarioActual = txtBoxUsuario.Text;
                Inicio inicio = new Inicio(false); // esconde btnConfig
                inicio.Show();

                this.Hide();

            }


        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState.Equals(FormWindowState.Minimized);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Estás seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void txtBoxContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Verifica si se presionó Enter
            {
                // Llama al evento del botón como si se hubiera hecho clic en él
                btnIniciarSesion.PerformClick(); 
            }
        }
    }
}
