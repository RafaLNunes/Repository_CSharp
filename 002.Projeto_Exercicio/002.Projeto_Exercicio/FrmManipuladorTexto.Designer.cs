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
            label4 = new Label();
            SuspendLayout();
            // 
            // EnterArray
            // 
            EnterArray.Location = new Point(473, 174);
            EnterArray.Margin = new Padding(3, 2, 3, 2);
            EnterArray.Name = "EnterArray";
            EnterArray.Size = new Size(82, 22);
            EnterArray.TabIndex = 0;
            EnterArray.Text = "Enter";
            EnterArray.UseVisualStyleBackColor = true;
            EnterArray.Click += EnterArray_Click;
            // 
            // textpadrao
            // 
            textpadrao.Location = new Point(314, 268);
            textpadrao.Margin = new Padding(3, 2, 3, 2);
            textpadrao.Name = "textpadrao";
            textpadrao.Size = new Size(110, 23);
            textpadrao.TabIndex = 1;
            // 
            // textarray
            // 
            textarray.Location = new Point(314, 176);
            textarray.Margin = new Padding(3, 2, 3, 2);
            textarray.Name = "textarray";
            textarray.Size = new Size(110, 23);
            textarray.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(290, 239);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 3;
            label1.Text = "Essa Serve para só inverter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 130);
            label2.Name = "label2";
            label2.Size = new Size(268, 15);
            label2.TabIndex = 4;
            label2.Text = "Esse alem de Inverter, ele separará por \";\" os Array";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(194, 41);
            label3.Name = "label3";
            label3.Size = new Size(314, 15);
            label3.TabIndex = 5;
            label3.Text = "Escreva e aperte no botão ao lado da opção que você quer";
            // 
            // EnterPadrao
            // 
            EnterPadrao.Location = new Point(473, 267);
            EnterPadrao.Margin = new Padding(3, 2, 3, 2);
            EnterPadrao.Name = "EnterPadrao";
            EnterPadrao.Size = new Size(82, 22);
            EnterPadrao.TabIndex = 6;
            EnterPadrao.Text = "Enter";
            EnterPadrao.UseVisualStyleBackColor = true;
            EnterPadrao.Click += EnterPadrao_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 181);
            label4.Name = "label4";
            label4.Size = new Size(192, 15);
            label4.TabIndex = 7;
            label4.Text = "essa parte esta em manutenção =>";
            // 
            // FrmManipuladorTexto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(EnterPadrao);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textarray);
            Controls.Add(textpadrao);
            Controls.Add(EnterArray);
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
        private Label label4;
    }
}