namespace BibliotecaOraculo.View
{
    partial class UserControlListaGeneros
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_Generos = new System.Windows.Forms.DataGridView();
            this.groupBoxListaGeneros = new System.Windows.Forms.GroupBox();
            this.groupBoxBotoes = new System.Windows.Forms.GroupBox();
            this.button_Sair = new System.Windows.Forms.Button();
            this.button_Salvar = new System.Windows.Forms.Button();
            this.button_Alterar = new System.Windows.Forms.Button();
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.tableLayoutPanelFormListaGeneros = new System.Windows.Forms.TableLayoutPanel();
            this.panelGridListaGeneros = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Generos)).BeginInit();
            this.groupBoxListaGeneros.SuspendLayout();
            this.groupBoxBotoes.SuspendLayout();
            this.panelBotoes.SuspendLayout();
            this.tableLayoutPanelFormListaGeneros.SuspendLayout();
            this.panelGridListaGeneros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Generos
            // 
            this.dataGridView_Generos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Generos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Generos.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_Generos.Name = "dataGridView_Generos";
            this.dataGridView_Generos.Size = new System.Drawing.Size(799, 479);
            this.dataGridView_Generos.TabIndex = 0;
            // 
            // groupBoxListaGeneros
            // 
            this.groupBoxListaGeneros.Controls.Add(this.dataGridView_Generos);
            this.groupBoxListaGeneros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxListaGeneros.Location = new System.Drawing.Point(0, 0);
            this.groupBoxListaGeneros.Name = "groupBoxListaGeneros";
            this.groupBoxListaGeneros.Size = new System.Drawing.Size(805, 498);
            this.groupBoxListaGeneros.TabIndex = 1;
            this.groupBoxListaGeneros.TabStop = false;
            this.groupBoxListaGeneros.Text = "Lista Generos";
            // 
            // groupBoxBotoes
            // 
            this.groupBoxBotoes.Controls.Add(this.button_Sair);
            this.groupBoxBotoes.Controls.Add(this.button_Salvar);
            this.groupBoxBotoes.Controls.Add(this.button_Alterar);
            this.groupBoxBotoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBotoes.Location = new System.Drawing.Point(0, 0);
            this.groupBoxBotoes.Name = "groupBoxBotoes";
            this.groupBoxBotoes.Size = new System.Drawing.Size(805, 73);
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
            this.button_Sair.Location = new System.Drawing.Point(649, 35);
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
            this.button_Salvar.Location = new System.Drawing.Point(6, 15);
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
            this.button_Alterar.Location = new System.Drawing.Point(170, 15);
            this.button_Alterar.Name = "button_Alterar";
            this.button_Alterar.Size = new System.Drawing.Size(155, 52);
            this.button_Alterar.TabIndex = 1;
            this.button_Alterar.Text = "Alterar";
            this.button_Alterar.UseVisualStyleBackColor = false;
            // 
            // panelBotoes
            // 
            this.panelBotoes.Controls.Add(this.groupBoxBotoes);
            this.panelBotoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBotoes.Location = new System.Drawing.Point(3, 507);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(805, 73);
            this.panelBotoes.TabIndex = 2;
            // 
            // tableLayoutPanelFormListaGeneros
            // 
            this.tableLayoutPanelFormListaGeneros.ColumnCount = 1;
            this.tableLayoutPanelFormListaGeneros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFormListaGeneros.Controls.Add(this.panelBotoes, 0, 1);
            this.tableLayoutPanelFormListaGeneros.Controls.Add(this.panelGridListaGeneros, 0, 0);
            this.tableLayoutPanelFormListaGeneros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFormListaGeneros.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelFormListaGeneros.Name = "tableLayoutPanelFormListaGeneros";
            this.tableLayoutPanelFormListaGeneros.RowCount = 2;
            this.tableLayoutPanelFormListaGeneros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.4494F));
            this.tableLayoutPanelFormListaGeneros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.5506F));
            this.tableLayoutPanelFormListaGeneros.Size = new System.Drawing.Size(811, 583);
            this.tableLayoutPanelFormListaGeneros.TabIndex = 3;
            // 
            // panelGridListaGeneros
            // 
            this.panelGridListaGeneros.Controls.Add(this.groupBoxListaGeneros);
            this.panelGridListaGeneros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridListaGeneros.Location = new System.Drawing.Point(3, 3);
            this.panelGridListaGeneros.Name = "panelGridListaGeneros";
            this.panelGridListaGeneros.Size = new System.Drawing.Size(805, 498);
            this.panelGridListaGeneros.TabIndex = 3;
            // 
            // UserControlListaGeneros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelFormListaGeneros);
            this.Name = "UserControlListaGeneros";
            this.Size = new System.Drawing.Size(811, 583);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Generos)).EndInit();
            this.groupBoxListaGeneros.ResumeLayout(false);
            this.groupBoxBotoes.ResumeLayout(false);
            this.panelBotoes.ResumeLayout(false);
            this.tableLayoutPanelFormListaGeneros.ResumeLayout(false);
            this.panelGridListaGeneros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView_Generos;
        private System.Windows.Forms.GroupBox groupBoxListaGeneros;
        private System.Windows.Forms.GroupBox groupBoxBotoes;
        private System.Windows.Forms.Button button_Alterar;
        private System.Windows.Forms.Button button_Salvar;
        private System.Windows.Forms.Panel panelBotoes;
        private System.Windows.Forms.Button button_Sair;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFormListaGeneros;
        private System.Windows.Forms.Panel panelGridListaGeneros;
    }
}
