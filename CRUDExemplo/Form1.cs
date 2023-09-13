namespace CRUDExemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            limparCampos();
            habilitarCampos();
            btNovo.Enabled = false;
            btCancelar.Enabled = true;
            btSalvar.Enabled = true;
        }
        private void limparCampos() //método
        {
            txtDescricao.Text = string.Empty;
            txtResponsavel.Text = "";
            txtCategoria.Text = string.Empty;
            txtStatus.Text = string.Empty;
            txtDataInicial.Text = string.Empty;
            txtDataFinal.Text = string.Empty;
            txtObservacoes.Text = string.Empty;
        }
        private void habilitarCampos()
        {
            txtDescricao.Enabled = true;
            txtResponsavel.Enabled = true;
            txtCategoria.Enabled = true;
            txtStatus.Enabled = true;
            txtDataInicial.Enabled = true;
            txtDataFinal.Enabled = true;
            txtObservacoes.Enabled = true;
        }
        private void desabilitarCampos()
        {
            txtDescricao.Enabled = false;
            txtResponsavel.Enabled = false;
            txtCategoria.Enabled = false;
            txtStatus.Enabled = false;
            txtDataInicial.Enabled = false;
            txtDataFinal.Enabled = false;
            txtObservacoes.Enabled = false;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabilitarCampos();
            btNovo.Enabled = true;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if(txtDescricao.Text.Length < 5)
            {
                MessageBox.Show("O campo descrição deve conter pelo menos 5 caracteres.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (txtDataInicial.Text.Length < 10)
            {
                MessageBox.Show("O campo data inicial não pode ser vazio.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //pode gravar
            {
                MessageBox.Show("Tarefa salva com sucesso!","Salvar",MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);
                limparCampos();
                desabilitarCampos();
                btNovo.Enabled=true;
                btSalvar.Enabled=false;
                btCancelar.Enabled=false;
            }
        }
    }
}