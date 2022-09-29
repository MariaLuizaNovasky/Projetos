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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblacesso_Click(object sender, EventArgs e)
        {

        }

        private void btnEsqueci_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            Form3 Cadastro = new Form3();
            Cadastro.Show();
        }
    }
}
