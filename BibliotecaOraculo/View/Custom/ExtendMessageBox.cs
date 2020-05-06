using System.Windows.Forms;

namespace BibliotecaOraculo.View.Custom
{
    public static class ExtendMessageBox
    {
        public static DialogResult MensagemSucesso()
        {
            var messageBox_Custom = new MessageBox_Custom();
            var retornoForm = messageBox_Custom.ShowDialog();

            return retornoForm;
        }

        public static DialogResult MensagemErro()
        {
            var messageBox_Custom = new MessageBox_Custom();
            var retornoForm = messageBox_Custom.ShowDialog();

            return retornoForm;
        }

        public static DialogResult MensagemAlerta()
        {
            var messageBox_Custom = new MessageBox_Custom();
            var retornoForm = messageBox_Custom.ShowDialog();

            return retornoForm;
        }
    }
}
