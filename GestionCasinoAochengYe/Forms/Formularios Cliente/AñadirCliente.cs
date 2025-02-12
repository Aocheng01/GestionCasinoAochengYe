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
            Cliente cliente = new Cliente();
            cliente.nombre = txtBoxNombre.Text;
            cliente.apellido = txtBoxApellido.Text;
            cliente.email = txtBoxEmail.Text;
            cliente.telefono = txtBoxTelefono.Text;
            cliente.saldo = Convert.ToDouble(txtBoxSaldo.Text);

            DaoCliente daoCliente = new DaoCliente();
            daoCliente.CrearCliente(cliente);

            this.Close();


        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
