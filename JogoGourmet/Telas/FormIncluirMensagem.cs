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
    public partial class FormIncluirMensagem : Form
    {
        public string PratoInserido { get; private set; }
        public FormIncluirMensagem()
        {
            InitializeComponent();
        }
        public DialogResult ExibeFormularioInclusao(string mensagem, string titulo)
        {
            lblMensagemInclusao.Text = mensagem;
            Text = titulo;
            return ShowDialog();
        }

        private void btnOkIncluir_Click(object sender, EventArgs e)
        {
            PratoInserido = txtIncluir.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelarIncluir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
