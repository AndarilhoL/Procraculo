using System.Windows.Forms;

namespace BibliotecaOraculo.View.Custom
{
    public static class ExtendMessageBox
    {
        public static DialogResult MensagemSucesso()
        {
            var messageBox_Custom = new MessageBox_Custom("#2ECC71", "Deu bom meu Rei", "sucesso", 135, 136, 107, 12, 255, 102);
            var retornoForm = messageBox_Custom.ShowDialog();

            return retornoForm;
        }

        public static DialogResult MensagemErro()
        {
            var messageBox_Custom = new MessageBox_Custom("#D75A4A", "Erro", "erro", 8, 9, 12, 57, 100, 100);
            var retornoForm = messageBox_Custom.ShowDialog();

            return retornoForm;
        }

        public static DialogResult MensagemAlerta()
        {
            var messageBox_Custom = new MessageBox_Custom("#FFA100", "ATENÇÃO", "alerta", 8, 9, 12, 57, 67, 64);
            var retornoForm = messageBox_Custom.ShowDialog();

            return retornoForm;
        }
    }
}
