namespace _001.Projeto_Exercicio
{
    partial class FrmPrestacao
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, alunoToolStripMenuItem, calculosToolStripMenuItem, prestaçãoDeServiçoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.ForeColor = Color.White;
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(52, 20);
            homeToolStripMenuItem.Text = "Home";
            // 
            // alunoToolStripMenuItem
            // 
            alunoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { médiaToolStripMenuItem });
            alunoToolStripMenuItem.ForeColor = Color.White;
            alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            alunoToolStripMenuItem.Size = new Size(51, 20);
            alunoToolStripMenuItem.Text = "Aluno";
            // 
            // médiaToolStripMenuItem
            // 
            médiaToolStripMenuItem.Name = "médiaToolStripMenuItem";
            médiaToolStripMenuItem.Size = new Size(107, 22);
            médiaToolStripMenuItem.Text = "Média";
            // 
            // calculosToolStripMenuItem
            // 
            calculosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bhaskaraToolStripMenuItem });
            calculosToolStripMenuItem.ForeColor = Color.White;
            calculosToolStripMenuItem.Name = "calculosToolStripMenuItem";
            calculosToolStripMenuItem.Size = new Size(64, 20);
            calculosToolStripMenuItem.Text = "Calculos";
            // 
            // bhaskaraToolStripMenuItem
            // 
            bhaskaraToolStripMenuItem.ForeColor = Color.Black;
            bhaskaraToolStripMenuItem.Name = "bhaskaraToolStripMenuItem";
            bhaskaraToolStripMenuItem.Size = new Size(121, 22);
            bhaskaraToolStripMenuItem.Text = "Bhaskara";
            // 
            // prestaçãoDeServiçoToolStripMenuItem
            // 
            prestaçãoDeServiçoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { comJurosToolStripMenuItem });
            prestaçãoDeServiçoToolStripMenuItem.ForeColor = Color.White;
            prestaçãoDeServiçoToolStripMenuItem.Name = "prestaçãoDeServiçoToolStripMenuItem";
            prestaçãoDeServiçoToolStripMenuItem.Size = new Size(127, 20);
            prestaçãoDeServiçoToolStripMenuItem.Text = "Prestação de Serviço";
            // 
            // comJurosToolStripMenuItem
            // 
            comJurosToolStripMenuItem.ForeColor = Color.Black;
            comJurosToolStripMenuItem.Name = "comJurosToolStripMenuItem";
            comJurosToolStripMenuItem.Size = new Size(130, 22);
            comJurosToolStripMenuItem.Text = "Com Juros";
            // 
            // FrmPrestacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Name = "FrmPrestacao";
            Text = "FrmPrestacao";
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