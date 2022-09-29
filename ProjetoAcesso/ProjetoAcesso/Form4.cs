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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtEnd.Text = "";
            txtBairro.Text = "";
            txtcep.Text = "";
            txtEnd.Text = "";
            cmbEstado.SelectedItem = null;
        }
    }
}
