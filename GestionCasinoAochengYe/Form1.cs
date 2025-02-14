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
    public partial class Form1 : Form
    {
        public event EventHandler iniciarSesion;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int
        wParam, int lParam);
        public Form1()
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

                Inicio inicio = new Inicio(true); // Muestra btnConfig
                inicio.Show();
                this.Hide();
            }
            else if (validPassword && !usuarioEncontrado.esAdministrador)
            {
                MessageBox.Show("Bienvenido usuario");

                Inicio inicio = new Inicio(false); // esconde btnConfig
                inicio.Show();

                this.Hide();

            }


        }
    }
}
