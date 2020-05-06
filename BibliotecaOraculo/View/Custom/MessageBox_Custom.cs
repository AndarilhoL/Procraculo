using BibliotecaOraculo.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BibliotecaOraculo.View.Custom
{
    public partial class MessageBox_Custom : Form
    {
        bool mouseDown;
        private Point offset;

        public MessageBox_Custom()
        {
            InitializeComponent();
            timerGif.Start();
        }

        //Trabalhar no Construtor para fazer a Extensão do MessageBoxCustomizado
        public MessageBox_Custom(string corFundo, string descricaoLabel, string mensagem)
        {
            InitializeComponent();
            timerGif.Start();
            this.BackColor = ColorTranslator.FromHtml("");
        }

        private void timerGif_Tick(object sender, EventArgs e)
        {
            PausarGif();
        }

        private void PausarGif()
        {
            pictureBox_Gif.Enabled = false;
            timerGif.Stop();
        }

        private void MessageBox_Custom_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void MessageBox_Custom_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void MessageBox_Custom_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
