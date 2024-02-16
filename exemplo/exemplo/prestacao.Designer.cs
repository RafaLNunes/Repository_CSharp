namespace exemplo
{
    partial class prestacao
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
            médiaDoAlunoToolStripMenuItem = new ToolStripMenuItem();
            bhaskaraToolStripMenuItem = new ToolStripMenuItem();
            prestaçãoToolStripMenuItem = new ToolStripMenuItem();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
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
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // médiaDoAlunoToolStripMenuItem
            // 
            médiaDoAlunoToolStripMenuItem.Name = "médiaDoAlunoToolStripMenuItem";
            médiaDoAlunoToolStripMenuItem.Size = new Size(130, 24);
            médiaDoAlunoToolStripMenuItem.Text = "Média do Aluno";
            médiaDoAlunoToolStripMenuItem.Click += médiaDoAlunoToolStripMenuItem_Click_1;
            // 
            // bhaskaraToolStripMenuItem
            // 
            bhaskaraToolStripMenuItem.Name = "bhaskaraToolStripMenuItem";
            bhaskaraToolStripMenuItem.Size = new Size(82, 24);
            bhaskaraToolStripMenuItem.Text = "Bhaskara";
            bhaskaraToolStripMenuItem.Click += bhaskaraToolStripMenuItem_Click_1;
            // 
            // prestaçãoToolStripMenuItem
            // 
            prestaçãoToolStripMenuItem.Name = "prestaçãoToolStripMenuItem";
            prestaçãoToolStripMenuItem.Size = new Size(87, 24);
            prestaçãoToolStripMenuItem.Text = "Prestação";
            prestaçãoToolStripMenuItem.Click += prestaçãoToolStripMenuItem_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(320, 94);
            label4.Name = "label4";
            label4.Size = new Size(132, 20);
            label4.TabIndex = 28;
            label4.Text = "Valor da Prestação";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(307, 167);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 27;
            label3.Text = "Tempo da prestação";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 236);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 26;
            label2.Text = "Taxa da Prestação";
            label2.Click += label2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(468, 233);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 25;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(468, 164);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 24;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(468, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 23;
            // 
            // button1
            // 
            button1.Location = new Point(426, 300);
            button1.Name = "button1";
            button1.Size = new Size(127, 61);
            button1.TabIndex = 29;
            button1.Text = "Esta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // prestacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            Name = "prestacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "prestacao";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem médiaDoAlunoToolStripMenuItem;
        private ToolStripMenuItem bhaskaraToolStripMenuItem;
        private ToolStripMenuItem prestaçãoToolStripMenuItem;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
    }
}