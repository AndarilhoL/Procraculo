namespace BibliotecaOraculo.View
{
    partial class Form_ListaGeneros
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
            this.tableLayoutPanelFormListaGeneros = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxBotoes = new System.Windows.Forms.GroupBox();
            this.button_Sair = new System.Windows.Forms.Button();
            this.button_Salvar = new System.Windows.Forms.Button();
            this.button_Alterar = new System.Windows.Forms.Button();
            this.panel_ListaGeneros = new System.Windows.Forms.Panel();
            this.groupBoxListaGeneros = new System.Windows.Forms.GroupBox();
            this.dataGridView_Generos = new System.Windows.Forms.DataGridView();
            this.groupBox_DadosGeneros = new System.Windows.Forms.GroupBox();
            this.textBox_Generos = new System.Windows.Forms.TextBox();
            this.label_Generos = new System.Windows.Forms.Label();
            this.panel_Superior = new System.Windows.Forms.Panel();
            this.panel_Principal = new System.Windows.Forms.Panel();
            this.tableLayoutPanelFormListaGeneros.SuspendLayout();
            this.groupBoxBotoes.SuspendLayout();
            this.panel_ListaGeneros.SuspendLayout();
            this.groupBoxListaGeneros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Generos)).BeginInit();
            this.groupBox_DadosGeneros.SuspendLayout();
            this.panel_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelFormListaGeneros
            // 
            this.tableLayoutPanelFormListaGeneros.ColumnCount = 1;
            this.tableLayoutPanelFormListaGeneros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFormListaGeneros.Controls.Add(this.groupBoxBotoes, 0, 1);
            this.tableLayoutPanelFormListaGeneros.Controls.Add(this.panel_ListaGeneros, 0, 0);
            this.tableLayoutPanelFormListaGeneros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFormListaGeneros.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelFormListaGeneros.Name = "tableLayoutPanelFormListaGeneros";
            this.tableLayoutPanelFormListaGeneros.RowCount = 2;
            this.tableLayoutPanelFormListaGeneros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.37755F));
            this.tableLayoutPanelFormListaGeneros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.62245F));
            this.tableLayoutPanelFormListaGeneros.Size = new System.Drawing.Size(827, 392);
            this.tableLayoutPanelFormListaGeneros.TabIndex = 4;
            // 
            // groupBoxBotoes
            // 
            this.groupBoxBotoes.Controls.Add(this.button_Sair);
            this.groupBoxBotoes.Controls.Add(this.button_Salvar);
            this.groupBoxBotoes.Controls.Add(this.button_Alterar);
            this.groupBoxBotoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBotoes.Location = new System.Drawing.Point(3, 321);
            this.groupBoxBotoes.Name = "groupBoxBotoes";
            this.groupBoxBotoes.Size = new System.Drawing.Size(821, 68);
            this.groupBoxBotoes.TabIndex = 2;
            this.groupBoxBotoes.TabStop = false;
            // 
            // button_Sair
            // 
            this.button_Sair.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.button_Sair.FlatAppearance.BorderSize = 0;
            this.button_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sair.ForeColor = System.Drawing.Color.White;
            this.button_Sair.Location = new System.Drawing.Point(666, 30);
            this.button_Sair.Name = "button_Sair";
            this.button_Sair.Size = new System.Drawing.Size(150, 32);
            this.button_Sair.TabIndex = 13;
            this.button_Sair.Text = "Sair";
            this.button_Sair.UseVisualStyleBackColor = false;
            this.button_Sair.Click += new System.EventHandler(this.button_Sair_Click);
            // 
            // button_Salvar
            // 
            this.button_Salvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.button_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Salvar.ForeColor = System.Drawing.Color.White;
            this.button_Salvar.Location = new System.Drawing.Point(5, 13);
            this.button_Salvar.Name = "button_Salvar";
            this.button_Salvar.Size = new System.Drawing.Size(158, 52);
            this.button_Salvar.TabIndex = 12;
            this.button_Salvar.Text = "Salvar";
            this.button_Salvar.UseVisualStyleBackColor = false;
            // 
            // button_Alterar
            // 
            this.button_Alterar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Alterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(203)))), ((int)(((byte)(110)))));
            this.button_Alterar.FlatAppearance.BorderSize = 0;
            this.button_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Alterar.ForeColor = System.Drawing.Color.White;
            this.button_Alterar.Location = new System.Drawing.Point(169, 13);
            this.button_Alterar.Name = "button_Alterar";
            this.button_Alterar.Size = new System.Drawing.Size(155, 52);
            this.button_Alterar.TabIndex = 1;
            this.button_Alterar.Text = "Alterar";
            this.button_Alterar.UseVisualStyleBackColor = false;
            this.button_Alterar.Click += new System.EventHandler(this.button_Alterar_Click);
            // 
            // panel_ListaGeneros
            // 
            this.panel_ListaGeneros.Controls.Add(this.groupBoxListaGeneros);
            this.panel_ListaGeneros.Controls.Add(this.groupBox_DadosGeneros);
            this.panel_ListaGeneros.Location = new System.Drawing.Point(3, 3);
            this.panel_ListaGeneros.Name = "panel_ListaGeneros";
            this.panel_ListaGeneros.Size = new System.Drawing.Size(821, 311);
            this.panel_ListaGeneros.TabIndex = 4;
            // 
            // groupBoxListaGeneros
            // 
            this.groupBoxListaGeneros.Controls.Add(this.dataGridView_Generos);
            this.groupBoxListaGeneros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxListaGeneros.Location = new System.Drawing.Point(200, 0);
            this.groupBoxListaGeneros.Name = "groupBoxListaGeneros";
            this.groupBoxListaGeneros.Size = new System.Drawing.Size(621, 311);
            this.groupBoxListaGeneros.TabIndex = 4;
            this.groupBoxListaGeneros.TabStop = false;
            this.groupBoxListaGeneros.Text = "Lista Generos";
            // 
            // dataGridView_Generos
            // 
            this.dataGridView_Generos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Generos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Generos.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_Generos.Name = "dataGridView_Generos";
            this.dataGridView_Generos.Size = new System.Drawing.Size(615, 292);
            this.dataGridView_Generos.TabIndex = 0;
            this.dataGridView_Generos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Generos_CellClick);
            this.dataGridView_Generos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Generos_CellDoubleClick);
            // 
            // groupBox_DadosGeneros
            // 
            this.groupBox_DadosGeneros.Controls.Add(this.textBox_Generos);
            this.groupBox_DadosGeneros.Controls.Add(this.label_Generos);
            this.groupBox_DadosGeneros.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox_DadosGeneros.Location = new System.Drawing.Point(0, 0);
            this.groupBox_DadosGeneros.Name = "groupBox_DadosGeneros";
            this.groupBox_DadosGeneros.Size = new System.Drawing.Size(200, 311);
            this.groupBox_DadosGeneros.TabIndex = 3;
            this.groupBox_DadosGeneros.TabStop = false;
            this.groupBox_DadosGeneros.Text = "Generos";
            // 
            // textBox_Generos
            // 
            this.textBox_Generos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Generos.Location = new System.Drawing.Point(6, 46);
            this.textBox_Generos.Name = "textBox_Generos";
            this.textBox_Generos.Size = new System.Drawing.Size(188, 21);
            this.textBox_Generos.TabIndex = 0;
            // 
            // label_Generos
            // 
            this.label_Generos.AutoSize = true;
            this.label_Generos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Generos.Location = new System.Drawing.Point(3, 28);
            this.label_Generos.Name = "label_Generos";
            this.label_Generos.Size = new System.Drawing.Size(71, 15);
            this.label_Generos.TabIndex = 1;
            this.label_Generos.Text = "Descrição";
            // 
            // panel_Superior
            // 
            this.panel_Superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panel_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Superior.Location = new System.Drawing.Point(0, 0);
            this.panel_Superior.Name = "panel_Superior";
            this.panel_Superior.Size = new System.Drawing.Size(827, 16);
            this.panel_Superior.TabIndex = 5;
            this.panel_Superior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Superior_MouseDown);
            this.panel_Superior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Superior_MouseMove);
            this.panel_Superior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Superior_MouseUp);
            // 
            // panel_Principal
            // 
            this.panel_Principal.Controls.Add(this.tableLayoutPanelFormListaGeneros);
            this.panel_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Principal.Location = new System.Drawing.Point(0, 16);
            this.panel_Principal.Name = "panel_Principal";
            this.panel_Principal.Size = new System.Drawing.Size(827, 392);
            this.panel_Principal.TabIndex = 6;
            // 
            // Form_ListaGeneros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 408);
            this.Controls.Add(this.panel_Principal);
            this.Controls.Add(this.panel_Superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ListaGeneros";
            this.Text = "Form_ListaGeneros";
            this.Load += new System.EventHandler(this.Form_ListaGeneros_Load);
            this.tableLayoutPanelFormListaGeneros.ResumeLayout(false);
            this.groupBoxBotoes.ResumeLayout(false);
            this.panel_ListaGeneros.ResumeLayout(false);
            this.groupBoxListaGeneros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Generos)).EndInit();
            this.groupBox_DadosGeneros.ResumeLayout(false);
            this.groupBox_DadosGeneros.PerformLayout();
            this.panel_Principal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFormListaGeneros;
        private System.Windows.Forms.Panel panel_ListaGeneros;
        private System.Windows.Forms.GroupBox groupBox_DadosGeneros;
        private System.Windows.Forms.TextBox textBox_Generos;
        private System.Windows.Forms.Label label_Generos;
        private System.Windows.Forms.GroupBox groupBoxListaGeneros;
        public System.Windows.Forms.DataGridView dataGridView_Generos;
        private System.Windows.Forms.Panel panel_Superior;
        private System.Windows.Forms.GroupBox groupBoxBotoes;
        private System.Windows.Forms.Button button_Sair;
        private System.Windows.Forms.Button button_Salvar;
        private System.Windows.Forms.Button button_Alterar;
        private System.Windows.Forms.Panel panel_Principal;
    }
}