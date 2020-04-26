using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
