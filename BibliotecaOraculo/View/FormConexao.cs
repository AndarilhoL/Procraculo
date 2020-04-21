using System;
using System.Windows.Forms;

namespace BibliotecaOraculo.View
{
    public partial class FormConexao : Form
    {

        public FormConexao()
        {
            InitializeComponent();
        }

        private void button_Testar_Click(object sender, EventArgs e)
        {
            ConexaoSqlServer conn = new ConexaoSqlServer();
            conn.TestarConexao();
        }
    }
}
