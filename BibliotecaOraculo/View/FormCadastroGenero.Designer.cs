namespace BibliotecaOraculo.View
{
    partial class FormCadastroGenero
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
            this.labelGenero = new System.Windows.Forms.Label();
            this.textBox_Genero = new System.Windows.Forms.TextBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenero.Location = new System.Drawing.Point(11, 9);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(154, 20);
            this.labelGenero.TabIndex = 0;
            this.labelGenero.Text = "Descrição Gênero";
            // 
            // textBox_Genero
            // 
            this.textBox_Genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Genero.Location = new System.Drawing.Point(15, 32);
            this.textBox_Genero.Multiline = true;
            this.textBox_Genero.Name = "textBox_Genero";
            this.textBox_Genero.Size = new System.Drawing.Size(289, 27);
            this.textBox_Genero.TabIndex = 1;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btn_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.ForeColor = System.Drawing.Color.White;
            this.btn_Salvar.Location = new System.Drawing.Point(15, 109);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(158, 39);
            this.btn_Salvar.TabIndex = 12;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = false;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.ForeColor = System.Drawing.Color.White;
            this.btn_Sair.Location = new System.Drawing.Point(400, 119);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(96, 29);
            this.btn_Sair.TabIndex = 18;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            // 
            // FormCadastroGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 158);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.textBox_Genero);
            this.Controls.Add(this.labelGenero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCadastroGenero";
            this.Text = "FormCadastroGenero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.TextBox textBox_Genero;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Sair;
    }
}