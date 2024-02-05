namespace _001.Projeto_Exercicio
{
    partial class FrmAluno
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            alunoToolStripMenuItem = new ToolStripMenuItem();
            calculoToolStripMenuItem = new ToolStripMenuItem();
            bhaskaraToolStripMenuItem = new ToolStripMenuItem();
            prestaçãoToolStripMenuItem = new ToolStripMenuItem();
            informaçõesToolStripMenuItem = new ToolStripMenuItem();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 146);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 7;
            label3.Text = "1° Nota 1° Bimestre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 110);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 6;
            label2.Text = "Nome do aluno";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 180);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 5;
            label1.Text = "2° Nota 1° Bimestral";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { alunoToolStripMenuItem, calculoToolStripMenuItem, prestaçãoToolStripMenuItem, informaçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // alunoToolStripMenuItem
            // 
            alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            alunoToolStripMenuItem.Size = new Size(51, 20);
            alunoToolStripMenuItem.Text = "Aluno";
            // 
            // calculoToolStripMenuItem
            // 
            calculoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bhaskaraToolStripMenuItem });
            calculoToolStripMenuItem.Name = "calculoToolStripMenuItem";
            calculoToolStripMenuItem.Size = new Size(59, 20);
            calculoToolStripMenuItem.Text = "Calculo";
            // 
            // bhaskaraToolStripMenuItem
            // 
            bhaskaraToolStripMenuItem.Name = "bhaskaraToolStripMenuItem";
            bhaskaraToolStripMenuItem.Size = new Size(121, 22);
            bhaskaraToolStripMenuItem.Text = "Bhaskara";
            // 
            // prestaçãoToolStripMenuItem
            // 
            prestaçãoToolStripMenuItem.Name = "prestaçãoToolStripMenuItem";
            prestaçãoToolStripMenuItem.Size = new Size(70, 20);
            prestaçãoToolStripMenuItem.Text = "Prestação";
            // 
            // informaçõesToolStripMenuItem
            // 
            informaçõesToolStripMenuItem.Name = "informaçõesToolStripMenuItem";
            informaçõesToolStripMenuItem.Size = new Size(85, 20);
            informaçõesToolStripMenuItem.Text = "Informações";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 215);
            label4.Name = "label4";
            label4.Size = new Size(113, 15);
            label4.TabIndex = 8;
            label4.Text = "3° Nota 1° Bimestral";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 245);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 9;
            label5.Text = "4° Nota Bimestral";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 277);
            label6.Name = "label6";
            label6.Size = new Size(132, 15);
            label6.TabIndex = 10;
            label6.Text = "Número de Aulas Totais";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 309);
            label7.Name = "label7";
            label7.Size = new Size(148, 15);
            label7.TabIndex = 11;
            label7.Text = "Número de Aulas Minimas";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(355, 218);
            label8.Name = "label8";
            label8.Size = new Size(116, 15);
            label8.TabIndex = 12;
            label8.Text = "Média de Aprovação";
            // 
            // FrmAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "FrmAluno";
            Text = "Página do Aluno";
            Load += FrmAluno_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem alunoToolStripMenuItem;
        private ToolStripMenuItem calculoToolStripMenuItem;
        private ToolStripMenuItem bhaskaraToolStripMenuItem;
        private ToolStripMenuItem prestaçãoToolStripMenuItem;
        private ToolStripMenuItem informaçõesToolStripMenuItem;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}