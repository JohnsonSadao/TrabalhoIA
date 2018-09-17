namespace TelaDeBusca
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCidadeOrigem = new System.Windows.Forms.ComboBox();
            this.comboBoxCidadeDestino = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNosGerados = new System.Windows.Forms.Label();
            this.lblNosExpandidos = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPassosDados = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTempoExecucao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cidade Origem:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CidadeDestino:";
            // 
            // comboBoxCidadeOrigem
            // 
            this.comboBoxCidadeOrigem.FormattingEnabled = true;
            this.comboBoxCidadeOrigem.Location = new System.Drawing.Point(15, 25);
            this.comboBoxCidadeOrigem.Name = "comboBoxCidadeOrigem";
            this.comboBoxCidadeOrigem.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCidadeOrigem.TabIndex = 2;
            // 
            // comboBoxCidadeDestino
            // 
            this.comboBoxCidadeDestino.FormattingEnabled = true;
            this.comboBoxCidadeDestino.Location = new System.Drawing.Point(229, 25);
            this.comboBoxCidadeDestino.Name = "comboBoxCidadeDestino";
            this.comboBoxCidadeDestino.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCidadeDestino.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(335, 212);
            this.listBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(335, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Realizar Busca";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nós Gerados:";
            // 
            // lblNosGerados
            // 
            this.lblNosGerados.AutoSize = true;
            this.lblNosGerados.Location = new System.Drawing.Point(90, 279);
            this.lblNosGerados.Name = "lblNosGerados";
            this.lblNosGerados.Size = new System.Drawing.Size(35, 13);
            this.lblNosGerados.TabIndex = 7;
            this.lblNosGerados.Text = "label4";
            // 
            // lblNosExpandidos
            // 
            this.lblNosExpandidos.AutoSize = true;
            this.lblNosExpandidos.Location = new System.Drawing.Point(270, 279);
            this.lblNosExpandidos.Name = "lblNosExpandidos";
            this.lblNosExpandidos.Size = new System.Drawing.Size(35, 13);
            this.lblNosExpandidos.TabIndex = 8;
            this.lblNosExpandidos.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nós Expandidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Passos Dados:";
            // 
            // lblPassosDados
            // 
            this.lblPassosDados.AutoSize = true;
            this.lblPassosDados.Location = new System.Drawing.Point(261, 310);
            this.lblPassosDados.Name = "lblPassosDados";
            this.lblPassosDados.Size = new System.Drawing.Size(35, 13);
            this.lblPassosDados.TabIndex = 11;
            this.lblPassosDados.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tempo:";
            // 
            // lblTempoExecucao
            // 
            this.lblTempoExecucao.AutoSize = true;
            this.lblTempoExecucao.Location = new System.Drawing.Point(90, 310);
            this.lblTempoExecucao.Name = "lblTempoExecucao";
            this.lblTempoExecucao.Size = new System.Drawing.Size(35, 13);
            this.lblTempoExecucao.TabIndex = 13;
            this.lblTempoExecucao.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 370);
            this.Controls.Add(this.lblTempoExecucao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPassosDados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNosExpandidos);
            this.Controls.Add(this.lblNosGerados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBoxCidadeDestino);
            this.Controls.Add(this.comboBoxCidadeOrigem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCidadeOrigem;
        private System.Windows.Forms.ComboBox comboBoxCidadeDestino;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNosGerados;
        private System.Windows.Forms.Label lblNosExpandidos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPassosDados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTempoExecucao;
    }
}

