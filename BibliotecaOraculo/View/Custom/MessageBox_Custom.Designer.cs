namespace BibliotecaOraculo.View.Custom
{
    partial class MessageBox_Custom
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
            this.components = new System.ComponentModel.Container();
            this.button_Ok = new System.Windows.Forms.Button();
            this.panel_Superior = new System.Windows.Forms.Panel();
            this.labelMensagem = new System.Windows.Forms.Label();
            this.timerGif = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_Gif = new System.Windows.Forms.PictureBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Gif)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Ok
            // 
            this.button_Ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.button_Ok.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Ok.FlatAppearance.BorderSize = 0;
            this.button_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Ok.ForeColor = System.Drawing.Color.Gray;
            this.button_Ok.Location = new System.Drawing.Point(163, 163);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(136, 41);
            this.button_Ok.TabIndex = 0;
            this.button_Ok.Text = "OK";
            this.button_Ok.UseVisualStyleBackColor = false;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // panel_Superior
            // 
            this.panel_Superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel_Superior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Superior.Location = new System.Drawing.Point(0, 211);
            this.panel_Superior.Name = "panel_Superior";
            this.panel_Superior.Size = new System.Drawing.Size(460, 13);
            this.panel_Superior.TabIndex = 2;
            // 
            // labelMensagem
            // 
            this.labelMensagem.AutoSize = true;
            this.labelMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.labelMensagem.Location = new System.Drawing.Point(135, 136);
            this.labelMensagem.Name = "labelMensagem";
            this.labelMensagem.Size = new System.Drawing.Size(209, 24);
            this.labelMensagem.TabIndex = 4;
            this.labelMensagem.Text = "(aguarda mensagem)";
            // 
            // timerGif
            // 
            this.timerGif.Interval = 1550;
            this.timerGif.Tick += new System.EventHandler(this.timerGif_Tick);
            // 
            // pictureBox_Gif
            // 
            this.pictureBox_Gif.Location = new System.Drawing.Point(12, 54);
            this.pictureBox_Gif.Name = "pictureBox_Gif";
            this.pictureBox_Gif.Size = new System.Drawing.Size(91, 79);
            this.pictureBox_Gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Gif.TabIndex = 3;
            this.pictureBox_Gif.TabStop = false;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.labelDescricao.Location = new System.Drawing.Point(109, 76);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(156, 16);
            this.labelDescricao.TabIndex = 5;
            this.labelDescricao.Text = "(aguarda mensagem)";
            this.labelDescricao.Visible = false;
            // 
            // MessageBox_Custom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(460, 224);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.labelMensagem);
            this.Controls.Add(this.pictureBox_Gif);
            this.Controls.Add(this.panel_Superior);
            this.Controls.Add(this.button_Ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBox_Custom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MessageBox_Custom_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MessageBox_Custom_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MessageBox_Custom_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Gif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Panel panel_Superior;
        private System.Windows.Forms.Label labelMensagem;
        private System.Windows.Forms.Timer timerGif;
        private System.Windows.Forms.PictureBox pictureBox_Gif;
        private System.Windows.Forms.Label labelDescricao;
    }
}