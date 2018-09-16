namespace TrabalhoAlgoritmoDeBusca.Infra
{
    partial class TelaPrincipal
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.buttonBuscaAprofundamento = new System.Windows.Forms.Button();
            this.comboBoxCidadeOrigem = new System.Windows.Forms.ComboBox();
            this.comboBoxCidadeDestino = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(67, 79);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(271, 212);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(379, 79);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(279, 212);
            this.listBox2.TabIndex = 1;
            // 
            // buttonBuscaAprofundamento
            // 
            this.buttonBuscaAprofundamento.Location = new System.Drawing.Point(67, 298);
            this.buttonBuscaAprofundamento.Name = "buttonBuscaAprofundamento";
            this.buttonBuscaAprofundamento.Size = new System.Drawing.Size(104, 23);
            this.buttonBuscaAprofundamento.TabIndex = 2;
            this.buttonBuscaAprofundamento.Text = "Realizar Busca";
            this.buttonBuscaAprofundamento.UseVisualStyleBackColor = true;
            this.buttonBuscaAprofundamento.Click += new System.EventHandler(this.buttonBuscaAprofundamento_Click);
            // 
            // comboBoxCidadeOrigem
            // 
            this.comboBoxCidadeOrigem.FormattingEnabled = true;
            this.comboBoxCidadeOrigem.Location = new System.Drawing.Point(67, 42);
            this.comboBoxCidadeOrigem.Name = "comboBoxCidadeOrigem";
            this.comboBoxCidadeOrigem.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCidadeOrigem.TabIndex = 3;
            // 
            // comboBoxCidadeDestino
            // 
            this.comboBoxCidadeDestino.FormattingEnabled = true;
            this.comboBoxCidadeDestino.Location = new System.Drawing.Point(379, 42);
            this.comboBoxCidadeDestino.Name = "comboBoxCidadeDestino";
            this.comboBoxCidadeDestino.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCidadeDestino.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cidade Origem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cidade Destino";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCidadeDestino);
            this.Controls.Add(this.comboBoxCidadeOrigem);
            this.Controls.Add(this.buttonBuscaAprofundamento);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "TelaPrincipal";
            this.Text = "TelaPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button buttonBuscaAprofundamento;
        private System.Windows.Forms.ComboBox comboBoxCidadeOrigem;
        private System.Windows.Forms.ComboBox comboBoxCidadeDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}