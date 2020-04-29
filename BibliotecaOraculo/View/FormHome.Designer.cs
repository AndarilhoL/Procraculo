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
            this.buttonMinimizar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.button_Listas = new System.Windows.Forms.Button();
            this.button_BancoDados = new System.Windows.Forms.Button();
            this.panel_BotoesCad = new System.Windows.Forms.Panel();
            this.button_CadastrarGeneros = new System.Windows.Forms.Button();
            this.button_CadastrarAnimes = new System.Windows.Forms.Button();
            this.button_CadastrarSeriados = new System.Windows.Forms.Button();
            this.button_CadastrarFilmes = new System.Windows.Forms.Button();
            this.button_Cadastrar = new System.Windows.Forms.Button();
            this.button_Home = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox_IconHome = new System.Windows.Forms.PictureBox();
            this.toolTipBarraSuperior = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelSuperior.SuspendLayout();
            this.panelMenuLateral.SuspendLayout();
            this.panel_BotoesCad.SuspendLayout();
            this.panelLogo.SuspendLayout();
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
            // panelMenuLateral
            // 
            this.panelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.panelMenuLateral.Controls.Add(this.button_Listas);
            this.panelMenuLateral.Controls.Add(this.button_BancoDados);
            this.panelMenuLateral.Controls.Add(this.panel_BotoesCad);
            this.panelMenuLateral.Controls.Add(this.button_Cadastrar);
            this.panelMenuLateral.Controls.Add(this.button_Home);
            this.panelMenuLateral.Controls.Add(this.panelLogo);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 18);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(207, 583);
            this.panelMenuLateral.TabIndex = 1;
            // 
            // button_Listas
            // 
            this.button_Listas.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Listas.FlatAppearance.BorderSize = 0;
            this.button_Listas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Listas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Listas.ForeColor = System.Drawing.Color.White;
            this.button_Listas.Image = global::BibliotecaOraculo.Properties.Resources.lista_32x32;
            this.button_Listas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Listas.Location = new System.Drawing.Point(0, 490);
            this.button_Listas.Name = "button_Listas";
            this.button_Listas.Size = new System.Drawing.Size(207, 52);
            this.button_Listas.TabIndex = 7;
            this.button_Listas.Text = "Listas";
            this.button_Listas.UseVisualStyleBackColor = true;
            this.button_Listas.Click += new System.EventHandler(this.button_Listass_Click);
            // 
            // button_BancoDados
            // 
            this.button_BancoDados.BackgroundImage = global::BibliotecaOraculo.Properties.Resources.database_24x24;
            this.button_BancoDados.FlatAppearance.BorderSize = 0;
            this.button_BancoDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_BancoDados.Location = new System.Drawing.Point(3, 556);
            this.button_BancoDados.Name = "button_BancoDados";
            this.button_BancoDados.Size = new System.Drawing.Size(24, 24);
            this.button_BancoDados.TabIndex = 5;
            this.button_BancoDados.UseVisualStyleBackColor = true;
            this.button_BancoDados.Click += new System.EventHandler(this.buttonBancoDados_Click);
            // 
            // panel_BotoesCad
            // 
            this.panel_BotoesCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.panel_BotoesCad.Controls.Add(this.button_CadastrarGeneros);
            this.panel_BotoesCad.Controls.Add(this.button_CadastrarAnimes);
            this.panel_BotoesCad.Controls.Add(this.button_CadastrarSeriados);
            this.panel_BotoesCad.Controls.Add(this.button_CadastrarFilmes);
            this.panel_BotoesCad.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_BotoesCad.Location = new System.Drawing.Point(0, 276);
            this.panel_BotoesCad.Name = "panel_BotoesCad";
            this.panel_BotoesCad.Size = new System.Drawing.Size(207, 214);
            this.panel_BotoesCad.TabIndex = 6;
            // 
            // button_CadastrarGeneros
            // 
            this.button_CadastrarGeneros.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_CadastrarGeneros.FlatAppearance.BorderSize = 0;
            this.button_CadastrarGeneros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CadastrarGeneros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CadastrarGeneros.Location = new System.Drawing.Point(0, 156);
            this.button_CadastrarGeneros.Name = "button_CadastrarGeneros";
            this.button_CadastrarGeneros.Size = new System.Drawing.Size(207, 52);
            this.button_CadastrarGeneros.TabIndex = 3;
            this.button_CadastrarGeneros.Text = "Generos";
            this.button_CadastrarGeneros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_CadastrarGeneros.UseVisualStyleBackColor = true;
            this.button_CadastrarGeneros.Click += new System.EventHandler(this.button_CadastrarGeneros_Click);
            // 
            // button_CadastrarAnimes
            // 
            this.button_CadastrarAnimes.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_CadastrarAnimes.FlatAppearance.BorderSize = 0;
            this.button_CadastrarAnimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CadastrarAnimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CadastrarAnimes.Location = new System.Drawing.Point(0, 104);
            this.button_CadastrarAnimes.Name = "button_CadastrarAnimes";
            this.button_CadastrarAnimes.Size = new System.Drawing.Size(207, 52);
            this.button_CadastrarAnimes.TabIndex = 2;
            this.button_CadastrarAnimes.Text = "Animes";
            this.button_CadastrarAnimes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_CadastrarAnimes.UseVisualStyleBackColor = true;
            // 
            // button_CadastrarSeriados
            // 
            this.button_CadastrarSeriados.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_CadastrarSeriados.FlatAppearance.BorderSize = 0;
            this.button_CadastrarSeriados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CadastrarSeriados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CadastrarSeriados.Location = new System.Drawing.Point(0, 52);
            this.button_CadastrarSeriados.Name = "button_CadastrarSeriados";
            this.button_CadastrarSeriados.Size = new System.Drawing.Size(207, 52);
            this.button_CadastrarSeriados.TabIndex = 1;
            this.button_CadastrarSeriados.Text = "Seriados";
            this.button_CadastrarSeriados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_CadastrarSeriados.UseVisualStyleBackColor = true;
            // 
            // button_CadastrarFilmes
            // 
            this.button_CadastrarFilmes.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_CadastrarFilmes.FlatAppearance.BorderSize = 0;
            this.button_CadastrarFilmes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CadastrarFilmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CadastrarFilmes.Location = new System.Drawing.Point(0, 0);
            this.button_CadastrarFilmes.Name = "button_CadastrarFilmes";
            this.button_CadastrarFilmes.Size = new System.Drawing.Size(207, 52);
            this.button_CadastrarFilmes.TabIndex = 0;
            this.button_CadastrarFilmes.Text = "Filmes";
            this.button_CadastrarFilmes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_CadastrarFilmes.UseVisualStyleBackColor = true;
            // 
            // button_Cadastrar
            // 
            this.button_Cadastrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Cadastrar.FlatAppearance.BorderSize = 0;
            this.button_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cadastrar.ForeColor = System.Drawing.Color.White;
            this.button_Cadastrar.Image = global::BibliotecaOraculo.Properties.Resources.write_32x32;
            this.button_Cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Cadastrar.Location = new System.Drawing.Point(0, 218);
            this.button_Cadastrar.Name = "button_Cadastrar";
            this.button_Cadastrar.Size = new System.Drawing.Size(207, 58);
            this.button_Cadastrar.TabIndex = 2;
            this.button_Cadastrar.Text = "Cadastrar";
            this.button_Cadastrar.UseVisualStyleBackColor = true;
            this.button_Cadastrar.Click += new System.EventHandler(this.button_Cadastrar_Click);
            // 
            // button_Home
            // 
            this.button_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Home.FlatAppearance.BorderSize = 0;
            this.button_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Home.ForeColor = System.Drawing.Color.White;
            this.button_Home.Image = global::BibliotecaOraculo.Properties.Resources.home_run_32x32;
            this.button_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Home.Location = new System.Drawing.Point(0, 160);
            this.button_Home.Name = "button_Home";
            this.button_Home.Size = new System.Drawing.Size(207, 58);
            this.button_Home.TabIndex = 1;
            this.button_Home.Text = "Home";
            this.button_Home.UseVisualStyleBackColor = true;
            this.button_Home.Click += new System.EventHandler(this.button_Home_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox_IconHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(207, 160);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox_IconHome
            // 
            this.pictureBox_IconHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_IconHome.Image")));
            this.pictureBox_IconHome.Location = new System.Drawing.Point(29, 4);
            this.pictureBox_IconHome.Name = "pictureBox_IconHome";
            this.pictureBox_IconHome.Size = new System.Drawing.Size(150, 150);
            this.pictureBox_IconHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_IconHome.TabIndex = 4;
            this.pictureBox_IconHome.TabStop = false;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(207, 18);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(801, 583);
            this.panelPrincipal.TabIndex = 2;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelMenuLateral);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panelSuperior.ResumeLayout(false);
            this.panelMenuLateral.ResumeLayout(false);
            this.panel_BotoesCad.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_IconHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.ToolTip toolTipBarraSuperior;
        private System.Windows.Forms.Button buttonSair;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox_IconHome;
        private System.Windows.Forms.Button button_BancoDados;
        private System.Windows.Forms.Button buttonMinimizar;
        private System.Windows.Forms.Button button_Home;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button button_Cadastrar;
        private System.Windows.Forms.Button button_Listas;
        private System.Windows.Forms.Panel panel_BotoesCad;
        private System.Windows.Forms.Button button_CadastrarGeneros;
        private System.Windows.Forms.Button button_CadastrarAnimes;
        private System.Windows.Forms.Button button_CadastrarSeriados;
        private System.Windows.Forms.Button button_CadastrarFilmes;
        public System.Windows.Forms.Panel panelPrincipal;
    }
}

