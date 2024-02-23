namespace _002.Projeto_Exercicio
{
    partial class Frmtriangulo
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
            textA = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            textB = new TextBox();
            textC = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(590, 183);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textA
            // 
            textA.Location = new Point(378, 113);
            textA.Name = "textA";
            textA.Size = new Size(100, 23);
            textA.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(254, 116);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 2;
            label1.Text = "Lado A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 191);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "Lado B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(254, 251);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 5;
            label4.Text = "Lado C";
            // 
            // textB
            // 
            textB.Location = new Point(378, 188);
            textB.Name = "textB";
            textB.Size = new Size(100, 23);
            textB.TabIndex = 6;
            // 
            // textC
            // 
            textC.Location = new Point(378, 248);
            textC.Name = "textC";
            textC.Size = new Size(100, 23);
            textC.TabIndex = 7;
            // 
            // Frmtriangulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textC);
            Controls.Add(textB);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textA);
            Controls.Add(button1);
            Name = "Frmtriangulo";
            Text = "cltriangulo";
            Load += Frmtriangulo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textA;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox textB;
        private TextBox textC;
    }
}