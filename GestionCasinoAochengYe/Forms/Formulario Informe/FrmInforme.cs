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
    public partial class FrmInforme : Form
    {
        private MySqlConnection connection = new MySqlConnection("server=bbddaocheng.c8fzxpapf4ap.us-east-1.rds.amazonaws.com; database=casinoDI;user=admin;password=t71S9XMdc1kp29rwj8LB;");
        public FrmInforme()
        {
            InitializeComponent();
        }

        private void FrmInforme_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "GestionCasinoAochengYe.Informes.Clientes.rdlc";
            ReportDataSource rds = new ReportDataSource("Clientes", GetData());
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }


        private DataTable GetData()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT * FROM clientes";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return dt;
        }
    }
}
