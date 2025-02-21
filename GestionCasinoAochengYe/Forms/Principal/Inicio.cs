using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCasinoAochengYe.Forms
{
    public partial class Inicio : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int
        wParam, int lParam);

        public Inicio(bool mostrarConfig)
        {
            InitializeComponent();
            btnConfig.Visible = mostrarConfig;
            lblUsuarioActual.Text = InicioSesion.usuarioActual;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            InicioSesion form1 = new InicioSesion();
            form1.Show();
            this.Close();

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Clientes());
        }
        private void btnPartidas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Partidas());
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Configuracion());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Estás seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }



        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Formulario_Informe.FrmInformeDinamico());
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            string absolutePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Ayuda",
                "html",
                "index.html"
            );

            if (File.Exists(absolutePath))
            {
                Process.Start(absolutePath);
            }
            else
            {
                MessageBox.Show("El archivo no se encontró.");
            }

        }

        //private void btnAyuda_Click(object sender, EventArgs e)
        //{
        //    // Ruta relativa del archivo HTML
        //    string relativePath = @"../../Ayuda/html/index.html";

        //    // Convierte la ruta relativa en una ruta absoluta
        //    string absolutePath = Path.GetFullPath(relativePath);


        //    if (System.IO.File.Exists(absolutePath))
        //    {
        //        Process.Start(absolutePath);
        //    }
        //    else
        //    {
        //        MessageBox.Show("El archivo no se encontró.");
        //    }
        //}
    }
}
