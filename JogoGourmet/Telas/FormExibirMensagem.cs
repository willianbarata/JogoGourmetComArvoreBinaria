using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoGourmet.Telas
{
    public partial class FormExibirMensagem : Form
    {
        public FormExibirMensagem()
        {
            InitializeComponent();
        }

        public DialogResult ExibeFormularioComMensagem(string mensagem, string titulo)
        {
            lblMensagens.Text = mensagem;
            Text = titulo;
            return ShowDialog();
        }

        private void BtnSim_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
