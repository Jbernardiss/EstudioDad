
namespace Studio
{
    partial class Form8
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.cBoxHora = new System.Windows.Forms.ComboBox();
            this.cBoxDiaDaSemana = new System.Windows.Forms.ComboBox();
            this.cBoxModalidade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.cBoxHora);
            this.groupBox1.Controls.Add(this.cBoxDiaDaSemana);
            this.groupBox1.Controls.Add(this.cBoxModalidade);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turma";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(6, 150);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(540, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // cBoxHora
            // 
            this.cBoxHora.Enabled = false;
            this.cBoxHora.FormattingEnabled = true;
            this.cBoxHora.Location = new System.Drawing.Point(101, 105);
            this.cBoxHora.Name = "cBoxHora";
            this.cBoxHora.Size = new System.Drawing.Size(429, 21);
            this.cBoxHora.TabIndex = 5;
            // 
            // cBoxDiaDaSemana
            // 
            this.cBoxDiaDaSemana.Enabled = false;
            this.cBoxDiaDaSemana.FormattingEnabled = true;
            this.cBoxDiaDaSemana.Location = new System.Drawing.Point(101, 67);
            this.cBoxDiaDaSemana.Name = "cBoxDiaDaSemana";
            this.cBoxDiaDaSemana.Size = new System.Drawing.Size(429, 21);
            this.cBoxDiaDaSemana.TabIndex = 4;
            this.cBoxDiaDaSemana.SelectedIndexChanged += new System.EventHandler(this.cBoxDiaDaSemana_SelectedIndexChanged);
            // 
            // cBoxModalidade
            // 
            this.cBoxModalidade.FormattingEnabled = true;
            this.cBoxModalidade.Location = new System.Drawing.Point(101, 33);
            this.cBoxModalidade.Name = "cBoxModalidade";
            this.cBoxModalidade.Size = new System.Drawing.Size(429, 21);
            this.cBoxModalidade.TabIndex = 3;
            this.cBoxModalidade.SelectedIndexChanged += new System.EventHandler(this.cBoxModalidade_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dia da Semana:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modalidade:";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 201);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ComboBox cBoxHora;
        private System.Windows.Forms.ComboBox cBoxDiaDaSemana;
        private System.Windows.Forms.ComboBox cBoxModalidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}