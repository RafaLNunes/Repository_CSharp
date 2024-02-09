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
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            alunoToolStripMenuItem = new ToolStripMenuItem();
            médiaToolStripMenuItem = new ToolStripMenuItem();
            calculosToolStripMenuItem = new ToolStripMenuItem();
            bhaskaraToolStripMenuItem = new ToolStripMenuItem();
            prestaçãoDeServiçoToolStripMenuItem = new ToolStripMenuItem();
            comJurosToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(577, 256);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(315, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(577, 666);
            button1.Name = "button1";
            button1.Size = new Size(298, 54);
            button1.TabIndex = 2;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.ForeColor = SystemColors.WindowText;
            textBox2.Location = new Point(577, 313);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(315, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.ForeColor = SystemColors.WindowText;
            textBox3.Location = new Point(577, 366);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(315, 23);
            textBox3.TabIndex = 4;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.ForeColor = SystemColors.WindowText;
            textBox4.Location = new Point(577, 425);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(315, 23);
            textBox4.TabIndex = 5;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.ForeColor = SystemColors.WindowText;
            textBox5.Location = new Point(577, 486);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(315, 23);
            textBox5.TabIndex = 6;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.ForeColor = SystemColors.WindowText;
            textBox6.Location = new Point(577, 546);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(315, 23);
            textBox6.TabIndex = 7;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.ForeColor = SystemColors.WindowText;
            textBox7.Location = new Point(577, 604);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(315, 23);
            textBox7.TabIndex = 8;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 715);
            label1.Name = "label1";
            label1.Size = new Size(310, 31);
            label1.TabIndex = 9;
            label1.Text = "Hello ladies or gentlemen. ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(315, 715);
            label2.Name = "label2";
            label2.Size = new Size(151, 31);
            label2.TabIndex = 10;
            label2.Text = "Hello Sr(a). ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.check_ok_removebg_preview;
            pictureBox1.Location = new Point(524, 593);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 41);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, alunoToolStripMenuItem, calculosToolStripMenuItem, prestaçãoDeServiçoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1432, 24);
            menuStrip1.TabIndex = 13;
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
            // 
            // comJurosToolStripMenuItem
            // 
            comJurosToolStripMenuItem.ForeColor = Color.Black;
            comJurosToolStripMenuItem.Name = "comJurosToolStripMenuItem";
            comJurosToolStripMenuItem.Size = new Size(130, 22);
            comJurosToolStripMenuItem.Text = "Com Juros";
            comJurosToolStripMenuItem.Click += comJurosToolStripMenuItem_Click;
            // 
            // FrmAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Seja_Bem_Vindo_e_recebimento_de_notas__1_;
            ClientSize = new Size(1432, 755);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "FrmAluno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student average";
            Load += FrmAluno_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
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