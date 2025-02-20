using GestionCasinoAochengYe.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionCasinoAochengYe.dto;
using GestionCasinoAochengYe.dao;
using System.Runtime.InteropServices;

namespace GestionCasinoAochengYe.Forms
{

    public partial class EditarClientes : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int
        wParam, int lParam);

        // Propiedad para recibir el nombre del clientee
        public string id { get; set; }
        public string ClienteNombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string saldo { get; set; }


        public EditarClientes()
        {
            
            InitializeComponent();
            // Centramos el formulario segun el formulario padre
            this.StartPosition = FormStartPosition.CenterParent;
        }

        // Método para inicializar el formulario con los datos del cliente
        public void InicializarFormulario(string id, string nombreCliente, string apellido, string email, string telefono, string saldo)
        {
            this.id = id;
            this.ClienteNombre = nombreCliente;
            this.apellido = apellido;
            this.email = email;
            this.telefono = telefono;
            this.saldo = saldo;
        

        txtBoxNombre.Text = ClienteNombre; // Rellenamos el campo de texto
            txtBoxApellido.Text = apellido; // Rellenamos el campo de texto
            txtBoxEmail.Text = email; // Rellenamos el campo de texto
            txtBoxTelefono.Text = telefono; // Rellenamos el campo de texto
            txtBoxSaldo.Text = saldo; 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.id);
            // Aquí puedes guardar los cambios realizados en los datos del cliente
            DaoCliente daoCliente = new DaoCliente();
            Cliente clienteNuevo = new Cliente(id,txtBoxNombre.Text, txtBoxApellido.Text, txtBoxEmail.Text, txtBoxTelefono.Text, Convert.ToDouble(txtBoxSaldo.Text), InicioSesion.usuarioActual);
            daoCliente.ActualizarCliente(id,clienteNuevo);
            this.Close();

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

    }

}