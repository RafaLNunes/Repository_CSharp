namespace _003.Projeto_Exercicio
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            Numb2 = new Label();
            Numb1 = new Label();
            textBox2 = new TextBox();
            result = new Label();
            textBox1 = new TextBox();
            Enter = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(478, 219);
            button3.Name = "button3";
            button3.Size = new Size(91, 23);
            button3.TabIndex = 17;
            button3.Text = "Divisão";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(478, 158);
            button2.Name = "button2";
            button2.Size = new Size(91, 23);
            button2.TabIndex = 16;
            button2.Text = "Subtração";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(478, 129);
            button1.Name = "button1";
            button1.Size = new Size(91, 23);
            button1.TabIndex = 15;
            button1.Text = "Soma";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Numb2
            // 
            Numb2.AutoSize = true;
            Numb2.Location = new Point(232, 184);
            Numb2.Name = "Numb2";
            Numb2.Size = new Size(50, 15);
            Numb2.TabIndex = 14;
            Numb2.Text = "Numb 2";
            // 
            // Numb1
            // 
            Numb1.AutoSize = true;
            Numb1.Location = new Point(232, 123);
            Numb1.Name = "Numb1";
            Numb1.Size = new Size(50, 15);
            Numb1.TabIndex = 13;
            Numb1.Text = "Numb 1";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(232, 202);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 12;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            result.Location = new Point(351, 274);
            result.Name = "result";
            result.Size = new Size(83, 32);
            result.TabIndex = 11;
            result.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(232, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 10;
            // 
            // Enter
            // 
            Enter.Location = new Point(478, 187);
            Enter.Name = "Enter";
            Enter.Size = new Size(91, 23);
            Enter.TabIndex = 9;
            Enter.Text = "Multiplicação ";
            Enter.UseVisualStyleBackColor = true;
            Enter.Click += Enter_Click;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 481);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Numb2);
            Controls.Add(Numb1);
            Controls.Add(textBox2);
            Controls.Add(result);
            Controls.Add(textBox1);
            Controls.Add(Enter);
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCalculadora";
            Load += FrmCalculadora_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private Label Numb2;
        private Label Numb1;
        private TextBox textBox2;
        private Label result;
        private TextBox textBox1;
        private Button Enter;
    }
}