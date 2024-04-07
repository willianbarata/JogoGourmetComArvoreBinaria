using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoGourmet.Core
{
    public class ClassificacaoDosPratos
    {
        public NodeClassificaPratos Raiz { get; set; }

        public void Adicionar(NodeClassificaPratos noPai, string valor, bool ladoDireito)
        {
            Raiz = AdicionarNode(noPai, valor, ladoDireito);
        }
        public bool EstaVazia()
        {
            return Raiz == null;
        }

        private NodeClassificaPratos AdicionarNode(NodeClassificaPratos noPai, string valor, bool ladoDireito)
        {
            if (noPai == null)
            {
                return new NodeClassificaPratos(valor);
            }
            else if (ladoDireito)
            {
                noPai.PratoFilhoDireito = AdicionarNode(noPai.PratoFilhoDireito, valor, ladoDireito);
            }
            else
            {
                noPai.PratoFilhoEsquerdo = AdicionarNode(noPai.PratoFilhoEsquerdo, valor, ladoDireito);
            }

            return noPai;
        }
    }
}
