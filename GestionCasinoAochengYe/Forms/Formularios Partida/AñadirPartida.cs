using GestionCasinoAochengYe.dao;
using GestionCasinoAochengYe.dto;
using MySql.Data.MySqlClient;
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

namespace GestionCasinoAochengYe.Forms.Partida
{
    public partial class AñadirPartida : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int
        wParam, int lParam);

        public AñadirPartida()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();

            string query = "SELECT id FROM clientes";
            Conexion objetoConexion = new Conexion();
            MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read())
            {
               comboBoxIdCliente.Items.Add(mySqlDataReader.GetInt32(0));
            }
            objetoConexion.cerrarConexion();
        }




        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dto.Partida partida = new dto.Partida
            (
                Convert.ToInt32(comboBoxIdCliente.SelectedItem),
                dateTimePickerFecha.Value,
                Convert.ToDouble(txtBoxApuesta.Text),
                Convert.ToDouble(txtBoxGanancia.Text),
                txtBoxJuego.Text,
                InicioSesion.usuarioActual
            );

            dao.DaoPartida daoPartida = new dao.DaoPartida();
            daoPartida.CrearPartida(partida);
            this.Close();
        }

        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
