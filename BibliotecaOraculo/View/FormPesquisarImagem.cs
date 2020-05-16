using System.Drawing;
using System.Windows.Forms;

namespace BibliotecaOraculo.View
{
    public partial class FormPesquisarImagem : Form
    {
        bool mouseDown;
        private Point offset;

        public FormPesquisarImagem()
        {
            InitializeComponent();
            webBrowserPesquisarImagem.Navigate("https://www.google.com.br/imghp?hl=pt-BR&tab=wi&ogbl");
        }

        private void panel_Superior_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void panel_Superior_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void panel_Superior_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void buttonSair_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
