using BibliotecaOraculo.DAL;
using BibliotecaOraculo.View;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BibliotecaOraculo
{
    public partial class FormHome : Form
    {
        public static FormConexao formConexao = new FormConexao();
        public static FormCadastroGenero formCadastroGenero = new FormCadastroGenero();
        public UserControlListas userControlListas = new UserControlListas();
        public UserControlListaGeneros userControlListaGeneros = new UserControlListaGeneros();

        bool mouseDown;
        private Point offset;

        public FormHome()
        {
            InitializeComponent();

            toolTipBarraSuperior.SetToolTip(panelSuperior, "Clique e arraste para mover a tela");
        }


        //EVENTOS BOTÕES
        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            button_Home.BackColor = Color.FromArgb(99, 110, 114);
        }

        private void buttonBancoDados_Click(object sender, EventArgs e)
        {
            formConexao.Show();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            formCadastroGenero.Show();
        }

        private void buttonListas_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Add(userControlListas);


            //panelPrincipal.Controls.Add(userControlListaGeneros);
            //GeneroDAL generoDAL = new GeneroDAL();
            //var lista = generoDAL.BuscarReader();
            //userControlListaGeneros.dataGridViewGeneros.DataSource = lista;
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
    }
}
