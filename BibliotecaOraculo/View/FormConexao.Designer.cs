namespace BibliotecaOraculo.View
{
    partial class FormConexao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConexao));
            this.pictureBoxImagem = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBancos = new System.Windows.Forms.ComboBox();
            this.textBoxStringConexao = new System.Windows.Forms.TextBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Testar = new System.Windows.Forms.Button();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.panelEsquerda = new System.Windows.Forms.Panel();
            this.panelDireita = new System.Windows.Forms.Panel();
            this.btn_Sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxImagem
            // 
            this.pictureBoxImagem.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxImagem.Image")));
            this.pictureBoxImagem.Location = new System.Drawing.Point(428, 46);
            this.pictureBoxImagem.Name = "pictureBoxImagem";
            this.pictureBoxImagem.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxImagem.TabIndex = 10;
            this.pictureBoxImagem.TabStop = false;
            this.pictureBoxImagem.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "String de Conexao";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Selecione o Banco de Dados";
            // 
            // comboBoxBancos
            // 
            this.comboBoxBancos.FormattingEnabled = true;
            this.comboBoxBancos.Items.AddRange(new object[] {
            "MySQL",
            "SQL Server"});
            this.comboBoxBancos.Location = new System.Drawing.Point(12, 46);
            this.comboBoxBancos.Name = "comboBoxBancos";
            this.comboBoxBancos.Size = new System.Drawing.Size(157, 21);
            this.comboBoxBancos.TabIndex = 7;
            this.comboBoxBancos.TextChanged += new System.EventHandler(this.comboBoxBancos_TextChanged);
            // 
            // textBoxStringConexao
            // 
            this.textBoxStringConexao.Location = new System.Drawing.Point(11, 88);
            this.textBoxStringConexao.Name = "textBoxStringConexao";
            this.textBoxStringConexao.Size = new System.Drawing.Size(285, 20);
            this.textBoxStringConexao.TabIndex = 6;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btn_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.ForeColor = System.Drawing.Color.White;
            this.btn_Salvar.Location = new System.Drawing.Point(11, 137);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(131, 29);
            this.btn_Salvar.TabIndex = 11;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = false;
            // 
            // btn_Testar
            // 
            this.btn_Testar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btn_Testar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Testar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Testar.ForeColor = System.Drawing.Color.White;
            this.btn_Testar.Location = new System.Drawing.Point(148, 137);
            this.btn_Testar.Name = "btn_Testar";
            this.btn_Testar.Size = new System.Drawing.Size(96, 29);
            this.btn_Testar.TabIndex = 12;
            this.btn_Testar.Text = "Testar";
            this.btn_Testar.UseVisualStyleBackColor = false;
            this.btn_Testar.Click += new System.EventHandler(this.button_Testar_Click);
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(521, 15);
            this.panelSuperior.TabIndex = 13;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            this.panelSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseMove);
            this.panelSuperior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseUp);
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 171);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(521, 5);
            this.panelInferior.TabIndex = 14;
            // 
            // panelEsquerda
            // 
            this.panelEsquerda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panelEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEsquerda.Location = new System.Drawing.Point(0, 15);
            this.panelEsquerda.Name = "panelEsquerda";
            this.panelEsquerda.Size = new System.Drawing.Size(5, 156);
            this.panelEsquerda.TabIndex = 15;
            // 
            // panelDireita
            // 
            this.panelDireita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panelDireita.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDireita.Location = new System.Drawing.Point(516, 15);
            this.panelDireita.Name = "panelDireita";
            this.panelDireita.Size = new System.Drawing.Size(5, 156);
            this.panelDireita.TabIndex = 16;
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.ForeColor = System.Drawing.Color.White;
            this.btn_Sair.Location = new System.Drawing.Point(413, 137);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(96, 29);
            this.btn_Sair.TabIndex = 17;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            // 
            // FormConexao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 176);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.panelDireita);
            this.Controls.Add(this.panelEsquerda);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.btn_Testar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.pictureBoxImagem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxBancos);
            this.Controls.Add(this.textBoxStringConexao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConexao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurar Conexão";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBancos;
        private System.Windows.Forms.TextBox textBoxStringConexao;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Testar;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Panel panelEsquerda;
        private System.Windows.Forms.Panel panelDireita;
        private System.Windows.Forms.Button btn_Sair;
    }
}