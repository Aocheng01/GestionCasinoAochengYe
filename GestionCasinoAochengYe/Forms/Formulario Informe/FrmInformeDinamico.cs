using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCasinoAochengYe.Forms.Formulario_Informe
{
    public partial class FrmInformeDinamico : Form
    {
        public FrmInformeDinamico()
        {
            InitializeComponent();
        }

        // Conexión a la base de datos
        private MySqlConnection connection = new MySqlConnection("server=bbddaocheng.c8fzxpapf4ap.us-east-1.rds.amazonaws.com; database=casinoDI;user=admin;password=t71S9XMdc1kp29rwj8LB;");


        private void btnInformeClientes_Click(object sender, EventArgs e)
        {
            // Cambiar a otro informe con otra consulta
            CargarInforme("GestionCasinoAochengYe.Informes.Clientes.rdlc", "Clientes", "SELECT * FROM clientes");
        }

        private void btnInformePartidas_Click(object sender, EventArgs e)
        {
            // Cambiar a otro informe con otra consulta
            CargarInforme("GestionCasinoAochengYe.Informes.Partidas.rdlc", "Partidas", "SELECT * FROM partidas");
        }

        private void btnInformeUsuarios_Click(object sender, EventArgs e)
        {
            // Cambiar a otro informe con otra consulta
            CargarInforme("GestionCasinoAochengYe.Informes.Usuarios.rdlc", "Usuarios", "SELECT * FROM usuarios");
        }

        private void CargarInforme(string reportPath, string dataSourceName, string query)
        {
            try
            {
                reportViewer1.LocalReport.DataSources.Clear(); // Limpiar informes previos

                // Asignar nuevo informe
                reportViewer1.LocalReport.ReportEmbeddedResource = reportPath;

                // Obtener datos
                DataTable dt = GetData(query);
                if (dt.Rows.Count > 0)
                {
                    ReportDataSource rds = new ReportDataSource(dataSourceName, dt);
                    reportViewer1.LocalReport.DataSources.Add(rds);
                }
                else
                {
                    MessageBox.Show("No hay datos disponibles para este informe.");
                }

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el informe: " + ex.Message);
            }
        }

        private DataTable GetData(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                adapter.Fill(dt);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos: " + ex.Message);
            }
            return dt;
        }
    }
}

