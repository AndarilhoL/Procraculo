using BibliotecaOraculo.DAL;
using System;
using System.Windows.Forms;

namespace BibliotecaOraculo.View
{
    public partial class UserControlListas : UserControl
    {

        public UserControlListas()
        {
            InitializeComponent();
        }

        private void button_Voltar_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void card_Generos_Click(object sender, EventArgs e)
        {
            Form_ListaGeneros formListaGeneros = new Form_ListaGeneros();
            formListaGeneros.Show();
        }
    }
}
