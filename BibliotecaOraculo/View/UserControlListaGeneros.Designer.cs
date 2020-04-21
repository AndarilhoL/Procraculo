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
            this.dataGridViewGeneros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGeneros)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGeneros
            // 
            this.dataGridViewGeneros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGeneros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGeneros.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewGeneros.Name = "dataGridViewGeneros";
            this.dataGridViewGeneros.Size = new System.Drawing.Size(811, 583);
            this.dataGridViewGeneros.TabIndex = 0;
            // 
            // UserControlListaGeneros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewGeneros);
            this.Name = "UserControlListaGeneros";
            this.Size = new System.Drawing.Size(811, 583);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGeneros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewGeneros;
    }
}
