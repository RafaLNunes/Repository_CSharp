namespace _002.Projeto_Exercicio
{
    partial class FrmLivro
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textdia = new TextBox();
            textmes = new TextBox();
            textano = new TextBox();
            textautor = new TextBox();
            textedicao = new TextBox();
            textttulo = new TextBox();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(205, 124);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 20;
            label3.Text = "Titulo";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(380, 242);
            label2.Name = "label2";
            label2.Size = new Size(19, 25);
            label2.TabIndex = 19;
            label2.Text = "/";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(305, 242);
            label1.Name = "label1";
            label1.Size = new Size(19, 25);
            label1.TabIndex = 18;
            label1.Text = "/";
            // 
            // textdia
            // 
            textdia.Location = new Point(251, 244);
            textdia.Name = "textdia";
            textdia.Size = new Size(54, 23);
            textdia.TabIndex = 17;
            // 
            // textmes
            // 
            textmes.Location = new Point(325, 244);
            textmes.Name = "textmes";
            textmes.Size = new Size(54, 23);
            textmes.TabIndex = 16;
            // 
            // textano
            // 
            textano.Location = new Point(400, 244);
            textano.Name = "textano";
            textano.Size = new Size(54, 23);
            textano.TabIndex = 15;
            // 
            // textautor
            // 
            textautor.Location = new Point(250, 180);
            textautor.Name = "textautor";
            textautor.Size = new Size(100, 23);
            textautor.TabIndex = 14;
            // 
            // textedicao
            // 
            textedicao.Location = new Point(249, 301);
            textedicao.Name = "textedicao";
            textedicao.Size = new Size(100, 23);
            textedicao.TabIndex = 13;
            // 
            // textttulo
            // 
            textttulo.Location = new Point(249, 121);
            textttulo.Name = "textttulo";
            textttulo.Size = new Size(100, 23);
            textttulo.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(574, 195);
            button1.Name = "button1";
            button1.Size = new Size(85, 44);
            button1.TabIndex = 11;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(205, 183);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 21;
            label4.Text = "Autor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(204, 304);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 22;
            label5.Text = "Edição";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(138, 247);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 23;
            label6.Text = "Data de Publicação";
            // 
            // FrmLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 481);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textdia);
            Controls.Add(textmes);
            Controls.Add(textano);
            Controls.Add(textautor);
            Controls.Add(textedicao);
            Controls.Add(textttulo);
            Controls.Add(button1);
            Name = "FrmLivro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLivro";
            Load += FrmLivro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textdia;
        private TextBox textmes;
        private TextBox textano;
        private TextBox textautor;
        private TextBox textedicao;
        private TextBox textttulo;
        private Button button1;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}