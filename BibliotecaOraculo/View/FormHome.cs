using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaOraculo
{
    public partial class FormHome : Form
    {
        bool mouseDown;
        private Point offset;
        public FormHome()
        {
            InitializeComponent();

            toolTipBarraSuperior.SetToolTip(panelSuperior, "Clique e arraste para mover a tela");
        }



//Eventos Para Mexer a Tela
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

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            buttonHome.BackColor = Color.FromArgb(99,110,114);
        }
    }
}
