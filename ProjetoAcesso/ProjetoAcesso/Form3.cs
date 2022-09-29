using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAcesso
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void lblpesquisa_Click(object sender, EventArgs e)
        {

        }

        private void btnSeguir_Click(object sender, EventArgs e)
        {
            Form4 Prosseguir = new Form4();
            Prosseguir.Show();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtNome.Text = "";
            txtPro.Text = "";
            RbFem.Checked = false;
            rbMasc.Checked = false;
            cmbdIA.SelectedItem = null;
            cmbMes.SelectedItem = null;
            cmbAno.SelectedItem = null;


        }
    }
}
