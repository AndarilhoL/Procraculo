namespace BibliotecaOraculo
{
    partial class FormHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.pictureBox_IconHome = new System.Windows.Forms.PictureBox();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonListas = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.toolTipBarraSuperior = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_IconHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1008, 18);
            this.panelSuperior.TabIndex = 0;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            this.panelSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseMove);
            this.panelSuperior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseUp);
            // 
            // panelBotoes
            // 
            this.panelBotoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.panelBotoes.Controls.Add(this.pictureBox_IconHome);
            this.panelBotoes.Controls.Add(this.buttonSair);
            this.panelBotoes.Controls.Add(this.buttonHome);
            this.panelBotoes.Controls.Add(this.buttonListas);
            this.panelBotoes.Controls.Add(this.buttonCadastrar);
            this.panelBotoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBotoes.Location = new System.Drawing.Point(0, 18);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(197, 583);
            this.panelBotoes.TabIndex = 1;
            // 
            // pictureBox_IconHome
            // 
            this.pictureBox_IconHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_IconHome.Image")));
            this.pictureBox_IconHome.Location = new System.Drawing.Point(24, 6);
            this.pictureBox_IconHome.Name = "pictureBox_IconHome";
            this.pictureBox_IconHome.Size = new System.Drawing.Size(150, 150);
            this.pictureBox_IconHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_IconHome.TabIndex = 4;
            this.pictureBox_IconHome.TabStop = false;
            // 
            // buttonSair
            // 
            this.buttonSair.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.ForeColor = System.Drawing.Color.White;
            this.buttonSair.Location = new System.Drawing.Point(3, 523);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(191, 57);
            this.buttonSair.TabIndex = 3;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.buttonHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(0, 203);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(197, 51);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "Home";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonListas
            // 
            this.buttonListas.FlatAppearance.BorderSize = 0;
            this.buttonListas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.buttonListas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonListas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListas.Image = ((System.Drawing.Image)(resources.GetObject("buttonListas.Image")));
            this.buttonListas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonListas.Location = new System.Drawing.Point(0, 352);
            this.buttonListas.Name = "buttonListas";
            this.buttonListas.Size = new System.Drawing.Size(197, 51);
            this.buttonListas.TabIndex = 2;
            this.buttonListas.Text = "Listas";
            this.buttonListas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonListas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonListas.UseVisualStyleBackColor = true;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.FlatAppearance.BorderSize = 0;
            this.buttonCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.buttonCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCadastrar.Image")));
            this.buttonCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCadastrar.Location = new System.Drawing.Point(0, 276);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(197, 51);
            this.buttonCadastrar.TabIndex = 1;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(197, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 583);
            this.panel1.TabIndex = 2;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBotoes);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panelBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_IconHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelBotoes;
        private System.Windows.Forms.ToolTip toolTipBarraSuperior;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonListas;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonHome;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_IconHome;
    }
}

