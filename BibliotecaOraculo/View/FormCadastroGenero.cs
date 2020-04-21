using BibliotecaOraculo.DAL;
using BibliotecaOraculo.Model;
using System;
using System.Windows.Forms;

namespace BibliotecaOraculo.View
{
    public partial class FormCadastroGenero : Form
    {
        public FormCadastroGenero()
        {
            InitializeComponent();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(string.IsNullOrEmpty(textBox_Genero.Text)))
                {
                    Genero genero = new Genero(textBox_Genero.Text);
                    GeneroDAL generoDAL = new GeneroDAL();
                    generoDAL.Salvar(genero);
                }
                else
                {
                    MessageBox.Show("Campo Vazio");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
