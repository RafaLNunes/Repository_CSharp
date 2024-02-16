namespace _002.Projeto_Exercicio
{
    partial class Frmpessoa
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
            textname = new TextBox();
            textidade = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Apresentar = new Button();
            SuspendLayout();
            // 
            // textname
            // 
            textname.Location = new Point(254, 166);
            textname.Name = "textname";
            textname.Size = new Size(100, 23);
            textname.TabIndex = 0;
            // 
            // textidade
            // 
            textidade.Location = new Point(254, 228);
            textidade.Name = "textidade";
            textidade.Size = new Size(100, 23);
            textidade.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 169);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 231);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Idade";
            // 
            // Apresentar
            // 
            Apresentar.Location = new Point(476, 193);
            Apresentar.Name = "Apresentar";
            Apresentar.Size = new Size(75, 23);
            Apresentar.TabIndex = 4;
            Apresentar.Text = "Enter";
            Apresentar.UseVisualStyleBackColor = true;
            Apresentar.Click += Apresentar_Click;
            // 
            // Frmpessoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Apresentar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textidade);
            Controls.Add(textname);
            Name = "Frmpessoa";
            Text = "Frmpessoa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textname;
        private TextBox textidade;
        private Label label1;
        private Label label2;
        private Button Apresentar;
    }
}