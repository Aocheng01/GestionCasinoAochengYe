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
using GestionCasinoAochengYe.dao;
using GestionCasinoAochengYe.dto;

namespace GestionCasinoAochengYe.Forms
{
    public partial class EditarPartidas : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int
        wParam, int lParam);

        public string id { get; set; }
        public DateTime fecha { get; set; }
        public double apuesta { get; set; }
        public double ganancia { get; set; }
        public string juego { get; set; }


        public EditarPartidas()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
        }

        public void InicializarFormulario(string id, DateTime fecha, double apuesta, double ganancia, string juego) 
        {
            this.id = id;
            this.fecha = fecha;
            this.apuesta = apuesta;
            this.ganancia = ganancia;
            this.juego = juego;

            dateTimePickerFecha.Value = fecha;
            txtBoxApuesta.Text = apuesta.ToString();
            txtBoxGanancia.Text = ganancia.ToString();
            txtBoxJuego.Text = juego;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.id);
            DaoPartida daoPartida = new DaoPartida();
            dto.Partida partidaNueva = new dto.Partida(id, dateTimePickerFecha.Value, Convert.ToDouble(txtBoxApuesta.Text), Convert.ToDouble(txtBoxGanancia.Text), txtBoxJuego.Text, InicioSesion.usuarioActual);
            daoPartida.ActualizarPartida(id,partidaNueva);
            this.Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
