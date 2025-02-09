using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCasinoAochengYe.Forms
{
    public partial class EditarClientes : Form
    {
        public EditarClientes()
        {
            InitializeComponent();
            txtBoxNombre.Text = Clientes.dataGridViewClientes.CurrentRow.Cells[0].Value.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
