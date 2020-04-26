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
            this.toolTipBarraSuperior = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.button_BancoDados = new System.Windows.Forms.Button();
            this.pictureBox_IconHome = new System.Windows.Forms.PictureBox();
            this.button_Home = new System.Windows.Forms.Button();
            this.button_Listas = new System.Windows.Forms.Button();
            this.button_Cadastrar = new System.Windows.Forms.Button();
            this.buttonMinimizar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.panelSuperior.SuspendLayout();
            this.panelBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_IconHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panelSuperior.Controls.Add(this.buttonMinimizar);
            this.panelSuperior.Controls.Add(this.buttonSair);
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
            this.panelBotoes.Controls.Add(this.button_BancoDados);
            this.panelBotoes.Controls.Add(this.pictureBox_IconHome);
            this.panelBotoes.Controls.Add(this.button_Home);
            this.panelBotoes.Controls.Add(this.button_Listas);
            this.panelBotoes.Controls.Add(this.button_Cadastrar);
            this.panelBotoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBotoes.Location = new System.Drawing.Point(0, 18);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(197, 583);
            this.panelBotoes.TabIndex = 1;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(197, 18);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(811, 583);
            this.panelPrincipal.TabIndex = 2;
            // 
            // button_BancoDados
            // 
            this.button_BancoDados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_BancoDados.BackgroundImage")));
            this.button_BancoDados.FlatAppearance.BorderSize = 0;
            this.button_BancoDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_BancoDados.Location = new System.Drawing.Point(3, 556);
            this.button_BancoDados.Name = "button_BancoDados";
            this.button_BancoDados.Size = new System.Drawing.Size(24, 24);
            this.button_BancoDados.TabIndex = 5;
            this.button_BancoDados.UseVisualStyleBackColor = true;
            this.button_BancoDados.Click += new System.EventHandler(this.buttonBancoDados_Click);
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
            // button_Home
            // 
            this.button_Home.FlatAppearance.BorderSize = 0;
            this.button_Home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.button_Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.button_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Home.Image = ((System.Drawing.Image)(resources.GetObject("button_Home.Image")));
            this.button_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Home.Location = new System.Drawing.Point(0, 203);
            this.button_Home.Name = "button_Home";
            this.button_Home.Size = new System.Drawing.Size(197, 51);
            this.button_Home.TabIndex = 0;
            this.button_Home.Text = "Home";
            this.button_Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Home.UseVisualStyleBackColor = true;
            this.button_Home.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // button_Listas
            // 
            this.button_Listas.FlatAppearance.BorderSize = 0;
            this.button_Listas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.button_Listas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Listas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Listas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Listas.Image = ((System.Drawing.Image)(resources.GetObject("button_Listas.Image")));
            this.button_Listas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Listas.Location = new System.Drawing.Point(0, 352);
            this.button_Listas.Name = "button_Listas";
            this.button_Listas.Size = new System.Drawing.Size(197, 51);
            this.button_Listas.TabIndex = 2;
            this.button_Listas.Text = "Listas";
            this.button_Listas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Listas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Listas.UseVisualStyleBackColor = true;
            this.button_Listas.Click += new System.EventHandler(this.buttonListas_Click);
            // 
            // button_Cadastrar
            // 
            this.button_Cadastrar.FlatAppearance.BorderSize = 0;
            this.button_Cadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.button_Cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cadastrar.Image = ((System.Drawing.Image)(resources.GetObject("button_Cadastrar.Image")));
            this.button_Cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Cadastrar.Location = new System.Drawing.Point(0, 276);
            this.button_Cadastrar.Name = "button_Cadastrar";
            this.button_Cadastrar.Size = new System.Drawing.Size(197, 51);
            this.button_Cadastrar.TabIndex = 1;
            this.button_Cadastrar.Text = "Cadastrar";
            this.button_Cadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Cadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Cadastrar.UseVisualStyleBackColor = true;
            this.button_Cadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonMinimizar
            // 
            this.buttonMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMinimizar.BackgroundImage")));
            this.buttonMinimizar.FlatAppearance.BorderSize = 0;
            this.buttonMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimizar.Location = new System.Drawing.Point(962, 0);
            this.buttonMinimizar.Name = "buttonMinimizar";
            this.buttonMinimizar.Size = new System.Drawing.Size(16, 16);
            this.buttonMinimizar.TabIndex = 0;
            this.buttonMinimizar.UseVisualStyleBackColor = true;
            this.buttonMinimizar.Click += new System.EventHandler(this.buttonMinimizar_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.buttonSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSair.BackgroundImage")));
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSair.Location = new System.Drawing.Point(984, 0);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(16, 16);
            this.buttonSair.TabIndex = 3;
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelBotoes);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panelSuperior.ResumeLayout(false);
            this.panelBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_IconHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelBotoes;
        private System.Windows.Forms.ToolTip toolTipBarraSuperior;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button button_Listas;
        private System.Windows.Forms.Button button_Cadastrar;
        private System.Windows.Forms.Button button_Home;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.PictureBox pictureBox_IconHome;
        private System.Windows.Forms.Button button_BancoDados;
        private System.Windows.Forms.Button buttonMinimizar;
    }
}

