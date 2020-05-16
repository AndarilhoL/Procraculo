namespace BibliotecaOraculo.View
{
    partial class FormPesquisarImagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesquisarImagem));
            this.panel_Superior = new System.Windows.Forms.Panel();
            this.webBrowserPesquisarImagem = new System.Windows.Forms.WebBrowser();
            this.panelPesquisa = new System.Windows.Forms.Panel();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.panelGoogleImagens = new System.Windows.Forms.Panel();
            this.buttonSair = new System.Windows.Forms.Button();
            this.panel_Superior.SuspendLayout();
            this.panelPesquisa.SuspendLayout();
            this.panelGoogleImagens.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Superior
            // 
            this.panel_Superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panel_Superior.Controls.Add(this.buttonSair);
            this.panel_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Superior.Location = new System.Drawing.Point(0, 0);
            this.panel_Superior.Name = "panel_Superior";
            this.panel_Superior.Size = new System.Drawing.Size(800, 16);
            this.panel_Superior.TabIndex = 7;
            this.panel_Superior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Superior_MouseDown);
            this.panel_Superior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Superior_MouseMove);
            this.panel_Superior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Superior_MouseUp);
            // 
            // webBrowserPesquisarImagem
            // 
            this.webBrowserPesquisarImagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserPesquisarImagem.Location = new System.Drawing.Point(0, 0);
            this.webBrowserPesquisarImagem.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserPesquisarImagem.Name = "webBrowserPesquisarImagem";
            this.webBrowserPesquisarImagem.Size = new System.Drawing.Size(800, 398);
            this.webBrowserPesquisarImagem.TabIndex = 8;
            // 
            // panelPesquisa
            // 
            this.panelPesquisa.Controls.Add(this.buttonPesquisar);
            this.panelPesquisa.Controls.Add(this.textBoxBuscar);
            this.panelPesquisa.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPesquisa.Location = new System.Drawing.Point(0, 16);
            this.panelPesquisa.Name = "panelPesquisa";
            this.panelPesquisa.Size = new System.Drawing.Size(800, 36);
            this.panelPesquisa.TabIndex = 9;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisar.Image = global::BibliotecaOraculo.Properties.Resources.zoom;
            this.buttonPesquisar.Location = new System.Drawing.Point(752, 3);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(36, 30);
            this.buttonPesquisar.TabIndex = 1;
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(4, 4);
            this.textBoxBuscar.Multiline = true;
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(727, 25);
            this.textBoxBuscar.TabIndex = 0;
            // 
            // panelGoogleImagens
            // 
            this.panelGoogleImagens.Controls.Add(this.webBrowserPesquisarImagem);
            this.panelGoogleImagens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGoogleImagens.Location = new System.Drawing.Point(0, 52);
            this.panelGoogleImagens.Name = "panelGoogleImagens";
            this.panelGoogleImagens.Size = new System.Drawing.Size(800, 398);
            this.panelGoogleImagens.TabIndex = 10;
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
            this.buttonSair.Location = new System.Drawing.Point(781, 0);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(16, 16);
            this.buttonSair.TabIndex = 4;
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // FormPesquisarImagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelGoogleImagens);
            this.Controls.Add(this.panelPesquisa);
            this.Controls.Add(this.panel_Superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPesquisarImagem";
            this.Text = "FormPesquisarImagem";
            this.panel_Superior.ResumeLayout(false);
            this.panelPesquisa.ResumeLayout(false);
            this.panelPesquisa.PerformLayout();
            this.panelGoogleImagens.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Superior;
        private System.Windows.Forms.WebBrowser webBrowserPesquisarImagem;
        private System.Windows.Forms.Panel panelPesquisa;
        private System.Windows.Forms.Panel panelGoogleImagens;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonSair;
    }
}