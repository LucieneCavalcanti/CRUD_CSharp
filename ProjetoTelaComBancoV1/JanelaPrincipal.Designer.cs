namespace ProjetoTelaComBancoV1
{
    partial class JanelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaPrincipal));
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            alunosToolStripMenuItem = new ToolStripMenuItem();
            aulasToolStripMenuItem = new ToolStripMenuItem();
            horáriosToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(891, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alunosToolStripMenuItem, aulasToolStripMenuItem, horáriosToolStripMenuItem, sairToolStripMenuItem });
            cadastrosToolStripMenuItem.Image = (Image)resources.GetObject("cadastrosToolStripMenuItem.Image");
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(87, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // alunosToolStripMenuItem
            // 
            alunosToolStripMenuItem.Image = (Image)resources.GetObject("alunosToolStripMenuItem.Image");
            alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            alunosToolStripMenuItem.Size = new Size(119, 22);
            alunosToolStripMenuItem.Text = "Alunos";
            alunosToolStripMenuItem.Click += alunosToolStripMenuItem_Click;
            // 
            // aulasToolStripMenuItem
            // 
            aulasToolStripMenuItem.Image = (Image)resources.GetObject("aulasToolStripMenuItem.Image");
            aulasToolStripMenuItem.Name = "aulasToolStripMenuItem";
            aulasToolStripMenuItem.Size = new Size(119, 22);
            aulasToolStripMenuItem.Text = "Aulas";
            aulasToolStripMenuItem.Click += aulasToolStripMenuItem_Click;
            // 
            // horáriosToolStripMenuItem
            // 
            horáriosToolStripMenuItem.Image = (Image)resources.GetObject("horáriosToolStripMenuItem.Image");
            horáriosToolStripMenuItem.Name = "horáriosToolStripMenuItem";
            horáriosToolStripMenuItem.Size = new Size(119, 22);
            horáriosToolStripMenuItem.Text = "Horários";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Image = (Image)resources.GetObject("sairToolStripMenuItem.Image");
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(119, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // JanelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(891, 541);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "JanelaPrincipal";
            Text = "JanelaPrincipal";
            Load += JanelaPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem alunosToolStripMenuItem;
        private ToolStripMenuItem aulasToolStripMenuItem;
        private ToolStripMenuItem horáriosToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}