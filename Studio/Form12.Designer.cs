
namespace Studio
{
    partial class Form12
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
            this.btnReativar = new System.Windows.Forms.Button();
            this.cBoxAlunos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnReativar
            // 
            this.btnReativar.Location = new System.Drawing.Point(81, 95);
            this.btnReativar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReativar.Name = "btnReativar";
            this.btnReativar.Size = new System.Drawing.Size(228, 28);
            this.btnReativar.TabIndex = 0;
            this.btnReativar.Text = "Reativar";
            this.btnReativar.UseVisualStyleBackColor = true;
            this.btnReativar.Click += new System.EventHandler(this.btnReativar_Click);
            // 
            // cBoxAlunos
            // 
            this.cBoxAlunos.FormattingEnabled = true;
            this.cBoxAlunos.Location = new System.Drawing.Point(17, 39);
            this.cBoxAlunos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBoxAlunos.Name = "cBoxAlunos";
            this.cBoxAlunos.Size = new System.Drawing.Size(360, 24);
            this.cBoxAlunos.TabIndex = 1;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 171);
            this.Controls.Add(this.cBoxAlunos);
            this.Controls.Add(this.btnReativar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form12";
            this.Text = "Form12";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReativar;
        private System.Windows.Forms.ComboBox cBoxAlunos;
    }
}