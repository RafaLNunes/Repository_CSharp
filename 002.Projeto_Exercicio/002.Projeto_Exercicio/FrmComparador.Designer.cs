namespace _002.Projeto_Exercicio
{
    partial class FrmComparador
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(532, 309);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(332, 286);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 289);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Número 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 332);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Número 2";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(332, 329);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 228);
            label3.Name = "label3";
            label3.Size = new Size(282, 15);
            label3.TabIndex = 5;
            label3.Text = "Vamos descobri qual dos números é o maior tipo Int";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(218, 75);
            label4.Name = "label4";
            label4.Size = new Size(311, 15);
            label4.TabIndex = 11;
            label4.Text = "Vamos descobri qual dos números é o maior tipo Decimal";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(332, 176);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(218, 179);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 9;
            label5.Text = "Número 2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(218, 136);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 8;
            label6.Text = "Número 1";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(332, 133);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(532, 156);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Enter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FrmComparador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "FrmComparador";
            Text = "FrmComparador";
            Load += FrmComparador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private TextBox textBox4;
        private Button button2;
    }
}