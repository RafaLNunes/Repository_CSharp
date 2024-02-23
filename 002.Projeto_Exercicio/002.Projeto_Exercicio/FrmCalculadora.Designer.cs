namespace _002.Projeto_Exercicio
{
    partial class FrmCalculadora
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 328);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 0;
            label1.Text = "1° Numb Decimal";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(179, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(576, 216);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 155);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 3;
            label2.Text = "1° Numb Inteiro";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(179, 325);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(418, 325);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(318, 155);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 7;
            label3.Text = "2° Numb Inteiro";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(418, 152);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(318, 328);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 5;
            label4.Text = "2° Numb Decimal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(201, 111);
            label5.Name = "label5";
            label5.Size = new Size(232, 15);
            label5.TabIndex = 9;
            label5.Text = "Essa Calculadora irá somar os dois Inteiros ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(217, 294);
            label6.Name = "label6";
            label6.Size = new Size(241, 15);
            label6.TabIndex = 10;
            label6.Text = "Essa Calculadora irá somar os dois Decimais ";
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 481);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCalculadora";
            Load += FrmCalculadora_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}