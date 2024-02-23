namespace _002.Projeto_Exercicio
{
    partial class FrmManipuladorTexto
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
            EnterArray = new Button();
            textpadrao = new TextBox();
            textarray = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            EnterPadrao = new Button();
            SuspendLayout();
            // 
            // EnterArray
            // 
            EnterArray.Location = new Point(541, 232);
            EnterArray.Name = "EnterArray";
            EnterArray.Size = new Size(94, 29);
            EnterArray.TabIndex = 0;
            EnterArray.Text = "Enter";
            EnterArray.UseVisualStyleBackColor = true;
            EnterArray.Click += EnterArray_Click;
            // 
            // textpadrao
            // 
            textpadrao.Location = new Point(359, 358);
            textpadrao.Name = "textpadrao";
            textpadrao.Size = new Size(125, 27);
            textpadrao.TabIndex = 1;
            // 
            // textarray
            // 
            textarray.Location = new Point(359, 234);
            textarray.Name = "textarray";
            textarray.Size = new Size(125, 27);
            textarray.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 319);
            label1.Name = "label1";
            label1.Size = new Size(184, 20);
            label1.TabIndex = 3;
            label1.Text = "Essa Serve para só inverter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 174);
            label2.Name = "label2";
            label2.Size = new Size(341, 20);
            label2.TabIndex = 4;
            label2.Text = "Esse alem de Inverter, ele separará por \";\" os Array";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(222, 55);
            label3.Name = "label3";
            label3.Size = new Size(402, 20);
            label3.TabIndex = 5;
            label3.Text = "Escreva e aperte no botão ao lado da opção que você quer";
            // 
            // EnterPadrao
            // 
            EnterPadrao.Location = new Point(541, 356);
            EnterPadrao.Name = "EnterPadrao";
            EnterPadrao.Size = new Size(94, 29);
            EnterPadrao.TabIndex = 6;
            EnterPadrao.Text = "Enter";
            EnterPadrao.UseVisualStyleBackColor = true;
            EnterPadrao.Click += EnterPadrao_Click;
            // 
            // FrmManipuladorTexto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(EnterPadrao);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textarray);
            Controls.Add(textpadrao);
            Controls.Add(EnterArray);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmManipuladorTexto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmManipuladorTexto";
            Load += FrmManipuladorTexto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EnterArray;
        private TextBox textpadrao;
        private TextBox textarray;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button EnterPadrao;
    }
}