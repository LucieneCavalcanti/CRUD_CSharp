using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;

namespace ProjetoTelaComBancoV1
{
    public partial class Form1 : Form
    {
        MySqlConnection conexao;
        string acao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            btNovo.Enabled = false;
            btSalvar.Enabled = true;
            btCancelar.Enabled = true;
            acao = "novo";
        }
        private void habilitarCampos()
        {
            nome.Enabled = true;
            email.Enabled = true;
            escola.Enabled = true;
            anoEscolar.Enabled = true;
            turma.Enabled = true;
        }
        private void desabilitarCampos()
        {
            nome.Enabled = false;
            email.Enabled = false;
            escola.Enabled = false;
            anoEscolar.Enabled = false;
            turma.Enabled = false;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            desabilitarCampos();
            limparCampos();
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
            btNovo.Enabled = true;
            btEditar.Enabled = false;
            btExcluir.Enabled = false;
        }
        private void limparCampos()
        {
            id.Text = string.Empty;
            nome.Text = "";
            email.Text = string.Empty;
            escola.Text = string.Empty;
            anoEscolar.Text = string.Empty;
            turma.Text = string.Empty;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand("");
            if (validarCampos())
            {
                if (acao == "novo")
                {
                    comando = new MySqlCommand(
                        "insert into tbalunos (nome,email,escola,anoEscolar,turma)" +
                        " values ('" + nome.Text + "','" + email.Text + "','" + escola.Text + "','" +
                        anoEscolar.Text + "','" + turma.Text + "')", conexao);
                }
                if (acao == "editar")
                {
                    comando = new MySqlCommand(
                        "update tbalunos set nome='" + nome.Text + "',email='" + email.Text +
                        "',escola='" + escola.Text + "',anoEscolar='" + anoEscolar.Text +
                        "',turma='" + turma.Text + "' where id = " + id.Text, conexao);
                }
                var dados = comando.ExecuteReader();
                dados.Close();
                comando = null;
                MessageBox.Show("Salvo com sucesso!");
                desabilitarCampos();
                limparCampos();
                btNovo.Enabled = true;
                btSalvar.Enabled = false;
                btCancelar.Enabled = false;
                btEditar.Enabled = false;
                btExcluir.Enabled = false;
                btListar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Preencha corretamente os campos:" + mensagem);
            }
        }
        string mensagem = string.Empty;
        private bool validarCampos()
        {
            mensagem = "";
            if (nome.Text.Length < 3)
                mensagem += "\nDigite o campo nome.";
            if (email.Text.Length < 10 || !email.Text.Contains("@")
                    || !email.Text.Contains("."))
                mensagem += "\nO e-mail deve conter @ e .";
            if (escola.Text.Length < 5)
                mensagem += "\nO nome da escola deve " +
                    "ter pelo menos 5 caracteres";
            if (anoEscolar.Text.Length < 1)
                mensagem += "\nDigite o ano escolar.";
            if (turma.Text.Length < 1)
                mensagem += "\nDigite a turma.";
            if (mensagem.Length == 0)
                return true;
            else
                return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string strConexao = "server=localhost;" +
                    "user=root;" +
                    "database=bdPOO";
                conexao = new MySqlConnection(strConexao);
                conexao.Open();
                MessageBox.Show("Conectado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            /*finally 
            { 
                conexao.Close();
                MessageBox.Show("Conexão fechada!");
            }*/
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string txtid = id.Text;
                var comando = new MySqlCommand(
                    "select * from tbalunos where id=" + txtid,
                    conexao);
                var dados = comando.ExecuteReader();
                if (dados.Read())
                {
                    //MessageBox.Show($"{dados["id"]} -- {dados["nome"]}");
                    nome.Text = $"{dados["nome"]}";
                    email.Text = $"{dados["email"]}";
                    escola.Text = $"{dados["escola"]}";
                    anoEscolar.Text = $"{dados["anoEscolar"]}";
                    turma.Text = $"{dados["turma"]}";
                }
                else
                {
                    limparCampos();
                    MessageBox.Show("Não encontrado!");
                }
                dados.Close();
                comando = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            try
            {
                listagem.Columns.Clear();
                listagem.GridLines = true;
                listagem.View = View.Details;
                listagem.AllowColumnReorder = true;
                listagem.FullRowSelect = true;
                listagem.Columns.Add("Id", 30, HorizontalAlignment.Left);
                listagem.Columns.Add("Nome", 100, HorizontalAlignment.Left);
                listagem.Columns.Add("Email", 100, HorizontalAlignment.Left);
                listagem.Columns.Add("Escola", 100, HorizontalAlignment.Left);
                listagem.Columns.Add("Ano escolar", 100, HorizontalAlignment.Left);
                listagem.Columns.Add("Turma", 100, HorizontalAlignment.Left);
                string sql = "SELECT * FROM tbalunos order by nome";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);


                // Estruturar os dados recebidos do mysql e mostrar ao usuário
                // reader = leitor
                MySqlDataReader dados = cmd.ExecuteReader();

                listagem.Items.Clear();

                while (dados.Read())
                {
                    string[] linha = { dados.GetString(0), //pega a id
                                   dados.GetString(1), // pega o nome
                                   dados.GetString(2), // pega o email
                                   dados.GetString(3), // pega o telefone
                                   dados.GetString(4),
                                   dados.GetString(5)};

                    ListViewItem estrutura_da_linha = new ListViewItem(linha);

                    listagem.Items.Add(estrutura_da_linha);
                }
                dados.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deu errado, erro: " + ex.Message);
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                listagem.Columns.Clear();
                listagem.GridLines = true;
                listagem.View = View.Details;
                listagem.AllowColumnReorder = true;
                listagem.FullRowSelect = true;
                listagem.Columns.Add("Id", 30, HorizontalAlignment.Left);
                listagem.Columns.Add("Nome", 100, HorizontalAlignment.Left);
                listagem.Columns.Add("Email", 100, HorizontalAlignment.Left);
                listagem.Columns.Add("Escola", 100, HorizontalAlignment.Left);
                listagem.Columns.Add("Ano escolar", 100, HorizontalAlignment.Left);
                listagem.Columns.Add("Turma", 100, HorizontalAlignment.Left);
                string sql = "SELECT * FROM tbalunos where nome like '" + pesquisa.Text + "%' order by nome";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);


                // Estruturar os dados recebidos do mysql e mostrar ao usuário
                // reader = leitor
                MySqlDataReader dados = cmd.ExecuteReader();

                listagem.Items.Clear();

                while (dados.Read())
                {
                    string[] linha = { dados.GetString(0), //pega a id
                                   dados.GetString(1), // pega o nome
                                   dados.GetString(2), // pega o email
                                   dados.GetString(3), // pega o telefone
                                   dados.GetString(4),
                                   dados.GetString(5)};

                    ListViewItem estrutura_da_linha = new ListViewItem(linha);

                    listagem.Items.Add(estrutura_da_linha);
                }
                dados.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deu errado, erro: " + ex.Message);
            }
        }

        private void pesquisa_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void listagem_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                ListViewItem item = listagem.SelectedItems[0];
                id.Text = item.SubItems[0].Text;
                nome.Text = item.SubItems[1].Text;
                email.Text = item.SubItems[2].Text;
                escola.Text = item.SubItems[3].Text;
                anoEscolar.Text = item.SubItems[4].Text;
                turma.Text = item.SubItems[5].Text;
                btEditar.Enabled = true;
                btExcluir.Enabled = true;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Error: {erro.Message}");
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir?", "Confirmação", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                MySqlCommand comando = new MySqlCommand(
                    "delete from tbalunos where id = " + id.Text,
                    conexao);
                var dados = comando.ExecuteReader();
                dados.Close();
                comando = null;
                MessageBox.Show("Excluído com sucesso!");
                desabilitarCampos();
                limparCampos();
                btNovo.Enabled = true;
                btSalvar.Enabled = false;
                btCancelar.Enabled = false;
                btEditar.Enabled = false;
                btExcluir.Enabled = false;
                btListar_Click(sender, e);
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            id.Enabled = false;
            btNovo.Enabled = false;
            btSalvar.Enabled = true;
            btCancelar.Enabled = true;
            btEditar.Enabled = false;
            btExcluir.Enabled = false;
            acao = "editar";
        }
    }
}