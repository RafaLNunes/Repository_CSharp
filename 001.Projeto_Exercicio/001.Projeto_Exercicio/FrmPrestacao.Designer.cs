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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, alunoToolStripMenuItem, calculosToolStripMenuItem, prestaçãoDeServiçoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1432, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.ForeColor = Color.White;
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(52, 20);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
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
            médiaToolStripMenuItem.Click += médiaToolStripMenuItem_Click;
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
            bhaskaraToolStripMenuItem.Click += bhaskaraToolStripMenuItem_Click;
            // 
            // prestaçãoDeServiçoToolStripMenuItem
            // 
            prestaçãoDeServiçoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { comJurosToolStripMenuItem });
            prestaçãoDeServiçoToolStripMenuItem.ForeColor = Color.White;
            prestaçãoDeServiçoToolStripMenuItem.Name = "prestaçãoDeServiçoToolStripMenuItem";
            prestaçãoDeServiçoToolStripMenuItem.Size = new Size(127, 20);
            prestaçãoDeServiçoToolStripMenuItem.Text = "Prestação de Serviço";
            prestaçãoDeServiçoToolStripMenuItem.Click += prestaçãoDeServiçoToolStripMenuItem_Click;
            // 
            // comJurosToolStripMenuItem
            // 
            comJurosToolStripMenuItem.ForeColor = Color.Black;
            comJurosToolStripMenuItem.Name = "comJurosToolStripMenuItem";
            comJurosToolStripMenuItem.Size = new Size(180, 22);
            comJurosToolStripMenuItem.Text = "Com Juros";
            comJurosToolStripMenuItem.Click += comJurosToolStripMenuItem_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(561, 279);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(338, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(561, 361);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(338, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(561, 428);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(338, 23);
            textBox3.TabIndex = 4;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(561, 638);
            button1.Name = "button1";
            button1.Size = new Size(338, 55);
            button1.TabIndex = 5;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(43, 580);
            label1.Name = "label1";
            label1.Size = new Size(79, 31);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // FrmPrestacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Seja_Bem_Vindo_e_recebimento_de_notas1;
            ClientSize = new Size(1432, 755);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            Name = "FrmPrestacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrestacao";
            Load += FrmPrestacao_Load;
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Label label1;
    }
}