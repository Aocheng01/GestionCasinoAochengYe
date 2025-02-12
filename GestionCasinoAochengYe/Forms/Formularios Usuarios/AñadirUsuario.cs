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
using System.Windows.Forms;

namespace GestionCasinoAochengYe.Forms.Formularios_Usuarios
{
    public partial class AñadirUsuario : Form
    {
        public AñadirUsuario()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
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
