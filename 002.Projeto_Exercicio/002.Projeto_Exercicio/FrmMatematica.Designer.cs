namespace _002.Projeto_Exercicio
{
    partial class FrmMatematica
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
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(271, 279);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Soma";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(419, 214);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 217);
            label1.Name = "label1";
            label1.Size = new Size(232, 15);
            label1.TabIndex = 2;
            label1.Text = "Coloque os numeros separados po \";\" aqui";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(303, 148);
            label2.Name = "label2";
            label2.Size = new Size(152, 15);
            label2.TabIndex = 5;
            label2.Text = "ele separará por \";\" os Array";
            // 
            // button2
            // 
            button2.Location = new Point(397, 279);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Média";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FrmMatematica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 481);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "FrmMatematica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMatematica";
            Load += FrmMatematica_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button button2;
    }
}