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
    public partial class FormErro : Form
    {
        public FormErro(string mensagem)
        {
            InitializeComponent();
            lblErro.Text = mensagem;
            
        }
        public DialogResult ExibeFormularioDeErro()
        {
            return ShowDialog();
        }

        private void btnOKErro_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
