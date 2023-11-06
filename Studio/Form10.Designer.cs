namespace Studio
{
    partial class Form10
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
            this.dataGridViewTurma = new System.Windows.Forms.DataGridView();
            this.NomeTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcBox2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcBox3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcBox4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcText5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewAluno = new System.Windows.Forms.DataGridView();
            this.txtcNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAlunoTable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMatricular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTurma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTurma
            // 
            this.dataGridViewTurma.AllowUserToAddRows = false;
            this.dataGridViewTurma.AllowUserToDeleteRows = false;
            this.dataGridViewTurma.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTurma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeTurma,
            this.txtcBox2,
            this.txtcBox3,
            this.txtcBox4,
            this.txtcText5});
            this.dataGridViewTurma.Location = new System.Drawing.Point(307, 43);
            this.dataGridViewTurma.Name = "dataGridViewTurma";
            this.dataGridViewTurma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTurma.Size = new System.Drawing.Size(570, 406);
            this.dataGridViewTurma.TabIndex = 0;
            this.dataGridViewTurma.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTurma_CellClick);
            // 
            // NomeTurma
            // 
            this.NomeTurma.HeaderText = "Nome Turma";
            this.NomeTurma.Name = "NomeTurma";
            this.NomeTurma.ReadOnly = true;
            // 
            // txtcBox2
            // 
            this.txtcBox2.HeaderText = "Professor";
            this.txtcBox2.Name = "txtcBox2";
            this.txtcBox2.ReadOnly = true;
            // 
            // txtcBox3
            // 
            this.txtcBox3.HeaderText = "Dia da Semana";
            this.txtcBox3.Name = "txtcBox3";
            this.txtcBox3.ReadOnly = true;
            // 
            // txtcBox4
            // 
            this.txtcBox4.HeaderText = "Horário";
            this.txtcBox4.Name = "txtcBox4";
            this.txtcBox4.ReadOnly = true;
            // 
            // txtcText5
            // 
            this.txtcText5.HeaderText = "Número de Matriculados";
            this.txtcText5.Name = "txtcText5";
            this.txtcText5.ReadOnly = true;
            // 
            // dataGridViewAluno
            // 
            this.dataGridViewAluno.AllowUserToAddRows = false;
            this.dataGridViewAluno.AllowUserToDeleteRows = false;
            this.dataGridViewAluno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtcNome});
            this.dataGridViewAluno.Location = new System.Drawing.Point(26, 43);
            this.dataGridViewAluno.Name = "dataGridViewAluno";
            this.dataGridViewAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAluno.Size = new System.Drawing.Size(240, 406);
            this.dataGridViewAluno.TabIndex = 1;
            this.dataGridViewAluno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAluno_CellClick);
            // 
            // txtcNome
            // 
            this.txtcNome.HeaderText = "Nome";
            this.txtcNome.Name = "txtcNome";
            this.txtcNome.ReadOnly = true;
            // 
            // lblAlunoTable
            // 
            this.lblAlunoTable.AutoSize = true;
            this.lblAlunoTable.Location = new System.Drawing.Point(98, 18);
            this.lblAlunoTable.Name = "lblAlunoTable";
            this.lblAlunoTable.Size = new System.Drawing.Size(87, 13);
            this.lblAlunoTable.TabIndex = 2;
            this.lblAlunoTable.Text = "Selecionar Aluno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecionar Turma";
            // 
            // btnMatricular
            // 
            this.btnMatricular.Location = new System.Drawing.Point(26, 455);
            this.btnMatricular.Name = "btnMatricular";
            this.btnMatricular.Size = new System.Drawing.Size(240, 53);
            this.btnMatricular.TabIndex = 4;
            this.btnMatricular.Text = "Matricular";
            this.btnMatricular.UseVisualStyleBackColor = true;
            this.btnMatricular.Click += new System.EventHandler(this.btnMatricular_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 520);
            this.Controls.Add(this.btnMatricular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAlunoTable);
            this.Controls.Add(this.dataGridViewAluno);
            this.Controls.Add(this.dataGridViewTurma);
            this.Name = "Form10";
            this.Text = "Form10";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTurma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTurma;
        private System.Windows.Forms.DataGridView dataGridViewAluno;
        private System.Windows.Forms.Label lblAlunoTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMatricular;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcText5;
    }
}