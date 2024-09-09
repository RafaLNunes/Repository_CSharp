namespace _001.Projeto_Exercicio
{
    partial class FrmCentral
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
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            alunoToolStripMenuItem = new ToolStripMenuItem();
            médiaToolStripMenuItem = new ToolStripMenuItem();
            calculosToolStripMenuItem = new ToolStripMenuItem();
            bhaskaraToolStripMenuItem = new ToolStripMenuItem();
            prestaçãoDeServiçoToolStripMenuItem = new ToolStripMenuItem();
            comJurosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, alunoToolStripMenuItem, calculosToolStripMenuItem, prestaçãoDeServiçoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1637, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.ForeColor = Color.White;
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // alunoToolStripMenuItem
            // 
            alunoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { médiaToolStripMenuItem });
            alunoToolStripMenuItem.ForeColor = Color.White;
            alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            alunoToolStripMenuItem.Size = new Size(62, 24);
            alunoToolStripMenuItem.Text = "Aluno";
            alunoToolStripMenuItem.Click += alunoToolStripMenuItem_Click;
            // 
            // médiaToolStripMenuItem
            // 
            médiaToolStripMenuItem.Name = "médiaToolStripMenuItem";
            médiaToolStripMenuItem.Size = new Size(134, 26);
            médiaToolStripMenuItem.Text = "Média";
            médiaToolStripMenuItem.Click += médiaToolStripMenuItem_Click;
            // 
            // calculosToolStripMenuItem
            // 
            calculosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bhaskaraToolStripMenuItem });
            calculosToolStripMenuItem.ForeColor = Color.White;
            calculosToolStripMenuItem.Name = "calculosToolStripMenuItem";
            calculosToolStripMenuItem.Size = new Size(78, 24);
            calculosToolStripMenuItem.Text = "Calculos";
            // 
            // bhaskaraToolStripMenuItem
            // 
            bhaskaraToolStripMenuItem.ForeColor = Color.Black;
            bhaskaraToolStripMenuItem.Name = "bhaskaraToolStripMenuItem";
            bhaskaraToolStripMenuItem.Size = new Size(151, 26);
            bhaskaraToolStripMenuItem.Text = "Bhaskara";
            bhaskaraToolStripMenuItem.Click += bhaskaraToolStripMenuItem_Click;
            // 
            // prestaçãoDeServiçoToolStripMenuItem
            // 
            prestaçãoDeServiçoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { comJurosToolStripMenuItem });
            prestaçãoDeServiçoToolStripMenuItem.ForeColor = Color.White;
            prestaçãoDeServiçoToolStripMenuItem.Name = "prestaçãoDeServiçoToolStripMenuItem";
            prestaçãoDeServiçoToolStripMenuItem.Size = new Size(160, 24);
            prestaçãoDeServiçoToolStripMenuItem.Text = "Prestação de Serviço";
            // 
            // comJurosToolStripMenuItem
            // 
            comJurosToolStripMenuItem.ForeColor = Color.Black;
            comJurosToolStripMenuItem.Name = "comJurosToolStripMenuItem";
            comJurosToolStripMenuItem.Size = new Size(160, 26);
            comJurosToolStripMenuItem.Text = "Com Juros";
            comJurosToolStripMenuItem.Click += comJurosToolStripMenuItem_Click;
            // 
            // FrmCentral
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Seja_Bem_Vindo_e_recebimento_de_notas__2_;
            ClientSize = new Size(1637, 752);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmCentral";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += FrmCentral_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem alunoToolStripMenuItem;
        private ToolStripMenuItem médiaToolStripMenuItem;
        private ToolStripMenuItem calculosToolStripMenuItem;
        private ToolStripMenuItem bhaskaraToolStripMenuItem;
        private ToolStripMenuItem prestaçãoDeServiçoToolStripMenuItem;
        private ToolStripMenuItem comJurosToolStripMenuItem;
    }
}