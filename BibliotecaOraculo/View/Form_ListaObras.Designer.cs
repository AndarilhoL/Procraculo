namespace BibliotecaOraculo.View
{
    partial class Form_ListaObras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_Superior = new System.Windows.Forms.Panel();
            this.tableLayoutPanelPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.groupBoxBotoes = new System.Windows.Forms.GroupBox();
            this.button_Sair = new System.Windows.Forms.Button();
            this.button_Salvar = new System.Windows.Forms.Button();
            this.button_Alterar = new System.Windows.Forms.Button();
            this.tableLayoutPanelMeio = new System.Windows.Forms.TableLayoutPanel();
            this.panelDadosDaObra = new System.Windows.Forms.Panel();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.groupBoxDados = new System.Windows.Forms.GroupBox();
            this.panelDados = new System.Windows.Forms.Panel();
            this.labelDiaExibicao = new System.Windows.Forms.Label();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDataLancamento = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonPesquisarImagem = new System.Windows.Forms.Button();
            this.DateTimeLancamento = new MetroFramework.Controls.MetroDateTime();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEpisodios = new System.Windows.Forms.TextBox();
            this.labelEpisodios = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.textBoxGeneros = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.gridObras = new MetroFramework.Controls.MetroGrid();
            this.pictureBoxImagemObra = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelPrincipal.SuspendLayout();
            this.panelBotoes.SuspendLayout();
            this.groupBoxBotoes.SuspendLayout();
            this.tableLayoutPanelMeio.SuspendLayout();
            this.panelDadosDaObra.SuspendLayout();
            this.panelGrid.SuspendLayout();
            this.groupBoxDados.SuspendLayout();
            this.panelDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridObras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagemObra)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Superior
            // 
            this.panel_Superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panel_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Superior.Location = new System.Drawing.Point(0, 0);
            this.panel_Superior.Name = "panel_Superior";
            this.panel_Superior.Size = new System.Drawing.Size(1061, 16);
            this.panel_Superior.TabIndex = 6;
            this.panel_Superior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Superior_MouseDown);
            this.panel_Superior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Superior_MouseMove);
            this.panel_Superior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Superior_MouseUp);
            // 
            // tableLayoutPanelPrincipal
            // 
            this.tableLayoutPanelPrincipal.ColumnCount = 1;
            this.tableLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPrincipal.Controls.Add(this.panelBotoes, 0, 1);
            this.tableLayoutPanelPrincipal.Controls.Add(this.tableLayoutPanelMeio, 0, 0);
            this.tableLayoutPanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPrincipal.Location = new System.Drawing.Point(0, 16);
            this.tableLayoutPanelPrincipal.Name = "tableLayoutPanelPrincipal";
            this.tableLayoutPanelPrincipal.RowCount = 2;
            this.tableLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.47926F));
            this.tableLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.52074F));
            this.tableLayoutPanelPrincipal.Size = new System.Drawing.Size(1061, 651);
            this.tableLayoutPanelPrincipal.TabIndex = 7;
            // 
            // panelBotoes
            // 
            this.panelBotoes.Controls.Add(this.groupBoxBotoes);
            this.panelBotoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBotoes.Location = new System.Drawing.Point(3, 579);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(1055, 69);
            this.panelBotoes.TabIndex = 1;
            // 
            // groupBoxBotoes
            // 
            this.groupBoxBotoes.Controls.Add(this.button_Sair);
            this.groupBoxBotoes.Controls.Add(this.button_Salvar);
            this.groupBoxBotoes.Controls.Add(this.button_Alterar);
            this.groupBoxBotoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBotoes.Location = new System.Drawing.Point(0, 0);
            this.groupBoxBotoes.Name = "groupBoxBotoes";
            this.groupBoxBotoes.Size = new System.Drawing.Size(1055, 69);
            this.groupBoxBotoes.TabIndex = 3;
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
            this.button_Sair.Location = new System.Drawing.Point(902, 34);
            this.button_Sair.Name = "button_Sair";
            this.button_Sair.Size = new System.Drawing.Size(150, 32);
            this.button_Sair.TabIndex = 4;
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
            this.button_Salvar.Location = new System.Drawing.Point(3, 11);
            this.button_Salvar.Name = "button_Salvar";
            this.button_Salvar.Size = new System.Drawing.Size(158, 52);
            this.button_Salvar.TabIndex = 2;
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
            this.button_Alterar.Location = new System.Drawing.Point(167, 11);
            this.button_Alterar.Name = "button_Alterar";
            this.button_Alterar.Size = new System.Drawing.Size(155, 52);
            this.button_Alterar.TabIndex = 3;
            this.button_Alterar.Text = "Alterar";
            this.button_Alterar.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanelMeio
            // 
            this.tableLayoutPanelMeio.ColumnCount = 2;
            this.tableLayoutPanelMeio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.59242F));
            this.tableLayoutPanelMeio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.40759F));
            this.tableLayoutPanelMeio.Controls.Add(this.panelDadosDaObra, 0, 0);
            this.tableLayoutPanelMeio.Controls.Add(this.panelGrid, 1, 0);
            this.tableLayoutPanelMeio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMeio.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelMeio.Name = "tableLayoutPanelMeio";
            this.tableLayoutPanelMeio.RowCount = 1;
            this.tableLayoutPanelMeio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMeio.Size = new System.Drawing.Size(1055, 570);
            this.tableLayoutPanelMeio.TabIndex = 2;
            // 
            // panelDadosDaObra
            // 
            this.panelDadosDaObra.Controls.Add(this.groupBoxDados);
            this.panelDadosDaObra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDadosDaObra.Location = new System.Drawing.Point(3, 3);
            this.panelDadosDaObra.Name = "panelDadosDaObra";
            this.panelDadosDaObra.Size = new System.Drawing.Size(263, 564);
            this.panelDadosDaObra.TabIndex = 0;
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.gridObras);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(272, 3);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(780, 564);
            this.panelGrid.TabIndex = 1;
            // 
            // groupBoxDados
            // 
            this.groupBoxDados.Controls.Add(this.panelDados);
            this.groupBoxDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDados.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDados.Name = "groupBoxDados";
            this.groupBoxDados.Size = new System.Drawing.Size(263, 564);
            this.groupBoxDados.TabIndex = 0;
            this.groupBoxDados.TabStop = false;
            this.groupBoxDados.Text = "Dados Obra";
            // 
            // panelDados
            // 
            this.panelDados.Controls.Add(this.label3);
            this.panelDados.Controls.Add(this.buttonPesquisarImagem);
            this.panelDados.Controls.Add(this.pictureBoxImagemObra);
            this.panelDados.Controls.Add(this.labelDiaExibicao);
            this.panelDados.Controls.Add(this.metroDateTime2);
            this.panelDados.Controls.Add(this.labelDataLancamento);
            this.panelDados.Controls.Add(this.comboBox1);
            this.panelDados.Controls.Add(this.DateTimeLancamento);
            this.panelDados.Controls.Add(this.textBox5);
            this.panelDados.Controls.Add(this.label5);
            this.panelDados.Controls.Add(this.textBoxEpisodios);
            this.panelDados.Controls.Add(this.labelEpisodios);
            this.panelDados.Controls.Add(this.labelTipo);
            this.panelDados.Controls.Add(this.textBoxGeneros);
            this.panelDados.Controls.Add(this.label2);
            this.panelDados.Controls.Add(this.textBox1);
            this.panelDados.Controls.Add(this.labelNome);
            this.panelDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDados.Location = new System.Drawing.Point(3, 16);
            this.panelDados.Name = "panelDados";
            this.panelDados.Size = new System.Drawing.Size(257, 545);
            this.panelDados.TabIndex = 2;
            // 
            // labelDiaExibicao
            // 
            this.labelDiaExibicao.AutoSize = true;
            this.labelDiaExibicao.Location = new System.Drawing.Point(9, 311);
            this.labelDiaExibicao.Name = "labelDiaExibicao";
            this.labelDiaExibicao.Size = new System.Drawing.Size(66, 13);
            this.labelDiaExibicao.TabIndex = 18;
            this.labelDiaExibicao.Text = "Dia Exibição";
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.Location = new System.Drawing.Point(12, 327);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime2.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Pesquisar Imagem";
            // 
            // labelDataLancamento
            // 
            this.labelDataLancamento.AutoSize = true;
            this.labelDataLancamento.Location = new System.Drawing.Point(9, 263);
            this.labelDataLancamento.Name = "labelDataLancamento";
            this.labelDataLancamento.Size = new System.Drawing.Size(92, 13);
            this.labelDataLancamento.TabIndex = 15;
            this.labelDataLancamento.Text = "Data Lançamento";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // buttonPesquisarImagem
            // 
            this.buttonPesquisarImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisarImagem.Image = global::BibliotecaOraculo.Properties.Resources.google;
            this.buttonPesquisarImagem.Location = new System.Drawing.Point(27, 451);
            this.buttonPesquisarImagem.Name = "buttonPesquisarImagem";
            this.buttonPesquisarImagem.Size = new System.Drawing.Size(75, 74);
            this.buttonPesquisarImagem.TabIndex = 13;
            this.buttonPesquisarImagem.UseVisualStyleBackColor = true;
            this.buttonPesquisarImagem.Click += new System.EventHandler(this.buttonPesquisarImagem_Click);
            // 
            // DateTimeLancamento
            // 
            this.DateTimeLancamento.Location = new System.Drawing.Point(12, 279);
            this.DateTimeLancamento.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateTimeLancamento.Name = "DateTimeLancamento";
            this.DateTimeLancamento.Size = new System.Drawing.Size(200, 29);
            this.DateTimeLancamento.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 225);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(106, 20);
            this.textBox5.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Em Exibição ";
            // 
            // textBoxEpisodios
            // 
            this.textBoxEpisodios.Location = new System.Drawing.Point(12, 178);
            this.textBoxEpisodios.Name = "textBoxEpisodios";
            this.textBoxEpisodios.Size = new System.Drawing.Size(237, 20);
            this.textBoxEpisodios.TabIndex = 7;
            // 
            // labelEpisodios
            // 
            this.labelEpisodios.AutoSize = true;
            this.labelEpisodios.Location = new System.Drawing.Point(9, 161);
            this.labelEpisodios.Name = "labelEpisodios";
            this.labelEpisodios.Size = new System.Drawing.Size(52, 13);
            this.labelEpisodios.TabIndex = 6;
            this.labelEpisodios.Text = "Episódios";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(9, 112);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(28, 13);
            this.labelTipo.TabIndex = 4;
            this.labelTipo.Text = "Tipo";
            // 
            // textBoxGeneros
            // 
            this.textBoxGeneros.Location = new System.Drawing.Point(12, 79);
            this.textBoxGeneros.Name = "textBoxGeneros";
            this.textBoxGeneros.Size = new System.Drawing.Size(237, 20);
            this.textBoxGeneros.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gêneros";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 20);
            this.textBox1.TabIndex = 1;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(9, 11);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // gridObras
            // 
            this.gridObras.AllowUserToResizeRows = false;
            this.gridObras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridObras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridObras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridObras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridObras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gridObras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridObras.DefaultCellStyle = dataGridViewCellStyle11;
            this.gridObras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridObras.EnableHeadersVisualStyles = false;
            this.gridObras.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridObras.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridObras.Location = new System.Drawing.Point(0, 0);
            this.gridObras.Name = "gridObras";
            this.gridObras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridObras.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gridObras.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridObras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridObras.Size = new System.Drawing.Size(780, 564);
            this.gridObras.TabIndex = 0;
            // 
            // pictureBoxImagemObra
            // 
            this.pictureBoxImagemObra.Location = new System.Drawing.Point(3, 380);
            this.pictureBoxImagemObra.Name = "pictureBoxImagemObra";
            this.pictureBoxImagemObra.Size = new System.Drawing.Size(246, 162);
            this.pictureBoxImagemObra.TabIndex = 19;
            this.pictureBoxImagemObra.TabStop = false;
            // 
            // Form_ListaObras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 667);
            this.Controls.Add(this.tableLayoutPanelPrincipal);
            this.Controls.Add(this.panel_Superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ListaObras";
            this.Text = "Form_ListaFilmes";
            this.tableLayoutPanelPrincipal.ResumeLayout(false);
            this.panelBotoes.ResumeLayout(false);
            this.groupBoxBotoes.ResumeLayout(false);
            this.tableLayoutPanelMeio.ResumeLayout(false);
            this.panelDadosDaObra.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            this.groupBoxDados.ResumeLayout(false);
            this.panelDados.ResumeLayout(false);
            this.panelDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridObras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagemObra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Superior;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPrincipal;
        private System.Windows.Forms.Panel panelBotoes;
        private System.Windows.Forms.GroupBox groupBoxBotoes;
        private System.Windows.Forms.Button button_Sair;
        private System.Windows.Forms.Button button_Salvar;
        private System.Windows.Forms.Button button_Alterar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMeio;
        private System.Windows.Forms.Panel panelDadosDaObra;
        private System.Windows.Forms.GroupBox groupBoxDados;
        private System.Windows.Forms.Panel panelDados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonPesquisarImagem;
        private System.Windows.Forms.PictureBox pictureBoxImagemObra;
        private System.Windows.Forms.Label labelDiaExibicao;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private System.Windows.Forms.Label labelDataLancamento;
        private System.Windows.Forms.ComboBox comboBox1;
        private MetroFramework.Controls.MetroDateTime DateTimeLancamento;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEpisodios;
        private System.Windows.Forms.Label labelEpisodios;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.TextBox textBoxGeneros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Panel panelGrid;
        private MetroFramework.Controls.MetroGrid gridObras;
    }
}