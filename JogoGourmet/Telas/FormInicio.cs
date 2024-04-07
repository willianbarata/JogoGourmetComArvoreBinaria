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
    public partial class FormInicio : Form
    {
        private bool fechandoComBotaoOK = false;
        private bool estaCorreto = false;
        public FormInicio(string mensagem, bool estaCorretoErrado)
        {
            InitializeComponent();
            lblTextoInicial.Text = mensagem;
            this.FormClosing += FormInicio_FormClosing;
            this.FormClosed += FormInicio_FormClosed;
            this.estaCorreto = estaCorretoErrado;
        }

        public DialogResult ExibeMensagemEFixaNaTela()
        {
            return ShowDialog();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            fechandoComBotaoOK = true;
            DialogResult = DialogResult.OK;
            Close();
        }

        //Dispara quando está prestes à fechar o formulário
        private void FormInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !fechandoComBotaoOK && estaCorreto == false)
            {
                Application.Exit();
            }
            if (estaCorreto)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void FormInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            fechandoComBotaoOK = false;
        }
    }
}
