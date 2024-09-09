namespace _001.Projeto_Exercicio
{
    partial class FrmBhaskara
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            alunoToolStripMenuItem = new ToolStripMenuItem();
            médiaToolStripMenuItem = new ToolStripMenuItem();
            calculosToolStripMenuItem = new ToolStripMenuItem();
            bhaskaraToolStripMenuItem = new ToolStripMenuItem();
            prestaçãoDeServiçoToolStripMenuItem = new ToolStripMenuItem();
            comJurosToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(534, 273);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(385, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(534, 332);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(385, 27);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(534, 399);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(385, 27);
            textBox3.TabIndex = 3;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gadugi", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(754, 459);
            label1.Name = "label1";
            label1.Size = new Size(134, 48);
            label1.TabIndex = 4;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Gadugi", 42F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(603, 543);
            label2.Name = "label2";
            label2.Size = new Size(234, 84);
            label2.TabIndex = 5;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(560, 666);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(310, 57);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
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
            prestaçãoDeServiçoToolStripMenuItem.Click += prestaçãoDeServiçoToolStripMenuItem_Click;
            // 
            // comJurosToolStripMenuItem
            // 
            comJurosToolStripMenuItem.ForeColor = Color.Black;
            comJurosToolStripMenuItem.Name = "comJurosToolStripMenuItem";
            comJurosToolStripMenuItem.Size = new Size(160, 26);
            comJurosToolStripMenuItem.Text = "Com Juros";
            comJurosToolStripMenuItem.Click += comJurosToolStripMenuItem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Gadugi", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(516, 459);
            label3.Name = "label3";
            label3.Size = new Size(134, 48);
            label3.TabIndex = 6;
            label3.Text = "label3";
            label3.Click += label3_Click;
            // 
            // FrmBhaskara
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Seja_Bem_Vindo_e_recebimento_de_notas;
            ClientSize = new Size(1637, 752);
            Controls.Add(menuStrip1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmBhaskara";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmBhaskara";
            Load += FrmBhaskara_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem alunoToolStripMenuItem;
        private ToolStripMenuItem médiaToolStripMenuItem;
        private ToolStripMenuItem calculosToolStripMenuItem;
        private ToolStripMenuItem bhaskaraToolStripMenuItem;
        private ToolStripMenuItem prestaçãoDeServiçoToolStripMenuItem;
        private ToolStripMenuItem comJurosToolStripMenuItem;
        private Label label3;
    }
}