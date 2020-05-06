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

        bool mouseDown;
        private Point offset;

        public FormHome()
        {
            InitializeComponent();

            toolTipBarraSuperior.SetToolTip(panelSuperior, "Clique e arraste para mover a tela");
            RecolherSubMenu();
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

        private void button_Home_Click(object sender, EventArgs e)
        {
            RecolherSubMenu();
        }

        private void buttonBancoDados_Click(object sender, EventArgs e)
        {
            formConexao.Show();
        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            MostrarSubMenu();
        }

        private void button_CadastrarGeneros_Click(object sender, EventArgs e)
        {
            bool cadatrar = true;
            Form_ListaGeneros formListaGeneros = new Form_ListaGeneros(cadatrar);
            formListaGeneros.Show();
        }

        private void button_Listass_Click(object sender, EventArgs e)
        {
            RecolherSubMenu();
            panelPrincipal.Controls.Add(userControlListas);
        }


        //INICIO - Eventos Para Movimentar a Tela
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

        private void RecolherSubMenu()
        {
            panel_BotoesCad.Visible = false;
        }

        private void MostrarSubMenu()
        {
            if (panel_BotoesCad.Visible == false)
            {
                panel_BotoesCad.Visible = true;
            }
        }
        //FIM - Eventos Para Movimentar a Tela
    }
}
