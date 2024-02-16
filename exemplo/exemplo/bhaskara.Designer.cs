namespace exemplo
{
    partial class bhaskara
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            menuStrip1 = new MenuStrip();
            médiaDoAlunoToolStripMenuItem = new ToolStripMenuItem();
            bhaskaraToolStripMenuItem = new ToolStripMenuItem();
            prestaçãoToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { médiaDoAlunoToolStripMenuItem, bhaskaraToolStripMenuItem, prestaçãoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(914, 28);
            menuStrip1.TabIndex = 14;
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
            // textBox1
            // 
            textBox1.Location = new Point(403, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 15;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(403, 218);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(403, 287);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 17;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(374, 353);
            button1.Name = "button1";
            button1.Size = new Size(176, 77);
            button1.TabIndex = 18;
            button1.Text = "Claudio";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 381);
            label1.Name = "label1";
            label1.Size = new Size(222, 20);
            label1.TabIndex = 19;
            label1.Text = "Clique em Claudio para Calcular";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 290);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 20;
            label2.Text = "Valor C";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(299, 220);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 21;
            label3.Text = "Valor B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(299, 148);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 22;
            label4.Text = "Valor A";
            // 
            // bhaskara
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            Name = "bhaskara";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "bhaskara";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem médiaDoAlunoToolStripMenuItem;
        private ToolStripMenuItem bhaskaraToolStripMenuItem;
        private ToolStripMenuItem prestaçãoToolStripMenuItem;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}