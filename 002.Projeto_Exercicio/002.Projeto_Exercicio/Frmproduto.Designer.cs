namespace _002.Projeto_Exercicio
{
    partial class Frmproduto
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
            textnome = new TextBox();
            label1 = new Label();
            button1 = new Button();
            textprec = new TextBox();
            textdesc = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textnome
            // 
            textnome.Location = new Point(319, 119);
            textnome.Name = "textnome";
            textnome.Size = new Size(61, 23);
            textnome.TabIndex = 0;
            textnome.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 122);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // button1
            // 
            button1.Location = new Point(492, 168);
            button1.Name = "button1";
            button1.Size = new Size(75, 55);
            button1.TabIndex = 2;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textprec
            // 
            textprec.Location = new Point(319, 185);
            textprec.Name = "textprec";
            textprec.Size = new Size(61, 23);
            textprec.TabIndex = 3;
            // 
            // textdesc
            // 
            textdesc.Location = new Point(319, 248);
            textdesc.Name = "textdesc";
            textdesc.Size = new Size(61, 23);
            textdesc.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 188);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 5;
            label2.Text = "Preço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, 244);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 6;
            label3.Text = "Desconto ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(221, 259);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 7;
            label4.Text = "em % de 0 a 100";
            // 
            // Frmproduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 481);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textdesc);
            Controls.Add(textprec);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textnome);
            Name = "Frmproduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frmproduto";
            Load += Frmproduto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textnome;
        private Label label1;
        private Button button1;
        private TextBox textprec;
        private TextBox textdesc;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}