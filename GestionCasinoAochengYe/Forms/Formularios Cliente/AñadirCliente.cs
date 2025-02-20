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
using GestionCasinoAochengYe.dto;
using GestionCasinoAochengYe.dao;

namespace GestionCasinoAochengYe.Forms
{
    public partial class AñadirCliente : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int
        wParam, int lParam);

        public AñadirCliente()
        {
            InitializeComponent();
            this.StartPosition= FormStartPosition.CenterParent;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verificar que ningún campo esté vacío
            if (string.IsNullOrWhiteSpace(txtBoxNombre.Text) ||
                string.IsNullOrWhiteSpace(txtBoxApellido.Text) ||
                string.IsNullOrWhiteSpace(txtBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(txtBoxTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtBoxSaldo.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detiene la ejecución si hay campos vacíos
            }

            // Validar que el saldo sea un número válido
            double saldo;
            if (!double.TryParse(txtBoxSaldo.Text, out saldo))
            {
                MessageBox.Show("El saldo debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detiene la ejecución si el saldo no es un número
            }

            Cliente cliente = new Cliente
            {
                nombre = txtBoxNombre.Text,
                apellido = txtBoxApellido.Text,
                email = txtBoxEmail.Text,
                telefono = txtBoxTelefono.Text,
                saldo = saldo,
                usuarioModificacion = InicioSesion.usuarioActual
            };

            DaoCliente daoCliente = new DaoCliente();
            daoCliente.CrearCliente(cliente);

            this.Close(); // Cierra el formulario solo si todo es correcto
        }


        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
