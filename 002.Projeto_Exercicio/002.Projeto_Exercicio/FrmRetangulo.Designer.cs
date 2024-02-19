namespace _002.Projeto_Exercicio
{
    partial class FrmRetangulo
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
            Enter = new Button();
            Altura = new TextBox();
            Largura = new TextBox();
            label1 = new Label();
            resut = new Label();
            SuspendLayout();
            // 
            // Enter
            // 
            Enter.Location = new Point(342, 229);
            Enter.Name = "Enter";
            Enter.Size = new Size(75, 23);
            Enter.TabIndex = 0;
            Enter.Text = "Enter";
            Enter.UseVisualStyleBackColor = true;
            Enter.Click += Enter_Click;
            // 
            // Altura
            // 
            Altura.Location = new Point(136, 270);
            Altura.Name = "Altura";
            Altura.Size = new Size(100, 23);
            Altura.TabIndex = 1;
            // 
            // Largura
            // 
            Largura.Location = new Point(136, 201);
            Largura.Name = "Largura";
            Largura.Size = new Size(100, 23);
            Largura.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(342, 332);
            label1.Name = "label1";
            label1.Size = new Size(175, 21);
            label1.TabIndex = 3;
            label1.Text = "área do retângulo:";
            // 
            // resut
            // 
            resut.AutoSize = true;
            resut.Font = new Font("Gadugi", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            resut.Location = new Point(531, 332);
            resut.Name = "resut";
            resut.Size = new Size(170, 21);
            resut.TabIndex = 4;
            resut.Text = "área do retângulo";
            // 
            // FrmRetangulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resut);
            Controls.Add(label1);
            Controls.Add(Largura);
            Controls.Add(Altura);
            Controls.Add(Enter);
            Name = "FrmRetangulo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRetangulo";
            Load += FrmRetangulo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Enter;
        private TextBox Altura;
        private TextBox Largura;
        private Label label1;
        private Label resut;
    }
}