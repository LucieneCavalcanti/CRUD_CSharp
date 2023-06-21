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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjetoTelaComBancoV1
{
    public partial class CadAula : Form
    {
        MySqlConnection conexao;
        public CadAula()
        {
            InitializeComponent();
        }

        private void CadAula_Load(object sender, EventArgs e)
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
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            limparCampos();
            habilitarCampos();
            btNovo.Enabled = false;
            btSalvar.Enabled = true;
            btCancelar.Enabled = true;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarCampos())
                {
                    //salvar
                    MySqlCommand comando = new MySqlCommand(
                    "insert into tbaulas (descricao,anoEscolar,turma)" +
                    " values ('" + descricao.Text + "','" +
                    anoEscolar.Text + "','" + turma.Text + "')", conexao);
                    var dados = comando.ExecuteReader();
                    dados.Close();
                    comando = null;
                    MessageBox.Show("Salvo com sucesso!");
                    limparCampos();
                    desabilitarCampos();
                    btNovo.Enabled = true;
                    btSalvar.Enabled = false;
                    btCancelar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabilitarCampos();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string txtid = id.Text;
                var comando = new MySqlCommand(
                    "select * from tbaulas where id=" + txtid,
                    conexao);
                var dados = comando.ExecuteReader();
                if (dados.Read())
                {
                    //MessageBox.Show($"{dados["id"]} -- {dados["nome"]}");
                    descricao.Text = $"{dados["descricao"]}";
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
        public void habilitarCampos()
        {
            descricao.Enabled = true;
            anoEscolar.Enabled = true;
            turma.Enabled = true;
        }
        public void limparCampos()
        {
            id.Text = string.Empty;
            descricao.Text = string.Empty;
            anoEscolar.Text = string.Empty;
            turma.Text = string.Empty;
        }
        public void desabilitarCampos()
        {
            descricao.Enabled = false;
            anoEscolar.Enabled = false;
            turma.Enabled = false;
        }
        public bool validarCampos()
        {
            if (descricao.Text.Length < 10)
            {
                MessageBox.Show("Digite a descrição.");
                return false;
            }
            else
            {
                if (anoEscolar.Text.Length < 2)
                {
                    MessageBox.Show("Digite o ano escolar.");
                    return false;
                }
            }
            return true;
        }

        private void btListarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                listagem.Columns.Clear();
                listagem.GridLines = true;
                listagem.View = View.Details;
                listagem.AllowColumnReorder = true;
                listagem.FullRowSelect = true;
                listagem.Columns.Add("Id", 30, HorizontalAlignment.Left);
                listagem.Columns.Add("Descrição", 200, HorizontalAlignment.Left);
                listagem.Columns.Add("Ano escolar", 100, HorizontalAlignment.Left);
                listagem.Columns.Add("Turma", 100, HorizontalAlignment.Left);
                string sql = "SELECT * FROM tbaulas order by descricao";
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
                                   dados.GetString(3)};

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

        private void pesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                listagem.Columns.Clear();
                listagem.GridLines = true;
                listagem.View = View.Details;
                listagem.AllowColumnReorder = true;
                listagem.FullRowSelect = true;
                listagem.Columns.Add("Id", 30, HorizontalAlignment.Left);
                listagem.Columns.Add("Descrição", 200, HorizontalAlignment.Left);
                listagem.Columns.Add("Ano escolar", 100, HorizontalAlignment.Left);
                listagem.Columns.Add("Turma", 100, HorizontalAlignment.Left);
                string sql = "SELECT * FROM tbaulas where descricao like '" + pesquisa.Text + "%'  order by descricao";
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
                                   dados.GetString(3)};

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
    }
}
