using BibliotecaOraculo.DAL;
using BibliotecaOraculo.Model;
using BibliotecaOraculo.View.Custom;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BibliotecaOraculo.View
{
    public partial class Form_ListaGeneros : Form
    {
        private Genero genero;
        private Genero generoSelecionado;
        private GeneroDAL generoDAL = new GeneroDAL();
        bool mouseDown;
        private Point offset;

        public Form_ListaGeneros(bool cadastrar = false)
        {
            InitializeComponent();

            var lista = generoDAL.BuscarReader();

            textBox_Generos.Enabled = false;
            dataGridView_Generos.DataSource = lista;
            button_Alterar.BackColor = ColorTranslator.FromHtml("#bdc3c7");

            if (cadastrar is true)
            {         
                dataGridView_Generos.Enabled = false;
                textBox_Generos.Enabled = true;
            }
        }

        private void button_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(string.IsNullOrEmpty(textBox_Generos.Text)))
                {
                    genero = new Genero(textBox_Generos.Text);
                    generoDAL.Salvar(genero);
                }
                else
                {
                    ExtendMessageBox.MensagemErro();
                    MessageBox.Show("Campo Vazio");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button_Alterar_Click(object sender, EventArgs e)
        {
            try
            {
                generoDAL.Alterar(generoSelecionado, textBox_Generos.Text);
                ExtendMessageBox.MensagemSucesso();
            }
            catch (Exception error)
            {
                ExtendMessageBox.MensagemErro();
                MessageBox.Show(error.ToString());
            }
            finally
            {
                dataGridView_Generos.Refresh();
                textBox_Generos.Clear();
            }
        }

        private void button_Sair_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void dataGridView_Generos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox_Generos.ReadOnly = true;
                textBox_Generos.Text = dataGridView_Generos.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void dataGridView_Generos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Genero genero = (Genero)dataGridView_Generos.CurrentRow.DataBoundItem;
            generoSelecionado = genero;

            textBox_Generos.Enabled = true;
            button_Salvar.Enabled = false;
            textBox_Generos.ReadOnly = false;

            button_Salvar.BackColor = ColorTranslator.FromHtml("#bdc3c7");
            button_Alterar.BackColor = ColorTranslator.FromHtml("#fdcb6e");
        }



        // INICIO - Eventos Para Movimentar a Tela
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

        private void Form_ListaGeneros_Load(object sender, EventArgs e)
        {

        }
        // FIM - Eventos Para Movimentar a Tela
    }
}
