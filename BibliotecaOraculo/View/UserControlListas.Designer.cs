namespace BibliotecaOraculo.View
{
    partial class UserControlListas
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
            this.button_Voltar = new System.Windows.Forms.Button();
            this.card_Generos = new MetroFramework.Controls.MetroTile();
            this.card_Seriados = new MetroFramework.Controls.MetroTile();
            this.card_Animes = new MetroFramework.Controls.MetroTile();
            this.card_Filmes = new MetroFramework.Controls.MetroTile();
            this.card_Geral = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // button_Voltar
            // 
            this.button_Voltar.FlatAppearance.BorderSize = 0;
            this.button_Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Voltar.Image = global::BibliotecaOraculo.Properties.Resources.voltar64x64;
            this.button_Voltar.Location = new System.Drawing.Point(722, 507);
            this.button_Voltar.Name = "button_Voltar";
            this.button_Voltar.Size = new System.Drawing.Size(78, 74);
            this.button_Voltar.TabIndex = 5;
            this.button_Voltar.UseVisualStyleBackColor = true;
            this.button_Voltar.Click += new System.EventHandler(this.button_Voltar_Click);
            // 
            // card_Generos
            // 
            this.card_Generos.ActiveControl = null;
            this.card_Generos.Location = new System.Drawing.Point(17, 507);
            this.card_Generos.Name = "card_Generos";
            this.card_Generos.Size = new System.Drawing.Size(196, 59);
            this.card_Generos.TabIndex = 4;
            this.card_Generos.Text = "Generos";
            this.card_Generos.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.card_Generos.UseSelectable = true;
            this.card_Generos.UseStyleColors = true;
            this.card_Generos.UseTileImage = true;
            this.card_Generos.Click += new System.EventHandler(this.card_Generos_Click);
            // 
            // card_Seriados
            // 
            this.card_Seriados.ActiveControl = null;
            this.card_Seriados.Location = new System.Drawing.Point(242, 142);
            this.card_Seriados.Name = "card_Seriados";
            this.card_Seriados.Size = new System.Drawing.Size(196, 121);
            this.card_Seriados.TabIndex = 3;
            this.card_Seriados.Text = "Seriados";
            this.card_Seriados.TileImage = global::BibliotecaOraculo.Properties.Resources.breaking_bad;
            this.card_Seriados.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.card_Seriados.UseSelectable = true;
            this.card_Seriados.UseTileImage = true;
            // 
            // card_Animes
            // 
            this.card_Animes.ActiveControl = null;
            this.card_Animes.Location = new System.Drawing.Point(17, 142);
            this.card_Animes.Name = "card_Animes";
            this.card_Animes.Size = new System.Drawing.Size(196, 121);
            this.card_Animes.TabIndex = 2;
            this.card_Animes.Text = "Animes";
            this.card_Animes.TileImage = global::BibliotecaOraculo.Properties.Resources.fma;
            this.card_Animes.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.card_Animes.UseSelectable = true;
            this.card_Animes.UseTileImage = true;
            // 
            // card_Filmes
            // 
            this.card_Filmes.ActiveControl = null;
            this.card_Filmes.Location = new System.Drawing.Point(242, 16);
            this.card_Filmes.Name = "card_Filmes";
            this.card_Filmes.Size = new System.Drawing.Size(196, 121);
            this.card_Filmes.TabIndex = 1;
            this.card_Filmes.Text = "Filmes";
            this.card_Filmes.TileImage = global::BibliotecaOraculo.Properties.Resources.ClubeDaLuta;
            this.card_Filmes.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.card_Filmes.UseSelectable = true;
            this.card_Filmes.UseTileImage = true;
            // 
            // card_Geral
            // 
            this.card_Geral.ActiveControl = null;
            this.card_Geral.Location = new System.Drawing.Point(17, 16);
            this.card_Geral.Name = "card_Geral";
            this.card_Geral.Size = new System.Drawing.Size(196, 121);
            this.card_Geral.TabIndex = 0;
            this.card_Geral.Text = "Geral";
            this.card_Geral.TileImage = global::BibliotecaOraculo.Properties.Resources.video80x80;
            this.card_Geral.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.card_Geral.UseSelectable = true;
            this.card_Geral.UseTileImage = true;
            // 
            // UserControlListas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.button_Voltar);
            this.Controls.Add(this.card_Generos);
            this.Controls.Add(this.card_Seriados);
            this.Controls.Add(this.card_Animes);
            this.Controls.Add(this.card_Filmes);
            this.Controls.Add(this.card_Geral);
            this.Name = "UserControlListas";
            this.Size = new System.Drawing.Size(811, 583);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile card_Filmes;
        private MetroFramework.Controls.MetroTile card_Seriados;
        private MetroFramework.Controls.MetroTile card_Animes;
        private MetroFramework.Controls.MetroTile card_Generos;
        private MetroFramework.Controls.MetroTile card_Geral;
        private System.Windows.Forms.Button button_Voltar;
    }
}
