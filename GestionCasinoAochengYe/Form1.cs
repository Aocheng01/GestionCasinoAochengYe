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
        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            string username = txtBoxUsuario.Text;
            string password = txtBoxContraseña.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, ingresa un usuario y una contraseña.");
                return;
            }

            // Crear una instancia del usuario con la contraseña hasheada
            //string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            //Usuario nuevoUsuario = new Usuario(username, hashedPassword, false, DateTime.Now);

            Usuario nuevoUsuario = new Usuario(username, password, true, DateTime.Now);
            DaoUsuario daoUsuario = new DaoUsuario();
            daoUsuario.CrearUsuario(nuevoUsuario);

            MessageBox.Show("Usuario creado exitosamente.");
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

            // Verificar la contraseña con BCrypt
            bool validPass = BCrypt.Net.BCrypt.Verify(password, usuarioEncontrado.contraseña);

            if (!validPass)
            {
                MessageBox.Show("Contraseña incorrecta");
                MessageBox.Show($"Contraseña ingresada: {password}\nContraseña almacenada: {usuarioEncontrado.contraseña}");

                return;
            }

            if (usuarioEncontrado.esAdministrador)
            {
                MessageBox.Show("Bienvenido administrador");
                iniciarSesion?.Invoke(this, EventArgs.Empty);

                Inicio inicio = new Inicio(true); // Muestra btnConfig
                inicio.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bienvenido usuario");
                iniciarSesion?.Invoke(this, EventArgs.Empty);
                Inicio inicio = new Inicio(false); // esconde btnConfig
                inicio.Show();

                this.Hide();

            }
        }
    }
}
