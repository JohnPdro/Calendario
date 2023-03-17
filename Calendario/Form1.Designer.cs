namespace Calendario
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataInicial = new System.Windows.Forms.TextBox();
            this.txtDataAtual = new System.Windows.Forms.TextBox();
            this.txtDataFinal = new System.Windows.Forms.TextBox();
            this.btnSelecionarData = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtDataFinalTrsf = new System.Windows.Forms.TextBox();
            this.txtDataAtualTrsf = new System.Windows.Forms.TextBox();
            this.txtDataInicialTrsf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.White;
            this.monthCalendar1.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar1.MaxSelectionCount = 31;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(352, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(352, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Final:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(352, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data Atual:";
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataInicial.Location = new System.Drawing.Point(496, 49);
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Size = new System.Drawing.Size(213, 35);
            this.txtDataInicial.TabIndex = 4;
            // 
            // txtDataAtual
            // 
            this.txtDataAtual.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataAtual.Location = new System.Drawing.Point(497, 138);
            this.txtDataAtual.Name = "txtDataAtual";
            this.txtDataAtual.Size = new System.Drawing.Size(213, 35);
            this.txtDataAtual.TabIndex = 5;
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataFinal.Location = new System.Drawing.Point(496, 94);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(213, 35);
            this.txtDataFinal.TabIndex = 6;
            // 
            // btnSelecionarData
            // 
            this.btnSelecionarData.BackColor = System.Drawing.Color.Gray;
            this.btnSelecionarData.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSelecionarData.FlatAppearance.BorderSize = 2;
            this.btnSelecionarData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarData.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarData.ForeColor = System.Drawing.Color.Gold;
            this.btnSelecionarData.Location = new System.Drawing.Point(464, 407);
            this.btnSelecionarData.Name = "btnSelecionarData";
            this.btnSelecionarData.Size = new System.Drawing.Size(246, 45);
            this.btnSelecionarData.TabIndex = 7;
            this.btnSelecionarData.Text = "Selecionar Data";
            this.btnSelecionarData.UseVisualStyleBackColor = false;
            this.btnSelecionarData.Click += new System.EventHandler(this.btnSelecionarData_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Gray;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLimpar.FlatAppearance.BorderSize = 2;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Gold;
            this.btnLimpar.Location = new System.Drawing.Point(142, 407);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(150, 45);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtDataFinalTrsf
            // 
            this.txtDataFinalTrsf.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataFinalTrsf.Location = new System.Drawing.Point(496, 256);
            this.txtDataFinalTrsf.Name = "txtDataFinalTrsf";
            this.txtDataFinalTrsf.Size = new System.Drawing.Size(213, 35);
            this.txtDataFinalTrsf.TabIndex = 14;
            // 
            // txtDataAtualTrsf
            // 
            this.txtDataAtualTrsf.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataAtualTrsf.Location = new System.Drawing.Point(497, 300);
            this.txtDataAtualTrsf.Name = "txtDataAtualTrsf";
            this.txtDataAtualTrsf.Size = new System.Drawing.Size(213, 35);
            this.txtDataAtualTrsf.TabIndex = 13;
            this.txtDataAtualTrsf.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtDataInicialTrsf
            // 
            this.txtDataInicialTrsf.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataInicialTrsf.Location = new System.Drawing.Point(496, 211);
            this.txtDataInicialTrsf.Name = "txtDataInicialTrsf";
            this.txtDataInicialTrsf.Size = new System.Drawing.Size(213, 35);
            this.txtDataInicialTrsf.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(352, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Data Atual:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(352, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data Final:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(352, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Data Inicial:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(744, 476);
            this.Controls.Add(this.txtDataFinalTrsf);
            this.Controls.Add(this.txtDataAtualTrsf);
            this.Controls.Add(this.txtDataInicialTrsf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSelecionarData);
            this.Controls.Add(this.txtDataFinal);
            this.Controls.Add(this.txtDataAtual);
            this.Controls.Add(this.txtDataInicial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDataInicial;
        private System.Windows.Forms.TextBox txtDataAtual;
        private System.Windows.Forms.TextBox txtDataFinal;
        private System.Windows.Forms.Button btnSelecionarData;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtDataFinalTrsf;
        private System.Windows.Forms.TextBox txtDataAtualTrsf;
        private System.Windows.Forms.TextBox txtDataInicialTrsf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

