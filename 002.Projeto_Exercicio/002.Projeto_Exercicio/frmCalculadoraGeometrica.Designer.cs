namespace _002.Projeto_Exercicio
{
    partial class frmCalculadoraGeometrica
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
            ret = new Button();
            textalt = new TextBox();
            label1 = new Label();
            cir = new Button();
            Tri = new Button();
            label2 = new Label();
            textlargura = new TextBox();
            label3 = new Label();
            textraio = new TextBox();
            label4 = new Label();
            textbase = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // ret
            // 
            ret.Location = new Point(496, 175);
            ret.Name = "ret";
            ret.Size = new Size(75, 23);
            ret.TabIndex = 0;
            ret.Text = "Retângulo ";
            ret.UseVisualStyleBackColor = true;
            ret.Click += ret_Click;
            // 
            // textalt
            // 
            textalt.Location = new Point(150, 302);
            textalt.Name = "textalt";
            textalt.Size = new Size(100, 23);
            textalt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 284);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Altura";
            // 
            // cir
            // 
            cir.Location = new Point(384, 175);
            cir.Name = "cir";
            cir.Size = new Size(75, 23);
            cir.TabIndex = 3;
            cir.Text = "círculo ";
            cir.UseVisualStyleBackColor = true;
            cir.Click += cir_Click;
            // 
            // Tri
            // 
            Tri.FlatStyle = FlatStyle.Popup;
            Tri.Location = new Point(267, 175);
            Tri.Name = "Tri";
            Tri.Size = new Size(75, 23);
            Tri.TabIndex = 4;
            Tri.Text = "triângulo ";
            Tri.UseVisualStyleBackColor = true;
            Tri.Click += Tri_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(473, 284);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 6;
            label2.Text = "largura ";
            // 
            // textlargura
            // 
            textlargura.Location = new Point(445, 302);
            textlargura.Name = "textlargura";
            textlargura.Size = new Size(100, 23);
            textlargura.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(626, 284);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 8;
            label3.Text = "raio";
            // 
            // textraio
            // 
            textraio.Location = new Point(590, 302);
            textraio.Name = "textraio";
            textraio.Size = new Size(100, 23);
            textraio.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(332, 284);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 10;
            label4.Text = "base ";
            // 
            // textbase
            // 
            textbase.Location = new Point(299, 302);
            textbase.Name = "textbase";
            textbase.Size = new Size(100, 23);
            textbase.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(303, 328);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 11;
            label5.Text = "Para o triângulo ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(599, 328);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 12;
            label6.Text = "Para o círculo ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(154, 328);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 13;
            label7.Text = "Para o triângulo ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(445, 328);
            label8.Name = "label8";
            label8.Size = new Size(100, 15);
            label8.TabIndex = 14;
            label8.Text = "Para o retângulo  ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(154, 343);
            label9.Name = "label9";
            label9.Size = new Size(100, 15);
            label9.TabIndex = 15;
            label9.Text = "Para o retângulo  ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(332, 235);
            label10.Name = "label10";
            label10.Size = new Size(181, 15);
            label10.TabIndex = 16;
            label10.Text = "Escreva os números onde precisa";
            // 
            // frmCalculadoraGeometrica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 481);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textbase);
            Controls.Add(label3);
            Controls.Add(textraio);
            Controls.Add(label2);
            Controls.Add(textlargura);
            Controls.Add(Tri);
            Controls.Add(cir);
            Controls.Add(label1);
            Controls.Add(textalt);
            Controls.Add(ret);
            Name = "frmCalculadoraGeometrica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCalculadoraGeometrica";
            Load += frmCalculadoraGeometrica_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ret;
        private TextBox textalt;
        private Label label1;
        private Button cir;
        private Button Tri;
        private Label label2;
        private TextBox textlargura;
        private Label label3;
        private TextBox textraio;
        private Label label4;
        private TextBox textbase;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}