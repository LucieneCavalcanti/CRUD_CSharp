using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTelaComBancoV1
{
    public partial class JanelaPrincipal : Form
    {
        public JanelaPrincipal()
        {
            InitializeComponent();
          
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void aulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CadAula().Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void JanelaPrincipal_Load(object sender, EventArgs e)
        {

     
        }
    }
}
