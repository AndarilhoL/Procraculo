using System;
using System.Drawing;
using System.Windows.Forms;

namespace BibliotecaOraculo.View
{
    public partial class FormConexao : Form
    {
        bool mouseDown;
        private Point offset;

        public FormConexao()
        {
            InitializeComponent();
        }

        private void button_Testar_Click(object sender, EventArgs e)
        {
            ConexaoSqlServer conn = new ConexaoSqlServer();
            conn.TestarConexao();
        }


        //Eventos Para Movimentar a Tela
        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void panelSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void panelSuperior_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void comboBoxBancos_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxBancos.AccessibilityObject.Value == "MySQL")
            {
                pictureBoxImagem.Visible = true;
            }
        }
    }
}
