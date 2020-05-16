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

        //Trabalhar no Construtor para fazer a Extensão do MessageBoxCustomizado
        public MessageBox_Custom(string corFundo, string mensagem, string setarGif, int labelLocalX, int labelLocalY ,int picBoxLocalX, int picBoxLocalY, int largura, int altura, string descricaoLabel = null)
        {
            InitializeComponent();
            timerGif.Start();
            this.BackColor = ColorTranslator.FromHtml(corFundo);
            button_Ok.ForeColor = ColorTranslator.FromHtml(corFundo);
            pictureBox_Gif.Location = new Point(picBoxLocalX, picBoxLocalY);
            pictureBox_Gif.Size = new Size(largura, altura);
            labelMensagem.Text = mensagem;
            labelMensagem.Location = new Point();

            switch (setarGif)
            {
                case "sucesso":
                    //pictureBox_Gif.Image = Image.FromFile("1818-sucess-animation.gif");
                    pictureBox_Gif.Image = BibliotecaOraculo.Properties.Resources._1818_success_animation;
                    break;
                case "erro":
                    pictureBox_Gif.Image = BibliotecaOraculo.Properties.Resources.erro;
                    break;
                case "alerta":
                    pictureBox_Gif.Image = BibliotecaOraculo.Properties.Resources.alert;
                    break;
            }
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
