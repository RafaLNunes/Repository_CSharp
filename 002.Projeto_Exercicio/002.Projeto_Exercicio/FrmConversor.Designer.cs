namespace _002.Projeto_Exercicio
{
    partial class FrmConversor
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
            textDv = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textRv = new TextBox();
            textRr = new TextBox();
            textDr = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(568, 221);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textDv
            // 
            textDv.Location = new Point(263, 159);
            textDv.Name = "textDv";
            textDv.Size = new Size(100, 23);
            textDv.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(272, 129);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 2;
            label1.Text = "Valor em Dolar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 268);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 4;
            label2.Text = "Valor em Real";
            // 
            // textRv
            // 
            textRv.Location = new Point(263, 296);
            textRv.Name = "textRv";
            textRv.Size = new Size(100, 23);
            textRv.TabIndex = 3;
            // 
            // textRr
            // 
            textRr.Location = new Point(398, 296);
            textRr.Name = "textRr";
            textRr.Size = new Size(100, 23);
            textRr.TabIndex = 5;
            // 
            // textDr
            // 
            textDr.Location = new Point(398, 159);
            textDr.Name = "textDr";
            textDr.Size = new Size(100, 23);
            textDr.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(369, 299);
            label3.Name = "label3";
            label3.Size = new Size(23, 15);
            label3.TabIndex = 7;
            label3.Text = "=>";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(369, 162);
            label4.Name = "label4";
            label4.Size = new Size(23, 15);
            label4.TabIndex = 8;
            label4.Text = "=>";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(418, 268);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 9;
            label5.Text = "Para Dolar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(418, 129);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 10;
            label6.Text = "Para Real";
            // 
            // FrmConversor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 481);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textDr);
            Controls.Add(textRr);
            Controls.Add(label2);
            Controls.Add(textRv);
            Controls.Add(label1);
            Controls.Add(textDv);
            Controls.Add(button1);
            Name = "FrmConversor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConversor";
            Load += FrmConversor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textDv;
        private Label label1;
        private Label label2;
        private TextBox textRv;
        private TextBox textRr;
        private TextBox textDr;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}