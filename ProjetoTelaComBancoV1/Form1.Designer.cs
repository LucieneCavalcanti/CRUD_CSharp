namespace ProjetoTelaComBancoV1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            id = new TextBox();
            label1 = new Label();
            label2 = new Label();
            nome = new TextBox();
            label3 = new Label();
            email = new TextBox();
            label4 = new Label();
            escola = new TextBox();
            btSalvar = new Button();
            btCancelar = new Button();
            btNovo = new Button();
            label5 = new Label();
            anoEscolar = new TextBox();
            label6 = new Label();
            turma = new TextBox();
            btPesquisar = new Button();
            listagem = new ListView();
            btListar = new Button();
            pesquisa = new TextBox();
            label7 = new Label();
            btExcluir = new Button();
            btEditar = new Button();
            SuspendLayout();
            // 
            // id
            // 
            id.Location = new Point(20, 39);
            id.Name = "id";
            id.Size = new Size(100, 23);
            id.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 21);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 1;
            label1.Text = "id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 75);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            // 
            // nome
            // 
            nome.Enabled = false;
            nome.Location = new Point(20, 93);
            nome.Name = "nome";
            nome.Size = new Size(333, 23);
            nome.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 131);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 5;
            label3.Text = "E-mail";
            // 
            // email
            // 
            email.Enabled = false;
            email.Location = new Point(20, 149);
            email.Name = "email";
            email.Size = new Size(333, 23);
            email.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 188);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 7;
            label4.Text = "Escola";
            // 
            // escola
            // 
            escola.Enabled = false;
            escola.Location = new Point(20, 206);
            escola.Name = "escola";
            escola.Size = new Size(333, 23);
            escola.TabIndex = 6;
            // 
            // btSalvar
            // 
            btSalvar.Enabled = false;
            btSalvar.Image = (Image)resources.GetObject("btSalvar.Image");
            btSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btSalvar.Location = new Point(140, 304);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(94, 46);
            btSalvar.TabIndex = 8;
            btSalvar.Text = "Salvar";
            btSalvar.TextAlign = ContentAlignment.MiddleRight;
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // btCancelar
            // 
            btCancelar.Enabled = false;
            btCancelar.Image = (Image)resources.GetObject("btCancelar.Image");
            btCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btCancelar.Location = new Point(259, 304);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(94, 46);
            btCancelar.TabIndex = 9;
            btCancelar.Text = "Cancelar";
            btCancelar.TextAlign = ContentAlignment.MiddleRight;
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // btNovo
            // 
            btNovo.Image = (Image)resources.GetObject("btNovo.Image");
            btNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btNovo.Location = new Point(12, 304);
            btNovo.Name = "btNovo";
            btNovo.Size = new Size(94, 46);
            btNovo.TabIndex = 10;
            btNovo.Text = "Novo";
            btNovo.TextAlign = ContentAlignment.MiddleRight;
            btNovo.UseVisualStyleBackColor = true;
            btNovo.Click += btNovo_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 244);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 12;
            label5.Text = "Ano Escolar";
            // 
            // anoEscolar
            // 
            anoEscolar.Enabled = false;
            anoEscolar.Location = new Point(20, 262);
            anoEscolar.Name = "anoEscolar";
            anoEscolar.Size = new Size(119, 23);
            anoEscolar.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(234, 244);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 14;
            label6.Text = "Turma";
            // 
            // turma
            // 
            turma.Enabled = false;
            turma.Location = new Point(234, 262);
            turma.Name = "turma";
            turma.Size = new Size(119, 23);
            turma.TabIndex = 13;
            // 
            // btPesquisar
            // 
            btPesquisar.Location = new Point(126, 34);
            btPesquisar.Name = "btPesquisar";
            btPesquisar.Size = new Size(91, 31);
            btPesquisar.TabIndex = 15;
            btPesquisar.Text = "Pesquisar Id";
            btPesquisar.UseVisualStyleBackColor = true;
            btPesquisar.Click += btPesquisar_Click;
            // 
            // listagem
            // 
            listagem.Location = new Point(371, 75);
            listagem.Name = "listagem";
            listagem.Size = new Size(451, 340);
            listagem.TabIndex = 16;
            listagem.UseCompatibleStateImageBehavior = false;
            listagem.MouseClick += listagem_MouseClick;
            // 
            // btListar
            // 
            btListar.Location = new Point(223, 34);
            btListar.Name = "btListar";
            btListar.Size = new Size(130, 31);
            btListar.TabIndex = 17;
            btListar.Text = "Listar Todos";
            btListar.UseVisualStyleBackColor = true;
            btListar.Click += btListar_Click;
            // 
            // pesquisa
            // 
            pesquisa.BackColor = Color.OldLace;
            pesquisa.ForeColor = Color.Blue;
            pesquisa.Location = new Point(487, 34);
            pesquisa.Name = "pesquisa";
            pesquisa.Size = new Size(335, 23);
            pesquisa.TabIndex = 18;
            pesquisa.KeyDown += pesquisa_KeyDown;
            pesquisa.KeyUp += textBox1_KeyUp;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.OldLace;
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(371, 37);
            label7.Name = "label7";
            label7.Size = new Size(110, 15);
            label7.TabIndex = 19;
            label7.Text = "Pesquisa por Nome";
            // 
            // btExcluir
            // 
            btExcluir.Enabled = false;
            btExcluir.Image = (Image)resources.GetObject("btExcluir.Image");
            btExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btExcluir.Location = new Point(184, 369);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(94, 46);
            btExcluir.TabIndex = 21;
            btExcluir.Text = "Excluir";
            btExcluir.TextAlign = ContentAlignment.MiddleRight;
            btExcluir.UseVisualStyleBackColor = true;
            btExcluir.Click += btExcluir_Click;
            // 
            // btEditar
            // 
            btEditar.Enabled = false;
            btEditar.Image = (Image)resources.GetObject("btEditar.Image");
            btEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btEditar.Location = new Point(65, 369);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(94, 46);
            btEditar.TabIndex = 20;
            btEditar.Text = "Editar";
            btEditar.TextAlign = ContentAlignment.MiddleRight;
            btEditar.UseVisualStyleBackColor = true;
            btEditar.Click += btEditar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 427);
            Controls.Add(btExcluir);
            Controls.Add(btEditar);
            Controls.Add(label7);
            Controls.Add(pesquisa);
            Controls.Add(btListar);
            Controls.Add(listagem);
            Controls.Add(btPesquisar);
            Controls.Add(label6);
            Controls.Add(turma);
            Controls.Add(label5);
            Controls.Add(anoEscolar);
            Controls.Add(btNovo);
            Controls.Add(btCancelar);
            Controls.Add(btSalvar);
            Controls.Add(label4);
            Controls.Add(escola);
            Controls.Add(label3);
            Controls.Add(email);
            Controls.Add(label2);
            Controls.Add(nome);
            Controls.Add(label1);
            Controls.Add(id);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Cadastro de Alunos";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox id;
        private Label label1;
        private Label label2;
        private TextBox nome;
        private Label label3;
        private TextBox email;
        private Label label4;
        private TextBox escola;
        private Button btSalvar;
        private Button btCancelar;
        private Button btNovo;
        private Label label5;
        private TextBox anoEscolar;
        private Label label6;
        private TextBox turma;
        private Button btPesquisar;
        private ListView listagem;
        private Button btListar;
        private TextBox pesquisa;
        private Label label7;
        private Button btExcluir;
        private Button btEditar;
    }
}