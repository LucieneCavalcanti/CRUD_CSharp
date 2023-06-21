namespace ProjetoTelaComBancoV1
{
    partial class CadAula
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadAula));
            btPesquisar = new Button();
            label6 = new Label();
            turma = new TextBox();
            label5 = new Label();
            anoEscolar = new TextBox();
            btNovo = new Button();
            btCancelar = new Button();
            btSalvar = new Button();
            label2 = new Label();
            descricao = new TextBox();
            label1 = new Label();
            id = new TextBox();
            listagem = new ListView();
            pesquisa = new TextBox();
            label3 = new Label();
            btListarTodos = new Button();
            btExcluir = new Button();
            btEditar = new Button();
            SuspendLayout();
            // 
            // btPesquisar
            // 
            btPesquisar.Location = new Point(133, 32);
            btPesquisar.Name = "btPesquisar";
            btPesquisar.Size = new Size(116, 31);
            btPesquisar.TabIndex = 31;
            btPesquisar.Text = "Pesquisar Id";
            btPesquisar.UseVisualStyleBackColor = true;
            btPesquisar.Click += btPesquisar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(241, 131);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 30;
            label6.Text = "Turma";
            // 
            // turma
            // 
            turma.Enabled = false;
            turma.Location = new Point(241, 149);
            turma.Name = "turma";
            turma.Size = new Size(119, 23);
            turma.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 131);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 28;
            label5.Text = "Ano Escolar";
            // 
            // anoEscolar
            // 
            anoEscolar.Enabled = false;
            anoEscolar.Location = new Point(27, 149);
            anoEscolar.Name = "anoEscolar";
            anoEscolar.Size = new Size(119, 23);
            anoEscolar.TabIndex = 27;
            // 
            // btNovo
            // 
            btNovo.Location = new Point(26, 195);
            btNovo.Name = "btNovo";
            btNovo.Size = new Size(89, 42);
            btNovo.TabIndex = 26;
            btNovo.Text = "Novo";
            btNovo.UseVisualStyleBackColor = true;
            btNovo.Click += btNovo_Click;
            // 
            // btCancelar
            // 
            btCancelar.Enabled = false;
            btCancelar.Location = new Point(271, 195);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(89, 42);
            btCancelar.TabIndex = 25;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // btSalvar
            // 
            btSalvar.Enabled = false;
            btSalvar.Location = new Point(147, 195);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(89, 42);
            btSalvar.TabIndex = 24;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 76);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 19;
            label2.Text = "Descrição";
            // 
            // descricao
            // 
            descricao.Enabled = false;
            descricao.Location = new Point(27, 94);
            descricao.Name = "descricao";
            descricao.Size = new Size(333, 23);
            descricao.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 22);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 17;
            label1.Text = "id";
            // 
            // id
            // 
            id.Location = new Point(27, 40);
            id.Name = "id";
            id.Size = new Size(100, 23);
            id.TabIndex = 16;
            // 
            // listagem
            // 
            listagem.Location = new Point(412, 76);
            listagem.Name = "listagem";
            listagem.Size = new Size(438, 215);
            listagem.TabIndex = 32;
            listagem.UseCompatibleStateImageBehavior = false;
            // 
            // pesquisa
            // 
            pesquisa.Location = new Point(546, 36);
            pesquisa.Name = "pesquisa";
            pesquisa.Size = new Size(304, 23);
            pesquisa.TabIndex = 33;
            pesquisa.KeyUp += pesquisa_KeyUp;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(412, 39);
            label3.Name = "label3";
            label3.Size = new Size(128, 15);
            label3.TabIndex = 34;
            label3.Text = "Pesquisa por Descrição";
            // 
            // btListarTodos
            // 
            btListarTodos.Location = new Point(255, 32);
            btListarTodos.Name = "btListarTodos";
            btListarTodos.Size = new Size(128, 31);
            btListarTodos.TabIndex = 35;
            btListarTodos.Text = "Listar Todos";
            btListarTodos.UseVisualStyleBackColor = true;
            btListarTodos.Click += btListarTodos_Click;
            // 
            // btExcluir
            // 
            btExcluir.Enabled = false;
            btExcluir.Location = new Point(189, 243);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(94, 48);
            btExcluir.TabIndex = 37;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = true;
            // 
            // btEditar
            // 
            btEditar.Enabled = false;
            btEditar.Location = new Point(70, 243);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(94, 48);
            btEditar.TabIndex = 36;
            btEditar.Text = "Editar";
            btEditar.UseVisualStyleBackColor = true;
            // 
            // CadAula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 314);
            Controls.Add(btExcluir);
            Controls.Add(btEditar);
            Controls.Add(btListarTodos);
            Controls.Add(label3);
            Controls.Add(pesquisa);
            Controls.Add(listagem);
            Controls.Add(btPesquisar);
            Controls.Add(label6);
            Controls.Add(turma);
            Controls.Add(label5);
            Controls.Add(anoEscolar);
            Controls.Add(btNovo);
            Controls.Add(btCancelar);
            Controls.Add(btSalvar);
            Controls.Add(label2);
            Controls.Add(descricao);
            Controls.Add(label1);
            Controls.Add(id);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CadAula";
            Text = "CadAula";
            Load += CadAula_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btPesquisar;
        private Label label6;
        private TextBox turma;
        private Label label5;
        private TextBox anoEscolar;
        private Button btNovo;
        private Button btCancelar;
        private Button btSalvar;
        private Label label2;
        private TextBox descricao;
        private Label label1;
        private TextBox id;
        private ListView listagem;
        private TextBox pesquisa;
        private Label label3;
        private Button btListarTodos;
        private Button btExcluir;
        private Button btEditar;
    }
}