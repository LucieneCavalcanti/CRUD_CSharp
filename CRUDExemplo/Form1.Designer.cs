namespace CRUDExemplo
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtDescricao = new TextBox();
            txtResponsavel = new TextBox();
            txtObservacoes = new RichTextBox();
            txtDataInicial = new DateTimePicker();
            txtDataFinal = new DateTimePicker();
            txtCategoria = new ComboBox();
            txtStatus = new ComboBox();
            label9 = new Label();
            btNovo = new Button();
            btSalvar = new Button();
            btCancelar = new Button();
            btEditar = new Button();
            btExcluir = new Button();
            label10 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 21);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 50);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Descrição";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 107);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 2;
            label3.Text = "Data Inicial";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(359, 107);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "Data Final";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 158);
            label5.Name = "label5";
            label5.Size = new Size(125, 15);
            label5.TabIndex = 4;
            label5.Text = "Nome do Responsável";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 211);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 5;
            label6.Text = "Categoria";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 261);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 6;
            label7.Text = "Status";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(358, 158);
            label8.Name = "label8";
            label8.Size = new Size(74, 15);
            label8.TabIndex = 7;
            label8.Text = "Observações";
            // 
            // txtDescricao
            // 
            txtDescricao.Enabled = false;
            txtDescricao.Location = new Point(22, 68);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(620, 23);
            txtDescricao.TabIndex = 8;
            // 
            // txtResponsavel
            // 
            txtResponsavel.Enabled = false;
            txtResponsavel.Location = new Point(21, 176);
            txtResponsavel.Name = "txtResponsavel";
            txtResponsavel.Size = new Size(301, 23);
            txtResponsavel.TabIndex = 9;
            // 
            // txtObservacoes
            // 
            txtObservacoes.Enabled = false;
            txtObservacoes.Location = new Point(358, 176);
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(283, 126);
            txtObservacoes.TabIndex = 10;
            txtObservacoes.Text = "";
            // 
            // txtDataInicial
            // 
            txtDataInicial.Enabled = false;
            txtDataInicial.Location = new Point(21, 125);
            txtDataInicial.Name = "txtDataInicial";
            txtDataInicial.Size = new Size(301, 23);
            txtDataInicial.TabIndex = 11;
            // 
            // txtDataFinal
            // 
            txtDataFinal.Enabled = false;
            txtDataFinal.Location = new Point(358, 125);
            txtDataFinal.Name = "txtDataFinal";
            txtDataFinal.Size = new Size(283, 23);
            txtDataFinal.TabIndex = 12;
            // 
            // txtCategoria
            // 
            txtCategoria.Enabled = false;
            txtCategoria.FormattingEnabled = true;
            txtCategoria.Items.AddRange(new object[] { "Doméstica", "Escola", "Pessoal", "Trabalho", "Lazer", "Viagem", "Outros" });
            txtCategoria.Location = new Point(21, 229);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(301, 23);
            txtCategoria.TabIndex = 13;
            // 
            // txtStatus
            // 
            txtStatus.Enabled = false;
            txtStatus.FormattingEnabled = true;
            txtStatus.Items.AddRange(new object[] { "Atrasada", "Cancelada", "Concluída", "Em andamento", "Nova" });
            txtStatus.Location = new Point(22, 279);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(300, 23);
            txtStatus.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(68, 21);
            label9.Name = "label9";
            label9.Size = new Size(13, 15);
            label9.TabIndex = 15;
            label9.Text = "0";
            // 
            // btNovo
            // 
            btNovo.Location = new Point(31, 346);
            btNovo.Name = "btNovo";
            btNovo.Size = new Size(115, 33);
            btNovo.TabIndex = 16;
            btNovo.Text = "Novo";
            btNovo.UseVisualStyleBackColor = true;
            btNovo.Click += btNovo_Click;
            // 
            // btSalvar
            // 
            btSalvar.Enabled = false;
            btSalvar.Location = new Point(151, 346);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(115, 33);
            btSalvar.TabIndex = 17;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // btCancelar
            // 
            btCancelar.Enabled = false;
            btCancelar.Location = new Point(272, 346);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(115, 33);
            btCancelar.TabIndex = 18;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // btEditar
            // 
            btEditar.Enabled = false;
            btEditar.Location = new Point(393, 346);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(115, 33);
            btEditar.TabIndex = 19;
            btEditar.Text = "Editar";
            btEditar.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            btExcluir.Enabled = false;
            btExcluir.Location = new Point(514, 346);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(115, 33);
            btExcluir.TabIndex = 20;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(648, 71);
            label10.Name = "label10";
            label10.Size = new Size(12, 15);
            label10.TabIndex = 21;
            label10.Text = "*";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(328, 131);
            label11.Name = "label11";
            label11.Size = new Size(12, 15);
            label11.TabIndex = 22;
            label11.Text = "*";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 409);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(btExcluir);
            Controls.Add(btEditar);
            Controls.Add(btCancelar);
            Controls.Add(btSalvar);
            Controls.Add(btNovo);
            Controls.Add(label9);
            Controls.Add(txtStatus);
            Controls.Add(txtCategoria);
            Controls.Add(txtDataFinal);
            Controls.Add(txtDataInicial);
            Controls.Add(txtObservacoes);
            Controls.Add(txtResponsavel);
            Controls.Add(txtDescricao);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtDescricao;
        private TextBox txtResponsavel;
        private RichTextBox txtObservacoes;
        private DateTimePicker txtDataInicial;
        private DateTimePicker txtDataFinal;
        private ComboBox txtCategoria;
        private ComboBox txtStatus;
        private Label label9;
        private Button btNovo;
        private Button btSalvar;
        private Button btCancelar;
        private Button btEditar;
        private Button btExcluir;
        private Label label10;
        private Label label11;
    }
}