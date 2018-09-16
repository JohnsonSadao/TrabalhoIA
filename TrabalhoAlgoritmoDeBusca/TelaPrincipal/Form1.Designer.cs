namespace TelaPrincipal
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBuscaAprofundamento = new System.Windows.Forms.Button();
            this.comboBoxCidadeOrigem = new System.Windows.Forms.ComboBox();
            this.comboBoxCidadeDestino = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(285, 212);
            this.listBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cidade Destino";
            // 
            // buttonBuscaAprofundamento
            // 
            this.buttonBuscaAprofundamento.Location = new System.Drawing.Point(7, 281);
            this.buttonBuscaAprofundamento.Name = "buttonBuscaAprofundamento";
            this.buttonBuscaAprofundamento.Size = new System.Drawing.Size(104, 23);
            this.buttonBuscaAprofundamento.TabIndex = 9;
            this.buttonBuscaAprofundamento.Text = "Realizar Busca";
            this.buttonBuscaAprofundamento.UseVisualStyleBackColor = true;
            // 
            // comboBoxCidadeOrigem
            // 
            this.comboBoxCidadeOrigem.FormattingEnabled = true;
            this.comboBoxCidadeOrigem.Location = new System.Drawing.Point(7, 25);
            this.comboBoxCidadeOrigem.Name = "comboBoxCidadeOrigem";
            this.comboBoxCidadeOrigem.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCidadeOrigem.TabIndex = 10;
            // 
            // comboBoxCidadeDestino
            // 
            this.comboBoxCidadeDestino.FormattingEnabled = true;
            this.comboBoxCidadeDestino.Location = new System.Drawing.Point(171, 25);
            this.comboBoxCidadeDestino.Name = "comboBoxCidadeDestino";
            this.comboBoxCidadeDestino.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCidadeDestino.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cidade Origem";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 323);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCidadeDestino);
            this.Controls.Add(this.comboBoxCidadeOrigem);
            this.Controls.Add(this.buttonBuscaAprofundamento);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBuscaAprofundamento;
        private System.Windows.Forms.ComboBox comboBoxCidadeOrigem;
        private System.Windows.Forms.ComboBox comboBoxCidadeDestino;
        private System.Windows.Forms.Label label1;
    }
}

