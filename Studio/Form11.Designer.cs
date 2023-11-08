
namespace Studio
{
    partial class Form11
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
            this.dataGridViewAlunos = new System.Windows.Forms.DataGridView();
            this.txtcAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxTurmas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.txtDiaSemana = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtQtdeAlunos = new System.Windows.Forms.TextBox();
            this.lblQtdeAlunos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAlunos
            // 
            this.dataGridViewAlunos.AllowUserToAddRows = false;
            this.dataGridViewAlunos.AllowUserToDeleteRows = false;
            this.dataGridViewAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtcAluno});
            this.dataGridViewAlunos.Location = new System.Drawing.Point(12, 132);
            this.dataGridViewAlunos.Name = "dataGridViewAlunos";
            this.dataGridViewAlunos.Size = new System.Drawing.Size(308, 409);
            this.dataGridViewAlunos.TabIndex = 0;
            // 
            // txtcAluno
            // 
            this.txtcAluno.HeaderText = "Aluno";
            this.txtcAluno.Name = "txtcAluno";
            this.txtcAluno.ReadOnly = true;
            // 
            // comboBoxTurmas
            // 
            this.comboBoxTurmas.FormattingEnabled = true;
            this.comboBoxTurmas.Location = new System.Drawing.Point(58, 12);
            this.comboBoxTurmas.Name = "comboBoxTurmas";
            this.comboBoxTurmas.Size = new System.Drawing.Size(262, 21);
            this.comboBoxTurmas.TabIndex = 1;
            this.comboBoxTurmas.SelectedIndexChanged += new System.EventHandler(this.comboBoxTurmas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Turma: ";
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.AutoSize = true;
            this.lblDiaSemana.Location = new System.Drawing.Point(12, 42);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(83, 13);
            this.lblDiaSemana.TabIndex = 3;
            this.lblDiaSemana.Text = "Dia da Semana:";
            // 
            // txtDiaSemana
            // 
            this.txtDiaSemana.Location = new System.Drawing.Point(101, 39);
            this.txtDiaSemana.Name = "txtDiaSemana";
            this.txtDiaSemana.ReadOnly = true;
            this.txtDiaSemana.Size = new System.Drawing.Size(219, 20);
            this.txtDiaSemana.TabIndex = 4;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(12, 68);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(36, 13);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "Hora: ";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(101, 65);
            this.txtHora.Name = "txtHora";
            this.txtHora.ReadOnly = true;
            this.txtHora.Size = new System.Drawing.Size(219, 20);
            this.txtHora.TabIndex = 6;
            // 
            // txtQtdeAlunos
            // 
            this.txtQtdeAlunos.Location = new System.Drawing.Point(101, 91);
            this.txtQtdeAlunos.Name = "txtQtdeAlunos";
            this.txtQtdeAlunos.ReadOnly = true;
            this.txtQtdeAlunos.Size = new System.Drawing.Size(219, 20);
            this.txtQtdeAlunos.TabIndex = 7;
            // 
            // lblQtdeAlunos
            // 
            this.lblQtdeAlunos.AutoSize = true;
            this.lblQtdeAlunos.Location = new System.Drawing.Point(12, 94);
            this.lblQtdeAlunos.Name = "lblQtdeAlunos";
            this.lblQtdeAlunos.Size = new System.Drawing.Size(74, 13);
            this.lblQtdeAlunos.TabIndex = 8;
            this.lblQtdeAlunos.Text = "Qtde. Alunos: ";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 553);
            this.Controls.Add(this.lblQtdeAlunos);
            this.Controls.Add(this.txtQtdeAlunos);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.txtDiaSemana);
            this.Controls.Add(this.lblDiaSemana);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTurmas);
            this.Controls.Add(this.dataGridViewAlunos);
            this.Name = "Form11";
            this.Text = "Form11";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAlunos;
        private System.Windows.Forms.ComboBox comboBoxTurmas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcAluno;
        private System.Windows.Forms.Label lblDiaSemana;
        private System.Windows.Forms.TextBox txtDiaSemana;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtQtdeAlunos;
        private System.Windows.Forms.Label lblQtdeAlunos;
    }
}