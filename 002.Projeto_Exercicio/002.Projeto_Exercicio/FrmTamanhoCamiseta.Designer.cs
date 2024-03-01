namespace _002.Projeto_Exercicio
{
    partial class FrmTamanhoCamiseta
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
            pictureBox1 = new PictureBox();
            textAlt = new TextBox();
            textLarg = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._41l7pPEF3DL__AC_;
            pictureBox1.Location = new Point(12, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(501, 334);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textAlt
            // 
            textAlt.Location = new Point(587, 114);
            textAlt.Name = "textAlt";
            textAlt.Size = new Size(100, 23);
            textAlt.TabIndex = 1;
            // 
            // textLarg
            // 
            textLarg.Location = new Point(587, 229);
            textLarg.Name = "textLarg";
            textLarg.Size = new Size(100, 23);
            textLarg.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(594, 79);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Altura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(594, 201);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 4;
            label2.Text = "Largura";
            // 
            // button1
            // 
            button1.Location = new Point(587, 309);
            button1.Name = "button1";
            button1.Size = new Size(98, 36);
            button1.TabIndex = 5;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmTamanhoCamiseta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 481);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textLarg);
            Controls.Add(textAlt);
            Controls.Add(pictureBox1);
            Name = "FrmTamanhoCamiseta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmTamanhoCamiseta";
            Load += FrmTamanhoCamiseta_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textAlt;
        private TextBox textLarg;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}