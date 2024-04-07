using JogoGourmet.Telas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JogoGourmet.Core
{
    public class Principal
    {
        public readonly ClassificacaoDosPratos menu = new ClassificacaoDosPratos();
        private bool validarResposta = true;
        public Principal()
        {
            MenuInicial();
        }
        public void MenuInicial()
        {
            menu.Adicionar(null, "Massa", true);
            menu.Adicionar(menu.Raiz, "Lazanha", true);
            menu.Adicionar(menu.Raiz, "Bolo Chocolate", false);
        }

        public void IniciandoJogo()
        {
            FormInicio formInicio = new FormInicio("Pense em um prato que gosta", false);
            DialogResult retornoUsuario = formInicio.ExibeMensagemEFixaNaTela();
            if(retornoUsuario == DialogResult.OK)
            {
                while (validarResposta)
                {
                    ConfirmarPrato(menu.Raiz);
                }
            }
            else
            {
                validarResposta = false;
            }
        }

        public void ConfirmarPrato(NodeClassificaPratos prato)
        {
            FormExibirMensagem exibirMensagem = new FormExibirMensagem();

            string pergunta = "O prato que você pensou é " + prato.Valor + " ?";

            DialogResult retornoUsuario = exibirMensagem.ExibeFormularioComMensagem(pergunta, "Confirm");

            if(retornoUsuario == DialogResult.OK)
            {
                if(prato.NaoTemPratoFilho())
                {
                    Vitoria();
                }
                else
                {
                    ConfirmarPrato(prato.PratoFilhoDireito);
                }
            }
            else
            {
                if(prato.PratoFilhoDireito == null)
                {
                    IncluirPrato(prato);
                    IniciandoJogo();
                }
                else
                {
                    ConfirmarPrato(prato.PratoFilhoEsquerdo);
                }
            }
        }

        public void Vitoria()
        {
            FormInicio vitoria = new FormInicio("Acertei de novo", true);
            DialogResult retornoUsuario = vitoria.ExibeMensagemEFixaNaTela();
            if(retornoUsuario == DialogResult.OK)
            {
                IniciandoJogo();
            }
            else
            {
                IniciandoJogo();
            }
        }

        private void IncluirPrato(NodeClassificaPratos classificacao)
        {
            string prato = "";
            string classificacaoPrato = "";

            FormIncluirMensagem incluirPrato = new FormIncluirMensagem();
            prato = ValidaRetornoUsuario(incluirPrato, "Qual prato você pensou?", "Complete", "Insira um novo prato");
            FormIncluirMensagem incluirClassificacaoDoPrato = new FormIncluirMensagem();
            classificacaoPrato = ValidaRetornoUsuario(incluirClassificacaoDoPrato, prato + " é ________ mas " + classificacao.Valor + " não.", "Complete", "Insira um novo tipo de prato");

            ClassificarDosPratos(classificacao, classificacaoPrato, prato);
        }

        private string ValidaRetornoUsuario(FormIncluirMensagem form, string mensagem, string titulo, string mensagemErro)
        {
            string pratoInformado = "";
            while (true)
            {
                DialogResult retornoBotaoUsuario = form.ExibeFormularioInclusao(mensagem, titulo);
                
                if(retornoBotaoUsuario == DialogResult.OK)
                {
                    if (!string.IsNullOrEmpty(form.PratoInserido))
                    {
                        pratoInformado = form.PratoInserido;
                        break;
                    }
                    else
                    {
                        FormErro erro = new FormErro(mensagemErro);
                        erro.ExibeFormularioDeErro();
                    }
                }
                else
                {
                    FormErro erro = new FormErro(mensagemErro);
                    erro.ExibeFormularioDeErro();
                }
            }
            return pratoInformado;
        }

        private void ClassificarDosPratos(NodeClassificaPratos classificacao, string classePrato, string prato )
        {
            string pratoIncorreto = classificacao.Valor;
            classificacao.Valor = classePrato;
            classificacao.PratoFilhoEsquerdo = new NodeClassificaPratos(pratoIncorreto);
            classificacao.PratoFilhoDireito = new NodeClassificaPratos(prato);
        }
    }
}
