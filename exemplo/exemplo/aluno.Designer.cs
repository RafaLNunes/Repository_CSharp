namespace exemplo
{
    partial class aluno
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
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            médiaDoAlunoToolStripMenuItem = new ToolStripMenuItem();
            bhaskaraToolStripMenuItem = new ToolStripMenuItem();
            prestaçãoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(353, 89);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(250, 180);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(250, 320);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(114, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(459, 320);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(114, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(459, 180);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(114, 27);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(353, 426);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(114, 27);
            textBox6.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(388, 65);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 6;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(275, 156);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 7;
            label2.Text = "1° Nota";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(486, 156);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 8;
            label3.Text = "2° Nota";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(275, 296);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 9;
            label4.Text = "3° Nota";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(486, 296);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 10;
            label5.Text = "4° Nota";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(388, 402);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 11;
            label6.Text = "Faltas";
            // 
            // button1
            // 
            button1.Location = new Point(353, 253);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(114, 31);
            button1.TabIndex = 12;
            button1.Text = "Claculadora";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { médiaDoAlunoToolStripMenuItem, bhaskaraToolStripMenuItem, prestaçãoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(914, 28);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // médiaDoAlunoToolStripMenuItem
            // 
            médiaDoAlunoToolStripMenuItem.Name = "médiaDoAlunoToolStripMenuItem";
            médiaDoAlunoToolStripMenuItem.Size = new Size(130, 24);
            médiaDoAlunoToolStripMenuItem.Text = "Média do Aluno";
            médiaDoAlunoToolStripMenuItem.Click += médiaDoAlunoToolStripMenuItem_Click;
            // 
            // bhaskaraToolStripMenuItem
            // 
            bhaskaraToolStripMenuItem.Name = "bhaskaraToolStripMenuItem";
            bhaskaraToolStripMenuItem.Size = new Size(82, 24);
            bhaskaraToolStripMenuItem.Text = "Bhaskara";
            bhaskaraToolStripMenuItem.Click += bhaskaraToolStripMenuItem_Click;
            // 
            // prestaçãoToolStripMenuItem
            // 
            prestaçãoToolStripMenuItem.Name = "prestaçãoToolStripMenuItem";
            prestaçãoToolStripMenuItem.Size = new Size(87, 24);
            prestaçãoToolStripMenuItem.Text = "Prestação";
            prestaçãoToolStripMenuItem.Click += prestaçãoToolStripMenuItem_Click;
            // 
            // aluno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "aluno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".";
            Load += aluno_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem médiaDoAlunoToolStripMenuItem;
        private ToolStripMenuItem bhaskaraToolStripMenuItem;
        private ToolStripMenuItem prestaçãoToolStripMenuItem;
    }
}